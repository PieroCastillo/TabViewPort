using Avalonia.Interactivity;

namespace TabViewPort
{
    public class TabViewTabDragCompletedEventArgs : RoutedEventArgs
    {
        public object DropResult { get; }
        public object Item { get; }
        public TabViewItem Tab { get; }
    }
}