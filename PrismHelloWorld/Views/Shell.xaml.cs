using Prism.Regions;
using System;
using Unity;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PrismHelloWorld.Views
{
    public sealed partial class Shell : Page
    {
        [Dependency]
        public IRegionManager RegionManager { get; set; }

        public Shell()
        {
            InitializeComponent();
        }

        private void NavigateRequestButton_Click(object sender, RoutedEventArgs e)
        {
            RegionManager.RequestNavigate("ContentRegion", "MainView");
        }
    }
}
