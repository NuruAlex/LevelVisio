namespace ModBus
{
    public enum ModBusExceptions
    {
        /// <summary>Constant for exception illegal function.</summary>
        IllegalFunction = 1,
        /// <summary>Constant for exception illegal data address.</summary>
        IllegalDataAdr = 2,
        /// <summary>Constant for exception illegal data value.</summary>
        IllegalDataVal = 3,
        /// <summary>Constant for exception slave device failure.</summary>
        SlaveDeviceFailure = 4,
        /// <summary>Constant for exception acknowledge. This is triggered if a write request is executed while the watchdog has expired.</summary>
        Ack = 5,
        /// <summary>Constant for exception slave is busy/booting up.</summary>
        SlaveIsBusy = 6,
        /// <summary>Constant for exception gate path unavailable.</summary>
        GatePathUnavailable = 10,
        /// <summary>Constant for exception not connected.</summary>
        ExceptionNotConnected = 253,
        /// <summary>Constant for exception connection lost.</summary>
        ExceptionConnectionLost = 254,
        /// <summary>Constant for exception response timeout.</summary>
        ExceptionTimeout = 255,
        /// <summary>Constant for exception wrong offset.</summary>
        ExceptionOffset = 128,
        /// <summary>Constant for exception send failt.</summary>
        SendFailt = 100,

    }
}
