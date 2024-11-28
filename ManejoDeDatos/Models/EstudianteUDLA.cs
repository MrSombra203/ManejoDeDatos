using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeDatos.Models
{
    public class EstudianteUDLA
    {
        public string ID { get; set; }
        public int Id { get; internal set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }

    }
}
