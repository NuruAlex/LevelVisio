using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControls
{
    public class RotatedLabel : Label
    {

        private int _rotateAngle = 30;
        private string _text;
        private Point _startCoordinates = new Point(20, 20);

        [Category("Appearance")]
        public int RotationAngle
        {
            get => _rotateAngle;
            set
            {
                _rotateAngle = value;
                Invalidate();
            }

        }

        [Category("Appearance")]
        public string RotatedText
        {
            get => _text;
            set
            {
                _text = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        public Point StartTextPosition
        {
            get => _startCoordinates;
            set
            {
                _startCoordinates = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(_startCoordinates.X, _startCoordinates.Y);
            e.Graphics.RotateTransform(_rotateAngle);
            e.Graphics.DrawString(_text, Font, Brushes.Black, 0, 0);
        }
    }
}
