using FilesDataBase.DrawingData;
using FilesDataBase.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace LevelVisio.Painting
{
    public static class PaintingField
    {
        public static Image ScaledImage { get; set; }
        public static Size CellSize { get; set; }

        public static Point SchemeStartPosition, StartPoint, EndPoint;


        public static Image ScaleImage(Image original, Size pictureBox)
        {
            ScaledImage = new Bitmap(original, Geometry.CountScaledSize(original, pictureBox));
            return ScaledImage;
        }
        public static List<Point> MarkUpChannel(Channel channel)
        {
            List<Point> meters = new List<Point>();

            for (int i = 0; i < channel.DrawingData.Points.Count - 1; i++)
            {
                Point start = Geometry.ConvertToPoint(channel.DrawingData.Points[i]);
                Point end = Geometry.ConvertToPoint(channel.DrawingData.Points[i + 1]);

                int distance = Convert.ToInt32(Geometry.FindRealDistance(start, end));

                meters.AddRange(Geometry.ParseLine(start, end, distance).ToArray());

            }
            return meters;
        }


        #region Painting
        public static void DrawAll(List<FireDetector> detectors, bool withCorrection)
        {
            foreach (FireDetector detector in detectors)
            {
                Point point = Geometry.ConvertToPoint(detector.DrawingData.Position);

                if (withCorrection)
                    point = Geometry.CorrectPoint(Geometry.FindNearesPoint(point));

                DrawDetector(detector.Title, point, detector.DrawingData.PaintingSettings);

                foreach (Channel channel in detector.Channels)
                    DrawChannel(channel, withCorrection);
            }
        }
        private static void DrawChannel(Channel channel, bool withCorrection)
        {
            for (int i = 0; i < channel.DrawingData.Points.Count - 1; ++i)
            {
                Point start = Geometry.ConvertToPoint(channel.DrawingData.Points[i]);
                Point end = Geometry.ConvertToPoint(channel.DrawingData.Points[i + 1]);

                if (withCorrection)
                {
                    start = Geometry.CorrectPoint(Geometry.FindNearesPoint(start));
                    end = Geometry.CorrectPoint(Geometry.FindNearesPoint(end));
                }
                DrawLine(start, end, channel.DrawingData.PaintingSettings);
            }
            DrawChannelId(channel);
        }
        private static void DrawChannelId(Channel channel)
        {
            if (channel.DrawingData.Points.Count < 2)
                return;

            Point idLabel = Geometry.ConvertToPoint(channel.DrawingData.Points[channel.DrawingData.Points.Count - 1]);
            idLabel.Y -= 25;

            using (Graphics g = Graphics.FromImage(ScaledImage))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawString(channel.Id.ToString(), new Font("Calibry", 13f), Brushes.Black, idLabel);
            }
        }

        private static void DrawDetector(string detectortitle, Point point, DetectorPaintingSettings settings)
        {
            using (Graphics g = Graphics.FromImage(ScaledImage))
            using (SolidBrush brush = new SolidBrush(settings.Color))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawString(detectortitle, new Font("Calibry", 13f), Brushes.Black, Geometry.CountLabelPoint(point, settings.SigningType));
                g.FillEllipse(brush, point.X - settings.Radius / 2, point.Y - settings.Radius / 2, settings.Radius, settings.Radius);
            }
        }
        private static void DrawLine(Point start, Point end, ChannelPaintingSettings settings)
        {
            using (Graphics g = Graphics.FromImage(ScaledImage))
            using (Pen pen = new Pen(settings.LineColor, settings.LineWidth))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawLine(pen, start, end);
            }
        }

        public static void ChangeDetectorPosition(FireDetector detector, Point location)
        {
            detector.DrawingData.Position = Geometry.ConvertToOffsets(location);

            foreach (Channel channel in detector.Channels)
                channel.DrawingData.Points[0] = detector.DrawingData.Position;
        }
        #endregion

    }
}
