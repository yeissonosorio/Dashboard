namespace Dashboard;

public partial class Historial : ContentPage
{
    public Historial()
    {
        InitializeComponent();
    }
    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Secion("Historial"));
    }
}