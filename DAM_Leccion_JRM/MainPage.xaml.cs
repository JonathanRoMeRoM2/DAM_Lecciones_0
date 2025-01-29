using DAM_Leccion_JRM.ViewModel;

namespace DAM_Leccion_JRM
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            ejecutar();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        public void ejecutar() {
            PersonaModel personaModel = new PersonaModel() {
                Nombre = "Hola estoy aqui",

            };

            Binding personaBinding = new Binding();
            personaBinding.Source = personaModel; //Origen
            personaBinding.Path = "Nombre";
            txtNombre.SetBinding(Entry.TextProperty, personaBinding); //Destino


            txtNombre.Text = personaModel.Nombre;
            //txtNombre.Text = "Hola estoy aqui";   
        }

        private void btnAceptar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Asistente del sistema","Se ha guardado el registro en la DB","Aceptar");
        }
    }

}
