using Avalonia.Interactivity;

namespace TabViewPort
{
    public class TabViewTabDroppedOutSideEventsArgs : RoutedEventArgs
    {
        public object Item { get; }
        public TabViewItem Tab { get; }
    }
}