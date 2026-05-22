namespace MauiAppHotell.Views;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private async void OnHospedagemClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ContratacaoHospedagem());
    }

    private async void OnSobreClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}