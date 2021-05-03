using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace  TabViewPort
{
    public partial class TabView : TemplatedControl
    {
        public ICommand AddTabButtonCommand { get; set; }
        public object AddTabButtonCommandParameter { get; set; }
        public bool AllowDropTabs { get; set; }
        public bool CanDragTabs { get; set; }
        public bool CanReorderTabs { get; set; }
        public TabViewCloseButtonOverlayMode CloseButtonOverlayMode { get; set; }
        public bool IsAddTabButtonVisible { get; set; }
        public int SelectedIndex { get; set; }
        public object SelectedItem { get; set; }
        public IList<object> TabItems { get; }
        public object TabItemsSource { get; set; }
        public IDataTemplate TabItemTemplate { get; set; }
        public object TabStripFooter { get; set; }
        public IDataTemplate TabStripFooterTemplate { get; set; }
        public object TabStripHeader { get; set; }
        public IDataTemplate TabStripHeaderTemplate { get; set; }
        public TabViewWidthMode TabWidthMode { get; set; }

        public event TypedEventHandler<TabView, object> AddTabButtonClick;
        public event TypedEventHandler<TabView, TabViewTabCloseRequestedEventArgs> SelectionChanged;
        public event TypedEventHandler<TabView, TabViewTabCloseRequestedEventArgs> TabDragCompleted;
        public event TypedEventHandler<TabView, TabViewTabDragStartingEventArgs> TabDragStarting;
        public event TypedEventHandler<TabView, TabViewTabDroppedOutSideEventsArgs> TabDroppedOutside;
        public event TypedEventHandler<TabView, IVectorChangedEventArgs> TabItemsChanged;
        public event DragEventHandler TabStripDragOver;
        public event DragEventHandler TabStripDrop;
    }
}