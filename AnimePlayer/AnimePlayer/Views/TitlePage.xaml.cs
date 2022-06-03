namespace AnimePlayer.Views;

public partial class TitlePage : ContentPage
{
	public TitlePage()
	{
		InitializeComponent();
    }

    private void Label_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        ThumbLabel?.RotateTo(360, 500);
    }
}