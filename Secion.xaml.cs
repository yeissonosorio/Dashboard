namespace Dashboard;

public partial class Secion : ContentPage
{
    String Tipo;
    //Recibe el contenido de la pagina anterior
    public Secion(String tipo)
    {
        InitializeComponent();
        //Hacer invisible la barra
        Shell.SetTabBarIsVisible(this, false);
        //Recibe el valor
        Tipo = tipo;

    }
    private async void Btnprocesar_Clicked(object sender, EventArgs e)
    {
        //Dependiendo el valor se va a volver a pagina
        if (Tipo =="Cine") {
            await Navigation.PushAsync(new MainPage());
            }
        else
        {
            await Navigation.PushAsync(new Historial());
        }
            
    }
}