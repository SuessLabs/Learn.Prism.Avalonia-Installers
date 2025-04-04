using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using Prism.DryIoc;
using Prism.Ioc;
using Test.PupNetInstaller.ViewModels;
using Test.PupNetInstaller.Views;

namespace Test.PupNetInstaller;

public partial class App : PrismApplication
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);

        // Required when overriding Initialize
        base.Initialize();
    }

    protected override AvaloniaObject CreateShell()
    {
        return Container.Resolve<MainWindow>();
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
        // Register you Services, Views, Dialogs, etc.
    }
}
