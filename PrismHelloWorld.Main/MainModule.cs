using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismHelloWorld.Main.ViewModels;
using PrismHelloWorld.Main.Views;

namespace PrismHelloWorld.Main
{
    public class MainModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            // it doesn't work.
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RequestNavigate("ContentRegion", nameof(MainView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainView, MainViewModel>();
        }
    }
}
