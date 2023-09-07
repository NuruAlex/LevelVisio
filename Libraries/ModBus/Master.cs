using System;
using System.Net;
using System.Net.Sockets;
using FilesDataBase.Objects;
namespace ModBus
{
    /// <summary>
    /// Modbus TCP common driver class. 
    /// </summary>

    /// <summary>
    /// Modbus TCP common driver class. 
    /// </summary>
    /// 
    /// This class implements a modbus TCP master driver. It supports the following commands:
    /// 
    /// Read coils
    /// Read discrete inputs
    /// Write single coil
    /// Write multiple cooils
    /// Read holding register
    /// Read input register
    /// Write single register
    /// Write multiple register
    /// 
    /// All commands can be sent in synchronous or asynchronous mode. If a value is accessed
    /// in synchronous mode the program will stop and wait for slave to response. If the 
    /// slave didn't answer within a specified time a timeout exception is called.
    /// The class uses multi threading for both synchronous and asynchronous access. For
    /// the communication two lines are created. This is necessary because the synchronous
    /// thread has to wait for a previous command to finish.
    /// The synchronous channel can be disabled during connection. This can be necessary when
    /// the slave only supports one connection.
    /// 



    /// <summary>
    /// class for access modbus device
    /// </summary>
    public class Master
    {
        // ------------------------------------------------------------------------
        // Private declarations
        private static ushort _timeout = 500;
        private static ushort _refresh = 10;
        private static bool _connected = false;
        private static bool _isAsync = false;

        private Socket _asyncSocket;
        private byte[] _asyncBuffer = new byte[2048];

        private Socket _socket;
        private byte[] _syncBuffer = new byte[2048];

        // ------------------------------------------------------------------------
        /// <summary>Response data event. This event is called when new data arrives</summary>
        public delegate void ResponseData(ushort id, byte unit, byte function, byte[] data);
        /// <summary>Response data event. This event is called when new data arrives</summary>
        public event ResponseData OnResponseData;
        /// <summary>Exception data event. This event is called when the data is incorrect</summary>
        public delegate void ExceptionData(byte exeption);
        /// <summary>Exception data event. This event is called when the data is incorrect</summary>
        public event ExceptionData OnException;

        // ------------------------------------------------------------------------
        /// <summary>Response timeout. If the slave didn't answers within in this time an exception is called.</summary>
        /// <value>The default value is 500ms.</value>
        public ushort timeout
        {
            get { return _timeout; }
            set { _timeout = value; }
        }

        // ------------------------------------------------------------------------
        /// <summary>Refresh timer for slave answer. The class is polling for answer every X ms.</summary>
        /// <value>The default value is 10ms.</value>
        public ushort refresh
        {
            get { return _refresh; }
            set { _refresh = value; }
        }

        // ------------------------------------------------------------------------
        /// <summary>Displays the state of the synchronous channel</summary>
        /// <value>True if channel was diabled during connection.</value>
        public bool NoSyncConnection
        {
            get { return _isAsync; }
        }

        // ------------------------------------------------------------------------
        /// <summary>Shows if a connection is active.</summary>
        public bool connected
        {
            get { return _connected; }
        }

        // ------------------------------------------------------------------------
        /// <summary>Create master instance without parameters.</summary>
        public Master()
        {
        }

        // ------------------------------------------------------------------------
        /// <summary>Create master instance with parameters.</summary>
        /// <param name="ip">IP adress of modbus slave.</param>
        /// <param name="port">Port number of modbus slave. Usually port 502 is used.</param>
        public Master(string ip, ushort port)
        {
            connect(ip, port, false);
        }
        public Master(FireDetector detector)
        {
            connect(detector.Ip, (ushort)detector.Port, true);
        }

        // ------------------------------------------------------------------------
        /// <summary>Create master instance with parameters.</summary>
        /// <param name="ip">IP adress of modbus slave.</param>
        /// <param name="port">Port number of modbus slave. Usually port 502 is used.</param>
        /// <param name="no_sync_connection">Disable second connection for synchronous requests</param>
        public Master(string ip, ushort port, bool no_sync_connection)
        {
            connect(ip, port, no_sync_connection);
        }

