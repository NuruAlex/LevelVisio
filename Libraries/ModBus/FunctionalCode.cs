namespace ModBus
{
    public enum FunctionalCode : byte
    {
        /// <summary>
        /// Read Single Coil
        /// </summary>
        ReadCoil = 1,
        /// <summary>
        /// Read Discrete Inputs
        /// </summary>
        ReadDiscreteInputs = 2,
        /// <summary>
        /// Read Holding Register
        /// </summary>
        ReadHoldingRegister = 3,
        /// <summary>
        /// Read Input Register
        /// </summary>
        ReadInputRegister = 4,
        /// <summary>
        /// Read Single Coil
        /// </summary>
        WriteSingleCoil = 5,
        /// <summary>
        /// Read Single Coil
        /// </summary>
        WriteSingleRegister = 6,
        /// <summary>
        /// Read Single Coil
        /// </summary>
        WriteMultipleCoils = 15,
        /// <summary>
        /// Read Single Coil
        /// </summary>
        WriteMultipleRegister = 16,
        /// <summary>
        /// Read Single Coil
        /// </summary>
        ReadWriteMultipleRegister = 23
    }
}
