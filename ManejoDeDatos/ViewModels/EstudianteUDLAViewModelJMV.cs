using ManejoDeDatos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ManejoDeDatos.ViewModels
{
    public class EstudianteUDLAViewModelJMV : INotifyPropertyChanged
    {
        private List<EstudianteUDLA> _estudiantesUDLA;
        public List<EstudianteUDLA> estudianteUDLA
        {
            get => _estudiantesUDLA;
            set
            {
                if (_estudiantesUDLA != value)
                {
                    _estudiantesUDLA = value;
                    OnPropertyChanged();
                }
            }
        }
        public ICommand CommandGuardarEstudianteUDLA { get; set; }
        public event Action ShowAlert;
        public EstudianteUDLAViewModelJMV()
        {
            CommandGuardarEstudianteUDLA = new Command(GuardarEstudianteUDLA);
        }
        public async void GuardarEstudianteUDLA()
        {
            ShowAlert?.Invoke();
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
       PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

