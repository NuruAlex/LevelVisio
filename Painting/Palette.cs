using System;
using System.Collections.Generic;
using System.Drawing;

namespace LevelVisio.Painting
{
    public static class Palette
    {
        private static List<Color> _colors = new List<Color>();

        private static void InitializeColors() => _colors = new List<Color>
            {
                Color.Black,
                Color.Red,
                Color.Orange,
                Color.YellowGreen,
                Color.Green,
                Color.Blue,
                Color.Gray,
                Color.OrangeRed,
                Color.IndianRed,
                Color.Violet
            };

        public static Color GetRandomColor()
        {
            if (_colors.Count == 0) InitializeColors();

            int index = new Random().Next(0, _colors.Count);
            Color color = _colors[index];
            _colors.RemoveAt(index);
            return color;
        }
    }
}
