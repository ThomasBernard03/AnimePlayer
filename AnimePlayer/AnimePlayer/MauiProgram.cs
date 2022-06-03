using AnimePlayer.Commons;
using AnimePlayer.Services;
using AnimePlayer.Services.Interfaces;
using AnimePlayer.ViewModels;
using AnimePlayer.Views;
using CsharpTools.Services;
using CsharpTools.Services.Interfaces;

namespace AnimePlayer;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder().UsePrismApp<App>()
			.RegisterTypes(containerRegistery =>
            {
                RegisterForNavigation(containerRegistery);
                RegisterServices(containerRegistery);
            })
			.OnAppStart(async navigationService => await navigationService.NavigateAsync($"{Constants.NavigationPage}/{Constants.HomePage}"))
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Icons.ttf", Constants.IconsFont);
            });

		return builder.Build();
	}

    private static void RegisterForNavigation(IContainerRegistry containerRegistery)
    {
        containerRegistery.RegisterForNavigation<HomePage, HomeViewModel>();
        containerRegistery.RegisterForNavigation<TitlePage, TitleViewModel>();

        containerRegistery.RegisterForNavigation<NavigationPage>();
    }

    private static void RegisterServices(IContainerRegistry containerRegistery)
    {
        containerRegistery.RegisterSingleton<ITitleService, TitleService>();
        containerRegistery.RegisterSingleton<IHttpService, HttpService>();
    }
}
