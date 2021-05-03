using Avalonia.Interactivity;

namespace TabViewPort
{
    public class TabViewTabCloseRequestedEventArgs : RoutedEventArgs
    {
        public object Item { get; }
        public TabViewItem Tab { get; }
    }
}