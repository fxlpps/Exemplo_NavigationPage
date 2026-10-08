namespace Exemplo_NavigationPage;

public partial class SegundaPage : ContentPage
{
	public SegundaPage()
	{
		InitializeComponent();
	}

    private async void OnClicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new TerceiraPage());
    }
}