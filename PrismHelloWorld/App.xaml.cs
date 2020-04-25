using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using PrismHelloWorld.Main;
using PrismHelloWorld.Views;
using Windows.UI.Xaml;

namespace PrismHelloWorld
{
    sealed partial class App : PrismApplication
    {
        public App()
        {
            this.InitializeComponent();
        }

        protected override UIElement CreateShell() => Container.Resolve<Shell>();

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<MainModule>();
        }
    }
}
