using ModBus;
using System;

namespace ModBus
{
    public class Alert
    {
        private ModBusFrame _frame;
        private string _message = "Система в норме";
        private bool _isAlarm = false;
        private double _position;
        public bool IsAlarm
        {
            get => _isAlarm;
        }

        public double Position
        {
            get => _position;
        }

        public string Message
        {
            get => _message;
        }

        public Alert(ModBusFrame frame)
        {
            if (frame != null)
            {
                _frame = frame;

                if (IsMaxTemperature() || IsRate())
                    return;

                _message = "Система в норме";
                _isAlarm = false;

            }
            else
            {
                _message = "Инициализация";
                _isAlarm = false;
            }
        }
        public bool IsMaxTemperature()
        {
            if (_frame.MaxTemperaturePosition == 0)
                return false;
            _message = $"Время: {DateTime.Now}" +
                $"\nТип: Превышение максимальной температуры" +
                $"\nЗначение: {_frame.MaxTemperatureValue}" +
                $"\nПозиция(м):{_frame.MaxTemperaturePosition}";
            _isAlarm = true;
            _position = _frame.MaxTemperaturePosition;
            return true;
        }
        public bool IsRate()
        {
            if (_frame.TemperatureRateAlarmPosition == 0)
                return false;

            _message = $"Время: {DateTime.Now}" +
            $"\nТип: Превышение скорости роста температуры" +
            $"\nЗначение: {_frame.TemperatureRateAlarmSpeed}" +
            $"\nПозиция(м): {_frame.TemperatureRateAlarmPosition}";
            _isAlarm = true;
            _position = _frame.TemperatureRateAlarmPosition;
            return true;
        }
    }
}
