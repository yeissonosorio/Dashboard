namespace Dashboard;

public partial class MainPage : ContentPage
{
    private bool frameEnabled = true;
    private bool frameEnabled1 = true;

    public MainPage()
    {
        InitializeComponent();
        
    }


    //Evento al precionar el icono de inicio Secion
    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        //le envia la un string a la siguiente pagina
        await Navigation.PushAsync(new Secion("Cine"));
    }

    //Evento al precionar el frame de San Pedro Sula
    private async void SPS(object sender, EventArgs e)
    {
        if (frameEnabled)
        {
            // Desactivar el Frame para evitar clics m�ltiples
            frameEnabled = false;

            // Aqu� puedes implementar la navegaci�n a otra p�gina
            await Navigation.PushAsync(new Sala_Reserva());

            // Habilitar el Frame despu�s de un retraso
            await Task.Delay(1000); // Cambia este valor 
            frameEnabled = true;
        }
    }

    //Evento al precionar el frame de tegucigalpa
    private async void TGU(object sender, EventArgs e)
    {
        if (frameEnabled1)
        {
            // Desactivar el Frame para evitar clics m�ltiples
            frameEnabled1 = false;

            // Aqu� puedes implementar la navegaci�n a otra p�gina
            await Navigation.PushAsync(new Secion("Cine"));

            // Habilitar el Frame despu�s de un retraso
            await Task.Delay(1000); // Cambia este valor 
            frameEnabled1 = true;
        }
    }
}