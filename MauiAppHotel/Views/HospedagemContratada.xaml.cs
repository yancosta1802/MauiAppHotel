namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    private void Button_Clicked(EventArgs e)
    {

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
      try
        {

            Navigation.PopAsync();

        } catch (Exception ex)
        {

            DisplayAlert("Ops", ex.Message, "OK");
        }





    }

    private void DisplayAlert(string v1, string message, string v2)
    {
        throw new NotImplementedException();
    }
}