using ManejoDeDatos.Interfaces;
using ManejoDeDatos.Models;
using ManejoDeDatos.Repositories;

namespace ManejoDeDatos
{
    public partial class MainPage : ContentPage
    {
        IEstuduanteUDLARepository _estuduanteUDLARepository;
        EstudianteUDLA estudiante = new EstudianteUDLA();

        public MainPage()
        {
            _estuduanteUDLARepository = new EstudianteUDLAPorArchivosRepository();
            InitializeComponent();


            estudiante = _estuduanteUDLARepository.DevuelveEstudianteUDLA(1);

            BindingContext = estudiante;
        }

        private async void GuardarEstudiante_Click(object sender, EventArgs e)
        {
            EstudianteUDLA estudiante = new EstudianteUDLA
            {
                Id = Int32.Parse(editor_id.Text),
                Nombre = editor_nombre.Text,
                Carrera = editor_carrera.Text,

            };

            bool guardar_estudiante = _estuduanteUDLARepository.CrearEstudianteUDLA(estudiante);

            if (guardar_estudiante)
            {
                await DisplayAlert("Alert", "Todo bien y correcto", "Ok");
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("Alert", "Estas mal amigo", "Ok");
            }

        }

    }

}
