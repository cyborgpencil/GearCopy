using Prism.Unity;
using System.Windows;
using GearCopy.Views;
using Microsoft.Practices.Unity;

namespace GearCopy
{
    public class Bootstrapper :UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            Container.RegisterTypeForNavigation<SimpleCopyView>();
        }

    }
}
