namespace MauiAppMeuCombustivel;

public partial class JogoDaVelha : ContentPage
{
	public JogoDaVelha()
	{
		InitializeComponent();
	}

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}