        // ------------------------------------------------------------------------
        /// <summary>Start connection to slave.</summary>
        /// <param name="ip">IP adress of modbus slave.</param>
        /// <param name="port">Port number of modbus slave. Usually port 502 is used.</param>
        /// <param name="isAsync">Disable sencond connection for synchronous requests</param>
        public void connect(string ip, ushort port, bool isAsync)
        {
            try
            {
                IPAddress _ip;
                _isAsync = isAsync;
                if (IPAddress.TryParse(ip, out _ip) == false)
                {
                    IPHostEntry hst = Dns.GetHostEntry(ip);
                    ip = hst.AddressList[0].ToString();
                }
                // ----------------------------------------------------------------
                // Connect asynchronous client
                _asyncSocket = new Socket(IPAddress.Parse(ip).AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                _asyncSocket.Connect(new IPEndPoint(IPAddress.Parse(ip), port));
                _asyncSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout, _timeout);
                _asyncSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, _timeout);
                _asyncSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.NoDelay, 1);
                // ----------------------------------------------------------------
                // Connect synchronous client
                if (!_isAsync)
                {
                    _socket = new Socket(IPAddress.Parse(ip).AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    _socket.Connect(new IPEndPoint(IPAddress.Parse(ip), port));
                    _socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout, _timeout);
                    _socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, _timeout);
                    _socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.NoDelay, 1);
                }
                _connected = true;
            }
            catch (System.IO.IOException error)
            {
                _connected = false;
                throw (error);
            }
        }

        // ------------------------------------------------------------------------
        /// <summary>Stop connection to slave.</summary>
        public void disconnect()
        {
            Dispose();
        }

        // ------------------------------------------------------------------------
        /// <summary>Destroy master instance.</summary>
        ~Master()
        {
            Dispose();
        }

        // ------------------------------------------------------------------------
        /// <summary>Destroy master instance</summary>
        public void Dispose()
        {
            if (_asyncSocket != null)
            {
                if (_asyncSocket.Connected)
                {
                    try { _asyncSocket.Shutdown(SocketShutdown.Both); }
                    catch { }
                    _asyncSocket.Close();
                }
                _asyncSocket = null;
            }
            if (_socket != null)
            {
                if (_socket.Connected)
                {
                    try { _socket.Shutdown(SocketShutdown.Both); }
                    catch { }
                    _socket.Close();
                }
                _socket = null;
            }
        }

        internal void CallException(byte exception)
        {
            if ((_asyncSocket == null) || (_socket == null && !_isAsync)) return;
            if (exception == ((byte)(byte)ModBusExceptions.ExceptionConnectionLost))
            {
                _socket = null;
                _asyncSocket = null;
            }
            if (OnException != null) OnException(exception);
        }
        internal static UInt16 SwapUInt16(UInt16 inValue)
        {
            return (UInt16)(((inValue & 0xff00) >> 8) |
                     ((inValue & 0x00ff) << 8));
        }


        // ------------------------------------------------------------------------
        /// <summary>Read coils from slave asynchronous. The result is given in the response function.</summary>
        /// <param name="id">Unique id that marks the transaction. In asynchonous mode this id is given to the callback function.</param>
        /// <param name="unit">Unit identifier (previously slave address). In asynchonous mode this unit is given to the callback function.</param>
        /// <param name="startAddress">Address from where the data read begins.</param>
        /// <param name="numInputs">Length of data.</param>
        public void ReadCoils(ushort id, byte unit, ushort startAddress, ushort numInputs)
        {
            if (numInputs > 2000)
            {
                CallException((byte)ModBusExceptions.IllegalDataVal);
                return;
            }
            WriteDataAsync(CreateReadHeader(id, unit, startAddress, numInputs, FunctionalCode.ReadCoil));
        }

        // ------------------------------------------------------------------------
        /// <summary>Read coils from slave synchronous.</summary>
        /// <param name="id">Unique id that marks the transaction. In asynchonous mode this id is given to the callback function.</param>
        /// <param name="unit">Unit identifier (previously slave address). In asynchonous mode this unit is given to the callback function.</param>
        /// <param name="startAddress">Address from where the data read begins.</param>
        /// <param name="numInputs">Length of data.</param>
        /// <param name="values">Contains the result of function.</param>
        public void ReadCoils(ushort id, byte unit, ushort startAddress, ushort numInputs, ref byte[] values)
        {
            if (numInputs > 2000)
            {
                CallException((byte)ModBusExceptions.IllegalDataVal);
                return;
            }
            values = WriteData(CreateReadHeader(id, unit, startAddress, numInputs, FunctionalCode.ReadCoil));
        }

        // ------------------------------------------------------------------------
        /// <summary>Read discrete inputs from slave asynchronous. The result is given in the response function.</summary>
        /// <param name="id">Unique id that marks the transaction. In asynchonous mode this id is given to the callback function.</param>
        /// <param name="unit">Unit identifier (previously slave address). In asynchonous mode this unit is given to the callback function.</param>
        /// <param name="startAddress">Address from where the data read begins.</param>
        /// <param name="numInputs">Length of data.</param>
        public void ReadDiscreteInputs(ushort id, byte unit, ushort startAddress, ushort numInputs)
        {
            if (numInputs > 2000)
            {
                CallException((byte)ModBusExceptions.IllegalDataVal);
                return;
            }
            WriteDataAsync(CreateReadHeader(id, unit, startAddress, numInputs, FunctionalCode.ReadDiscreteInputs));
        }

        // ------------------------------------------------------------------------
        /// <summary>Read discrete inputs from slave synchronous.</summary>
        /// <param name="id">Unique id that marks the transaction. In asynchonous mode this id is given to the callback function.</param>
        /// <param name="unit">Unit identifier (previously slave address). In asynchonous mode this unit is given to the callback function.</param>
        /// <param name="startAddress">Address from where the data read begins.</param>
        /// <param name="numInputs">Length of data.</param>
        /// <param name="values">Contains the result of function.</param>
        public void ReadDiscreteInputs(ushort id, byte unit, ushort startAddress, ushort numInputs, ref byte[] values)
        {
            if (numInputs > 2000)
            {
                CallException((byte)ModBusExceptions.IllegalDataVal);
                return;
            }
            values = WriteData(CreateReadHeader(id, unit, startAddress, numInputs, FunctionalCode.ReadDiscreteInputs));
        }

        // ------------------------------------------------------------------------
        /// <summary>Read holding registers from slave asynchronous. The result is given in the response function.</summary>
        /// <param name="id">Unique id that marks the transaction. In asynchonous mode this id is given to the callback function.</param>
        /// <param name="unit">Unit identifier (previously slave address). In asynchonous mode this unit is given to the callback function.</param>
        /// <param name="startAddress">Address from where the data read begins.</param>
        /// <param name="numInputs">Length of data.</param>
        public void ReadHoldingRegister(ushort id, byte unit, ushort startAddress, ushort numInputs)
        {
            if (numInputs > 256)
            {
                CallException((byte)ModBusExceptions.IllegalDataVal);
                return;
            }
            WriteDataAsync(CreateReadHeader(id, unit, startAddress, numInputs, FunctionalCode.ReadHoldingRegister));
        }

        // ------------------------------------------------------------------------
        /// <summary>Read holding registers from slave synchronous.</summary>
        /// <param name="id">Unique id that marks the transaction. In asynchonous mode this id is given to the callback function.</param>
        /// <param name="unit">Unit identifier (previously slave address). In asynchonous mode this unit is given to the callback function.</param>
        /// <param name="startAddress">Address from where the data read begins.</param>
        /// <param name="numInputs">Length of data.</param>
        /// <param name="values">Contains the result of function.</param>
        public void ReadHoldingRegister(ushort id, byte unit, ushort startAddress, ushort numInputs, ref byte[] values)
        {
            if (numInputs > 125)
            {
                CallException((byte)ModBusExceptions.IllegalDataVal);
                return;
            }
            values = WriteData(CreateReadHeader(id, unit, startAddress, numInputs, FunctionalCode.ReadHoldingRegister));
        }

        // ------------------------------------------------------------------------
        /// <summary>Read input registers from slave asynchronous. The result is given in the response function.</summary>
        /// <param name="id">Unique id that marks the transaction. In asynchonous mode this id is given to the callback function.</param>
        /// <param name="unit">Unit identifier (previously slave address). In asynchonous mode this unit is given to the callback function.</param>
        /// <param name="startAddress">Address from where the data read begins.</param>
        /// <param name="numInputs">Length of data.</param>
        public void ReadInputRegister(ushort id, byte unit, ushort startAddress, ushort numInputs)
        {
            if (numInputs > 125)
            {
                CallException((byte)ModBusExceptions.IllegalDataVal);
                return;
            }
            WriteDataAsync(CreateReadHeader(id, unit, startAddress, numInputs, FunctionalCode.ReadInputRegister));
        }

        // ------------------------------------------------------------------------
        /// <summary>Read input registers from slave synchronous.</summary>
        /// <param name="id">Unique id that marks the transaction. In asynchonous mode this id is given to the callback function.</param>
        /// <param name="unit">Unit identifier (previously slave address). In asynchonous mode this unit is given to the callback function.</param>
        /// <param name="startAddress">Address from where the data read begins.</param>
        /// <param name="numInputs">Length of data.</param>
        /// <param name="values">Contains the result of function.</param>
        public void ReadInputRegister(ushort id, byte unit, ushort startAddress, ushort numInputs, ref byte[] values)
        {
            if (numInputs > 125)
            {
                CallException((byte)ModBusExceptions.IllegalDataVal);
                return;
            }
            values = WriteData(CreateReadHeader(id, unit, startAddress, numInputs, FunctionalCode.ReadInputRegister));
        }

        // ------------------------------------------------------------------------
        /// <summary>Write single coil in slave asynchronous. The result is given in the response function.</summary>
        /// <param name="id">Unique id that marks the transaction. In asynchonous mode this id is given to the callback function.</param>
        /// <param name="unit">Unit identifier (previously slave address). In asynchonous mode this unit is given to the callback function.</param>
        /// <param name="startAddress">Address from where the data read begins.</param>
        /// <param name="OnOff">Specifys if the coil should be switched on or off.</param>
        public void WriteSingleCoils(ushort id, byte unit, ushort startAddress, bool OnOff)
        {
            byte[] data;
            data = CreateWriteHeader(id, unit, startAddress, 1, 1, FunctionalCode.WriteSingleCoil);
            if (OnOff == true) data[10] = 255;
            else data[10] = 0;
            WriteDataAsync(data);
        }

        // ------------------------------------------------------------------------
        /// <summary>Write single coil in slave synchronous.</summary>
        /// <param name="id">Unique id that marks the transaction. In asynchonous mode this id is given to the callback function.</param>
        /// <param name="unit">Unit identifier (previously slave address). In asynchonous mode this unit is given to the callback function.</param>
        /// <param name="startAddress">Address from where the data read begins.</param>
        /// <param name="OnOff">Specifys if the coil should be switched on or off.</param>
        /// <param name="result">Contains the result of the synchronous write.</param>
        public void WriteSingleCoils(ushort id, byte unit, ushort startAddress, bool OnOff, ref byte[] result)
        {
            byte[] data;
            data = CreateWriteHeader(id, unit, startAddress, 1, 1, FunctionalCode.WriteSingleCoil);
            if (OnOff == true) data[10] = 255;
            else data[10] = 0;
            result = WriteData(data);
        }

        // ------------------------------------------------------------------------
        /// <summary>Write multiple coils in slave asynchronous. The result is given in the response function.</summary>
        /// <param name="id">Unique id that marks the transaction. In asynchonous mode this id is given to the callback function.</param>
        /// <param name="unit">Unit identifier (previously slave address). In asynchonous mode this unit is given to the callback function.</param>
        /// <param name="startAddress">Address from where the data read begins.</param>
        /// <param name="numBits">Specifys number of bits.</param>
        /// <param name="values">Contains the bit information in byte format.</param>
        public void WriteMultipleCoils(ushort id, byte unit, ushort startAddress, ushort numBits, byte[] values)
        {
            ushort numBytes = Convert.ToUInt16(values.Length);
            if (numBytes > 250 || numBits > 2000)
            {
                CallException((byte)ModBusExceptions.IllegalDataVal);
                return;
            }

            byte[] data;
            data = CreateWriteHeader(id, unit, startAddress, numBits, (byte)(numBytes + 2), FunctionalCode.WriteMultipleCoils);
            Array.Copy(values, 0, data, 13, numBytes);
            WriteDataAsync(data);
        }

        // ------------------------------------------------------------------------
        /// <summary>Write multiple coils in slave synchronous.</summary>
        /// <param name="id">Unique id that marks the transaction. In asynchonous mode this id is given to the callback function.</param>
        /// <param name="unit">Unit identifier (previously slave address). In asynchonous mode this unit is given to the callback function.</param>
        /// <param name="startAddress">Address from where the data read begins.</param>
        /// <param name="numBits">Specifys number of bits.</param>
        /// <param name="values">Contains the bit information in byte format.</param>
        /// <param name="result">Contains the result of the synchronous write.</param>
        public void WriteMultipleCoils(ushort id, byte unit, ushort startAddress, ushort numBits, byte[] values, ref byte[] result)
        {
            ushort numBytes = Convert.ToUInt16(values.Length);
            if (numBytes > 250 || numBits > 2000)
            {
                CallException((byte)ModBusExceptions.IllegalDataVal);
                return;
            }

            byte[] data;
            data = CreateWriteHeader(id, unit, startAddress, numBits, (byte)(numBytes + 2), FunctionalCode.WriteMultipleCoils);
            Array.Copy(values, 0, data, 13, numBytes);
            result = WriteData(data);
        }

        // ------------------------------------------------------------------------
        /// <summary>Write single register in slave asynchronous. The result is given in the response function.</summary>
        /// <param name="id">Unique id that marks the transaction. In asynchonous mode this id is given to the callback function.</param>
        /// <param name="unit">Unit identifier (previously slave address). In asynchonous mode this unit is given to the callback function.</param>
        /// <param name="startAddress">Address to where the data is written.</param>
        /// <param name="values">Contains the register information.</param>
        public void WriteSingleRegister(ushort id, byte unit, ushort startAddress, byte[] values)
        {
            if (values.GetUpperBound(0) != 1)
            {
                CallException((byte)ModBusExceptions.IllegalDataVal);
                return;
            }
            byte[] data;
            data = CreateWriteHeader(id, unit, startAddress, 1, 1, FunctionalCode.WriteSingleRegister);
            data[10] = values[0];
            data[11] = values[1];
            WriteDataAsync(data);
        }

        // ------------------------------------------------------------------------
        /// <summary>Write single register in slave synchronous.</summary>
        /// <param name="id">Unique id that marks the transaction. In asynchonous mode this id is given to the callback function.</param>
        /// <param name="unit">Unit identifier (previously slave address). In asynchonous mode this unit is given to the callback function.</param>
        /// <param name="startAddress">Address to where the data is written.</param>
        /// <param name="values">Contains the register information.</param>
        /// <param name="result">Contains the result of the synchronous write.</param>
        public void WriteSingleRegister(ushort id, byte unit, ushort startAddress, byte[] values, ref byte[] result)
        {
            if (values.GetUpperBound(0) != 1)
            {
                CallException((byte)ModBusExceptions.IllegalDataVal);
                return;
            }
            byte[] data;
            data = CreateWriteHeader(id, unit, startAddress, 1, 1, FunctionalCode.WriteSingleRegister);
            data[10] = values[0];
            data[11] = values[1];
            result = WriteData(data);
        }

        // ------------------------------------------------------------------------
        /// <summary>Write multiple registers in slave asynchronous. The result is given in the response function.</summary>
        /// <param name="id">Unique id that marks the transaction. In asynchonous mode this id is given to the callback function.</param>
        /// <param name="unit">Unit identifier (previously slave address). In asynchonous mode this unit is given to the callback function.</param>
        /// <param name="startAddress">Address to where the data is written.</param>
        /// <param name="values">Contains the register information.</param>
        public void WriteMultipleRegister(ushort id, byte unit, ushort startAddress, byte[] values)
        {
            ushort numBytes = Convert.ToUInt16(values.Length);
            if (numBytes > 250)
            {
                CallException((byte)ModBusExceptions.IllegalDataVal);
                return;
            }

            if (numBytes % 2 > 0) numBytes++;
            byte[] data;

            data = CreateWriteHeader(id, unit, startAddress, Convert.ToUInt16(numBytes / 2), Convert.ToUInt16(numBytes + 2), FunctionalCode.WriteMultipleRegister);
            Array.Copy(values, 0, data, 13, values.Length);
            WriteDataAsync(data);
        }

        // ------------------------------------------------------------------------
        /// <summary>Write multiple registers in slave synchronous.</summary>
        /// <param name="id">Unique id that marks the transaction. In asynchonous mode this id is given to the callback function.</param>
        /// <param name="unit">Unit identifier (previously slave address). In asynchonous mode this unit is given to the callback function.</param>
        /// <param name="startAddress">Address to where the data is written.</param>
        /// <param name="values">Contains the register information.</param>
        /// <param name="result">Contains the result of the synchronous write.</param>
        public void WriteMultipleRegister(ushort id, byte unit, ushort startAddress, byte[] values, ref byte[] result)
        {
            ushort numBytes = Convert.ToUInt16(values.Length);
            if (numBytes > 250)
            {
                CallException((byte)ModBusExceptions.IllegalDataVal);
                return;
            }

            if (numBytes % 2 > 0) numBytes++;
            byte[] data;

            data = CreateWriteHeader(id, unit, startAddress, Convert.ToUInt16(numBytes / 2), Convert.ToUInt16(numBytes + 2), FunctionalCode.WriteMultipleRegister);
            Array.Copy(values, 0, data, 13, values.Length);
            result = WriteData(data);
        }

        // ------------------------------------------------------------------------
        /// <summary>Read/Write multiple registers in slave asynchronous. The result is given in the response function.</summary>
        /// <param name="id">Unique id that marks the transaction. In asynchonous mode this id is given to the callback function.</param>
        /// <param name="unit">Unit identifier (previously slave address). In asynchonous mode this unit is given to the callback function.</param>
        /// <param name="startReadAddress">Address from where the data read begins.</param>
        /// <param name="numInputs">Length of data.</param>
        /// <param name="startWriteAddress">Address to where the data is written.</param>
        /// <param name="values">Contains the register information.</param>
        public void ReadWriteMultipleRegister(ushort id, byte unit, ushort startReadAddress, ushort numInputs, ushort startWriteAddress, byte[] values)
        {
            ushort numBytes = Convert.ToUInt16(values.Length);
            if (numBytes > 250)
            {
                CallException((byte)ModBusExceptions.IllegalDataVal);
                return;
            }

            if (numBytes % 2 > 0) numBytes++;
            byte[] data;

            data = CreateReadWriteHeader(id, unit, startReadAddress, numInputs, startWriteAddress, Convert.ToUInt16(numBytes / 2));
            Array.Copy(values, 0, data, 17, values.Length);
            WriteDataAsync(data);
        }

        // ------------------------------------------------------------------------
        /// <summary>Read/Write multiple registers in slave synchronous. The result is given in the response function.</summary>
        /// <param name="id">Unique id that marks the transaction. In asynchonous mode this id is given to the callback function.</param>
        /// <param name="unit">Unit identifier (previously slave address). In asynchonous mode this unit is given to the callback function.</param>
        /// <param name="startReadAddress">Address from where the data read begins.</param>
        /// <param name="numInputs">Length of data.</param>
        /// <param name="startWriteAddress">Address to where the data is written.</param>
        /// <param name="values">Contains the register information.</param>
        /// <param name="result">Contains the result of the synchronous command.</param>
        public void ReadWriteMultipleRegister(ushort id, byte unit, ushort startReadAddress, ushort numInputs, ushort startWriteAddress, byte[] values, ref byte[] result)
        {
            ushort numBytes = Convert.ToUInt16(values.Length);
            if (numBytes > 250)
            {
                CallException((byte)ModBusExceptions.IllegalDataVal);
                return;
            }

            if (numBytes % 2 > 0) numBytes++;
            byte[] data;

            data = CreateReadWriteHeader(id, unit, startReadAddress, numInputs, startWriteAddress, Convert.ToUInt16(numBytes / 2));
            Array.Copy(values, 0, data, 17, values.Length);
            result = WriteData(data);
        }

        // ------------------------------------------------------------------------
        // Create modbus header for read action
        private byte[] CreateReadHeader(ushort id, byte unit, ushort startAddress, ushort length, FunctionalCode function)
        {
            byte[] data = new byte[12];

            byte[] _id = BitConverter.GetBytes((short)id);
            data[0] = _id[1];			    // Slave id high byte
            data[1] = _id[0];				// Slave id low byte
            data[5] = 6;					// Message size
            data[6] = unit;					// Slave address
            data[7] = (byte)function;				// Function code
            byte[] _adr = BitConverter.GetBytes((short)IPAddress.HostToNetworkOrder((short)startAddress));
            data[8] = _adr[0];				// Start address
            data[9] = _adr[1];				// Start address
            byte[] _length = BitConverter.GetBytes((short)IPAddress.HostToNetworkOrder((short)length));
            data[10] = _length[0];			// Number of data to read
            data[11] = _length[1];			// Number of data to read
            return data;
        }

        // ------------------------------------------------------------------------
        // Create modbus header for write action
        private byte[] CreateWriteHeader(ushort id, byte unit, ushort startAddress, ushort numData, ushort numBytes, FunctionalCode function)
        {
            byte[] data = new byte[numBytes + 11];

            byte[] _id = BitConverter.GetBytes((short)id);
            data[0] = _id[1];				// Slave id high byte
            data[1] = _id[0];				// Slave id low byte
            byte[] _size = BitConverter.GetBytes((short)IPAddress.HostToNetworkOrder((short)(5 + numBytes)));
            data[4] = _size[0];				// Complete message size in bytes
            data[5] = _size[1];				// Complete message size in bytes
            data[6] = unit;					// Slave address
            data[7] = (byte)function;				// Function code
            byte[] _adr = BitConverter.GetBytes((short)IPAddress.HostToNetworkOrder((short)startAddress));
            data[8] = _adr[0];				// Start address
            data[9] = _adr[1];				// Start address
            if ((byte)function >= (byte)FunctionalCode.WriteMultipleCoils)
            {
                byte[] _cnt = BitConverter.GetBytes((short)IPAddress.HostToNetworkOrder((short)numData));
                data[10] = _cnt[0];			// Number of bytes
                data[11] = _cnt[1];			// Number of bytes
                data[12] = (byte)(numBytes - 2);
            }
            return data;
        }

        // ------------------------------------------------------------------------
        // Create modbus header for read/write action
        private byte[] CreateReadWriteHeader(ushort id, byte unit, ushort startReadAddress, ushort numRead, ushort startWriteAddress, ushort numWrite)
        {
            byte[] data = new byte[numWrite * 2 + 17];

            byte[] _id = BitConverter.GetBytes((short)id);
            data[0] = _id[1];						// Slave id high byte
            data[1] = _id[0];						// Slave id low byte
            byte[] _size = BitConverter.GetBytes((short)IPAddress.HostToNetworkOrder((short)(11 + numWrite * 2)));
            data[4] = _size[0];						// Complete message size in bytes
            data[5] = _size[1];						// Complete message size in bytes
            data[6] = unit;							// Slave address
            data[7] = (byte)FunctionalCode.ReadWriteMultipleRegister;	// Function code
            byte[] _adr_read = BitConverter.GetBytes((short)IPAddress.HostToNetworkOrder((short)startReadAddress));
            data[8] = _adr_read[0];					// Start read address
            data[9] = _adr_read[1];					// Start read address
            byte[] _cnt_read = BitConverter.GetBytes((short)IPAddress.HostToNetworkOrder((short)numRead));
            data[10] = _cnt_read[0];				// Number of bytes to read
            data[11] = _cnt_read[1];				// Number of bytes to read
            byte[] _adr_write = BitConverter.GetBytes((short)IPAddress.HostToNetworkOrder((short)startWriteAddress));
            data[12] = _adr_write[0];				// Start write address
            data[13] = _adr_write[1];				// Start write address
            byte[] _cnt_write = BitConverter.GetBytes((short)IPAddress.HostToNetworkOrder((short)numWrite));
            data[14] = _cnt_write[0];				// Number of bytes to write
            data[15] = _cnt_write[1];				// Number of bytes to write
            data[16] = (byte)(numWrite * 2);

            return data;
        }

        // ------------------------------------------------------------------------
        // Write asynchronous data
        private void WriteDataAsync(byte[] write_data)
        {
            if ((_asyncSocket != null) && (_asyncSocket.Connected))
            {
                try
                {
                    _asyncSocket.BeginSend(write_data, 0, write_data.Length, SocketFlags.None, new AsyncCallback(OnSend), null);
                }
                catch (SystemException)
                {
                    CallException((byte)ModBusExceptions.ExceptionConnectionLost);
                }
            }
            else CallException((byte)ModBusExceptions.ExceptionConnectionLost);
        }

        // ------------------------------------------------------------------------
        // Write asynchronous data acknowledge
        private void OnSend(IAsyncResult result)
        {
            Int32 size = _asyncSocket.EndSend(result);
            if (result.IsCompleted == false) CallException((byte)ModBusExceptions.SendFailt);
            else _asyncSocket.BeginReceive(_asyncBuffer, 0, _asyncBuffer.Length, SocketFlags.None, new AsyncCallback(OnReceive), _asyncSocket);
        }

        // ------------------------------------------------------------------------
        // Write asynchronous data response
        private void OnReceive(IAsyncResult result)
        {
            if (_asyncSocket == null) return;

            try
            {
                _asyncSocket.EndReceive(result);
                if (result.IsCompleted == false) CallException((byte)ModBusExceptions.ExceptionConnectionLost);
            }
            catch (Exception) { }

            ushort id = SwapUInt16(BitConverter.ToUInt16(_asyncBuffer, 0));
            byte unit = _asyncBuffer[6];
            byte function = _asyncBuffer[7];
            byte[] data;

            // ------------------------------------------------------------
            // Write response data

            if ((function >= (byte)FunctionalCode.WriteSingleCoil) && (function != (byte)FunctionalCode.WriteMultipleRegister))
            {
                data = new byte[2];
                Array.Copy(_asyncBuffer, 10, data, 0, 2);
            }
            // ------------------------------------------------------------
            // Read response data
            else
            {
                data = new byte[_asyncBuffer[8]];
                Array.Copy(_asyncBuffer, 9, data, 0, _asyncBuffer[8]);
            }
            // ------------------------------------------------------------
            // Response data is slave exception
            if (function > ((byte)ModBusExceptions.ExceptionOffset))
            {
                function -= (byte)ModBusExceptions.ExceptionOffset;
                CallException(_asyncBuffer[8]);
            }
            // ------------------------------------------------------------
            // Response data is regular data
            else if (OnResponseData != null) OnResponseData(id, unit, function, data);
        }

        // ------------------------------------------------------------------------
        // Write data and and wait for response
        private byte[] WriteData(byte[] write_data)
        {
            if (_socket.Connected)
            {
                try
                {
                    _socket.Send(write_data, 0, write_data.Length, SocketFlags.None);
                    int result = _socket.Receive(_syncBuffer, 0, _syncBuffer.Length, SocketFlags.None);
                    byte unit = _syncBuffer[6];
                    byte function = _syncBuffer[7];
                    byte[] data;

                    if (result == 0) CallException((byte)ModBusExceptions.ExceptionConnectionLost);

                    // ------------------------------------------------------------
                    // Response data is slave exception
                    if (function > (byte)ModBusExceptions.ExceptionOffset)
                    {
                        function -= (byte)ModBusExceptions.ExceptionOffset;
                        CallException(_syncBuffer[8]);
                        return null;
                    }
                    // ------------------------------------------------------------
                    // Write response data
                    else if ((function >= (byte)FunctionalCode.WriteMultipleCoils) && (function != (byte)FunctionalCode.ReadWriteMultipleRegister))
                    {
                        data = new byte[2];
                        Array.Copy(_syncBuffer, 10, data, 0, 2);
                    }
                    // ------------------------------------------------------------
                    // Read response data
                    else
                    {
                        data = new byte[_syncBuffer[8]];
                        Array.Copy(_syncBuffer, 9, data, 0, _syncBuffer[8]);
                    }
                    return data;
                }
                catch (SystemException)
                {
                    CallException((byte)ModBusExceptions.ExceptionConnectionLost);
                }
            }
            else CallException((byte)ModBusExceptions.ExceptionConnectionLost);
            return null;
        }
    }
}

