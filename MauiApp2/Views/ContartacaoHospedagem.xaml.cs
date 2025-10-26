namespace MauiApp2.Views;

public partial class ContartacaoHospedagem : ContentPage
{
	public ContartacaoHospedagem()
	{
        InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new sobre());
    }
}