using Avalonia.Input;
using Avalonia.Interactivity;

namespace TabViewPort
{
    public class TabViewTabDragStartingEventArgs : RoutedEventArgs
    {
        public bool Cancel { get; }
        public IDataObject Data { get; }
        public object Item { get; }
        public TabViewItem Tab { get; }
    }
}