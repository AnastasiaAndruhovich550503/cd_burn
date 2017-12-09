using IMAPI2;

namespace CDBurn
{
    class Disc
    {
        public PhysicalMedia DiscType { get; set; }
        public MediaState DiscState { get; set; }
        public long DiscSize { get; set; }
    }
}
