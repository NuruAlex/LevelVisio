using FilesDataBase;
using FilesDataBase.DrawingData;
using FilesDataBase.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace LevelVisio.Painting
{
    public static class Geometry
    {
        #region Distance
        public static double FindDistance(Point a, Point b) => Math.Sqrt((Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2)));
        public static double FindDistance(double lenght, double height) => Math.Sqrt((Math.Pow(lenght, 2)) + (Math.Pow(height, 2)));
        public static double FindRealDistance(Point a, Point b, Size cellSize)
        {
            double lenght = Math.Abs((double.Parse(a.X.ToString()) - double.Parse(b.X.ToString())) / double.Parse(cellSize.Width.ToString()));
            double height = Math.Abs((double.Parse(a.Y.ToString()) - double.Parse(b.Y.ToString())) / double.Parse(cellSize.Height.ToString()));

            return FindDistance(lenght, height);
        }
        public static double FindRealDistance(Point a, Point b) => FindRealDistance(a, b, PaintingField.CellSize);

        public static Point FindNearesPoint(Point currentPoint) => FindNearesPoint(currentPoint, PaintingField.CellSize);
        public static Point FindNearesPoint(Point currentPoint, Size cellSize)
        {
            if (cellSize.Width == 0 || cellSize.Height == 0)
                return new Point(-100, -100);

            if (currentPoint.X % cellSize.Width == 0 && currentPoint.Y % cellSize.Height == 0)
                return currentPoint;


            int xRight = currentPoint.X + Convert.ToInt32(cellSize.Width - currentPoint.X % cellSize.Width);
            int xLeft = xRight - Convert.ToInt32(cellSize.Width);
            int yHigher = currentPoint.Y + Convert.ToInt32(cellSize.Height - currentPoint.Y % cellSize.Height);
            int yLower = yHigher - Convert.ToInt32(cellSize.Height);

            if (currentPoint.Y % Convert.ToInt32(cellSize.Height) != 0 && currentPoint.X % Convert.ToInt32(cellSize.Width) == 0)
            {

                int distanceHigher = yHigher - currentPoint.Y;
                int distanceLower = currentPoint.Y - yLower;
                if (distanceLower > distanceHigher)
                    return new Point(currentPoint.X, yHigher);
                else
                    return new Point(currentPoint.X, yLower);
            }
            if (currentPoint.Y % Convert.ToInt32(cellSize.Height) == 0 && currentPoint.X % Convert.ToInt32(cellSize.Width) != 0)
            {

                int distanceRight = xRight - currentPoint.X;
                int distanceLeft = currentPoint.X - xLeft;

                if (distanceLeft > distanceRight)
                    return new Point(xRight, currentPoint.Y);
                else
                    return new Point(xLeft, currentPoint.Y);
            }

            if (currentPoint.Y % Convert.ToInt32(cellSize.Height) != 0 && currentPoint.X % Convert.ToInt32(cellSize.Width) != 0)
            {
                Point point00 = new Point(xLeft, yLower);
                Point point01 = new Point(xLeft, yHigher);
                Point point10 = new Point(xRight, yLower);
                Point point11 = new Point(xRight, yHigher);

                Point[] NearesPoints = new Point[4] { point00, point01, point10, point11 };

                double smallestDistance = double.MaxValue;
                Point Nearest = new Point(-1, -1);

                foreach (Point point in NearesPoints)
                {
                    if (smallestDistance > FindDistance(point, currentPoint))
                    {
                        smallestDistance = FindDistance(point, currentPoint);
                        Nearest = point;

                    }
                }
                return Nearest;
            }

            return new Point(-100, -100);
        }

        public static List<Point> ParseLine(Point start, Point end, int metersAmount)
        {
            List<Point> meters = new List<Point>();
            for (int i = 1; i < metersAmount + 1; i++)
            {
                int x, y;
                if (start.X == end.X)
                {
                    x = start.X;
                    if (start.Y > end.Y)
                        y = start.Y - (Math.Abs(start.Y - end.Y)) / metersAmount * i;
                    else
                        y = start.Y + (Math.Abs(start.Y - end.Y)) / metersAmount * i;
                }
                else if (start.Y == end.Y)
                {
                    if (start.X > end.X)
                        x = start.X - (Math.Abs(start.X - end.X)) / metersAmount * i;
                    else
                        x = start.X + (Math.Abs(start.X - end.X)) / metersAmount * i;

                    y = start.Y;
                }
                else
                {
                    if (start.X > end.X)
                        x = start.X - (Math.Abs(start.X - end.X)) / metersAmount * i;
                    else
                        x = start.X + (Math.Abs(start.X - end.X)) / metersAmount * i;

                    if (start.Y > end.Y)
                        y = start.Y - (Math.Abs(start.Y - end.Y)) / metersAmount * i;
                    else
                        y = start.Y + (Math.Abs(start.Y - end.Y)) / metersAmount * i;
                }

                meters.Add(new Point(x, y));
            }
            return meters;
        }

        public static int FindNearestChannelPointIndex(Point currentLocation, Channel channel)
        {
            double distance = double.MaxValue;
            int selectedPointIndex = 0;

            for (int i = 0; i < channel.DrawingData.Points.Count; i++)
            {
                Point start = currentLocation;
                Point end = ConvertToPoint(channel.DrawingData.Points[i]);
                double currentDistance = Convert.ToInt32(FindRealDistance(start, end));

                if (distance > currentDistance && i > 0)
                {
                    selectedPointIndex = i; // founded
                    distance = currentDistance;
                }
            }
            return selectedPointIndex;
        }

        #endregion

        #region Counting

        public static double CountProportion(Size imageSize)
        {
            if (imageSize.Height > imageSize.Width || imageSize.Height == imageSize.Width)
                return Convert.ToDouble(imageSize.Width) / Convert.ToDouble(imageSize.Height);

            return Convert.ToDouble(imageSize.Height) / Convert.ToDouble(imageSize.Width);
        }

        public static Size CountCellSize(Size scaledImage, double realWidth, double realHeight)
        {
            double cellWidth = double.Parse(scaledImage.Width.ToString()) / realWidth;
            double cellHeight = double.Parse(scaledImage.Height.ToString()) / realHeight;

            return new Size(Convert.ToInt32(cellWidth), Convert.ToInt32(cellHeight));
        }
        public static Size CountScaledSize(Image original, Size pictureBoxSize)
        {
            Size _scaledSize;
            double sizePropotion = CountProportion(original.Size);

            if (original.Height > original.Width || original.Height == original.Width)
            {
                _scaledSize = new Size(Convert.ToInt32(pictureBoxSize.Height * sizePropotion), pictureBoxSize.Height);
                PaintingField.SchemeStartPosition = new Point(Convert.ToInt32((pictureBoxSize.Width - _scaledSize.Width) / 2), 0);
            }
            else
            {
                _scaledSize = new Size(pictureBoxSize.Width, Convert.ToInt32(pictureBoxSize.Width * sizePropotion));
                PaintingField.SchemeStartPosition = new Point(0, Convert.ToInt32((pictureBoxSize.Height - _scaledSize.Height) / 2));
            }
            return _scaledSize;
        }
        
        public static Position ConvertToOffsets(Point point) => ConvertToOffsets(point, PaintingField.ScaledImage.Size);
        public static Position ConvertToOffsets(Point point, Size imageSize) => new Position
        {
            TopPropotrion = double.Parse(point.Y.ToString()) / double.Parse(imageSize.Height.ToString()),
            LeftPropotrion = double.Parse(point.X.ToString()) / double.Parse(imageSize.Width.ToString())
        };
       
        public static Point ConvertToPoint(Position position) => ConvertToPoint(position, PaintingField.ScaledImage.Size);
        public static Point ConvertToPoint(Position position, Size imageSize) => new Point
        {
            X = Convert.ToInt32(position.LeftPropotrion * imageSize.Width),
            Y = Convert.ToInt32(position.TopPropotrion * imageSize.Height)
        };
        public static Point CountLabelPoint(Point detectorPoint, SigningType type)
        {
            switch (type)
            {
                case SigningType.Top: return new Point(detectorPoint.X - 35, detectorPoint.Y - 35);
                case SigningType.TopLeft: return new Point(detectorPoint.X - 70, detectorPoint.Y - 35);
                case SigningType.TopRight: return new Point(detectorPoint.X + 25, detectorPoint.Y - 35);
                case SigningType.MidleLeft: return new Point(detectorPoint.X - 110, detectorPoint.Y - 10);
                case SigningType.MidleRight: return new Point(detectorPoint.X + 10, detectorPoint.Y - 10);
                case SigningType.Under: return new Point(detectorPoint.X - 35, detectorPoint.Y + 25);
                case SigningType.UnderLeft: return new Point(detectorPoint.X - 70, detectorPoint.Y + 25);
                case SigningType.UnderRight: return new Point(detectorPoint.X + 10, detectorPoint.Y + 10);
                default: return Point.Empty;
            }
        }
        public static Point CorrectPoint(Point point, Image image)
        {
            if (point.X <= 0)
                point.X = 10;
            if (point.X >= image.Width)
                point.X = image.Width - 10;

            if (point.Y <= 0)
                point.Y = 10;
            if (point.Y >= image.Height)
                point.Y = image.Height - 10;
            return point;
        }
        public static Point CorrectPoint(Point point) => CorrectPoint(point, PaintingField.ScaledImage);
        public static Point CountDetectorPosition(Point detectorPosition)
        {
            detectorPosition.X -= PaintingField.SchemeStartPosition.X;
            detectorPosition.Y -= PaintingField.SchemeStartPosition.Y;

            Point position = FindNearesPoint(detectorPosition, PaintingField.CellSize);
            return CorrectPoint(position);
        }
        public static Point CountScaledStart() => new Point(PaintingField.StartPoint.X + PaintingField.SchemeStartPosition.X, PaintingField.StartPoint.Y + PaintingField.SchemeStartPosition.Y);
        public static Point CountEndPoint(Point realEnd)
        {
            realEnd.X -= PaintingField.SchemeStartPosition.X;
            realEnd.Y -= PaintingField.SchemeStartPosition.Y;
            return Geometry.CorrectPoint(Geometry.FindNearesPoint(realEnd, PaintingField.CellSize));
        }


        #endregion
    }
}
