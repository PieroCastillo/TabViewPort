using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Media;

namespace TabViewPort
{
    public class TabViewItem : ListBoxItem
    {
        public object Header { get; set; }
        public IDataTemplate HeaderTemplate { get; set; }
        public IImage IconSource { get; set; }
        public bool IsClosable { get; set; }
        public TabViewItemTemplateSettings TabViewItemTemplateSettings { get; }
    }
}