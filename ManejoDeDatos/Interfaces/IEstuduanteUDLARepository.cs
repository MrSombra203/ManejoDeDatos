using ManejoDeDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeDatos.Interfaces
{
    public interface IEstuduanteUDLARepository
    {
        IEnumerable<EstudianteUDLA> DevuelveListadoEstudiantes();
        EstudianteUDLA DevuelveEstudianteUDLA(int id);
        bool CrearEstudianteUDLA(EstudianteUDLA estudiante);
        bool ActualizarEstudianteUDLA(EstudianteUDLA estudiante);
        bool EliminarEstudianteUDLA(int id);
    }
}
