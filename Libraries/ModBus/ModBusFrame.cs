using System;

namespace ModBus
{
    /// <summary>
    /// The class implements one packet of measurement detector 
    /// </summary
    ///>
    [Serializable]
    public class ModBusFrame
    {
        private byte[] _data;
        private bool _isNull;
        public DateTime RetrieveTime { get; set; }

        public ModBusFrame(byte[] data)
        {
            _data = data;
            _isNull = false;
            RetrieveTime = DateTime.Now;
        }
        public ModBusFrame()
        {
            _isNull = true;
        }
        public bool IsNull
        {
            get => _isNull;
        }
        public double TemperatureRateAlarmSpeed
        {
            get => ((double)_data[21] / 10);
        }

        public byte TemperatureRateAlarmPosition
        {
            get => _data[23];
        }
        public byte MaxTemperaturePosition
        {
            get => _data[19];
        }
        public double MaxTemperatureValue
        {
            get => 25.6 + ((double)_data[17] / 10);
        }
    }
}
