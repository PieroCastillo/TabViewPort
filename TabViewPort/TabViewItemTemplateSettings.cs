using System.Drawing;
using Avalonia;
using Avalonia.Media;

namespace TabViewPort
{
    public class TabViewItemTemplateSettings : AvaloniaObject
    {
        public IImage IconElement
        {
            get => GetValue(IconElementProperty);
            set => SetValue(IconElementProperty, value);
        }

        public static readonly StyledProperty<IImage> IconElementProperty =
            AvaloniaProperty.Register<TabViewItemTemplateSettings, IImage>(nameof(IconElement));
    }
}