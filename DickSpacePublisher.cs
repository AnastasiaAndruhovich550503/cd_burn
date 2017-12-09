namespace CDBurn
{
    class DickSpacePublisher
    {
        public delegate void UsedSpaceChangedHandler(long value);
        public event UsedSpaceChangedHandler UsedSpaceChanged;

        public long TotalSpace { get; set; }

        public long UsedSpace
        {
            get => _usedSpace;
            set
            {
                _usedSpace = value;
                UsedSpaceChanged?.Invoke(_usedSpace);
            }
        }

        private long _usedSpace;
    }
}
