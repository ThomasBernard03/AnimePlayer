using AnimePlayer.ViewModels;

namespace AnimePlayer.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
        BindingContext = new HomeViewModel();
        InitializeComponent();
	}
}