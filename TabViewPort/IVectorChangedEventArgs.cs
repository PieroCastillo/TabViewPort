using Microsoft.VisualBasic;

namespace TabViewPort
{
    public interface IVectorChangedEventArgs
    {
        public CollectionChange CollectionChange { get; }
        public uint Index { get; }
    }
}