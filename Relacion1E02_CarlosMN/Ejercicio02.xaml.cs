namespace Relacion1E02_CarlosMN;

public partial class Ejercicio02 : ContentPage
{
	public Ejercicio02()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            string nombre = Nombre.Text;
            string apellido = Apellidos.Text;
            int edad = int.Parse(Edad.Text);

            Usuario usuario = new Usuario(nombre, apellido, edad);
            usuario.ValidarDatos();

            // Si la validación es exitosa, mostraremos una alerta con DisplayAlert()
            if (usuario.TieneAcceso() && usuario.ValidarDatos())
            {
                lblResultado.Text = $"{apellido}, {nombre} : Tienes Acceso al Sistema";
            }
            else
            {
                lblResultado.Text = $"{apellido}, {nombre} : No tienes Acceso al Sistema";
            }

        }
        catch (NombreInvalidoException ex)
        {
            DisplayAlert("Error", ex.Message, "OK");
            LimpiarEntradas();
        }
        catch (ApellidoInvalidoException ex)
        {
            DisplayAlert("Error", ex.Message, "OK");
            LimpiarEntradas();
        }
        catch (EdadInvalidaException ex)
        {
            DisplayAlert("Error", ex.Message, "OK");
            LimpiarEntradas();
        }
    }

    // Metodo para limpiar los campos de texto
    private void LimpiarEntradas()
    {
        Nombre.Text = "";       
        Apellidos.Text = "";    
        Edad.Text = "";         
    }
}