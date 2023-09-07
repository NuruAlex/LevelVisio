using System.Collections.Generic;

namespace LevelVisio.Painting
{
    public class FrameHistory
    {
        private List<Frame> _frames;
        private int _currentFrameIndex;

        public bool CanGoBack => _currentFrameIndex > 0;
        public bool CanGoNext => _currentFrameIndex < _frames.Count - 1;

        public FrameHistory()
        {
            _frames = new List<Frame>();
            _frames.Clear();
            _currentFrameIndex = 0;
        }

        public void AddFrame(Frame frame)
        {
            _frames.Add(frame);
            _currentFrameIndex++;
        }

        public Frame GoNext()
        {
            if (CanGoNext)
            {
                _currentFrameIndex++;
                return _frames[_currentFrameIndex];
            }
            return null;
        }
        public Frame GoBack()
        {
            if (CanGoBack)
            {
                _currentFrameIndex--;
                return _frames[_currentFrameIndex];
            }
            return null;
        }

        ~FrameHistory()
        {
            _frames.Clear();
        }
    }
}
