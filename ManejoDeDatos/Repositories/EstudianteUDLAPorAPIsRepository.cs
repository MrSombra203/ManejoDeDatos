using ManejoDeDatos.Interfaces;
using ManejoDeDatos.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeDatos.Repositories
{
    public class EstudianteUDLAPorAPIsRepository : IEstuduanteUDLARepository
    {
        private readonly IEnumerable<EstudianteUDLA> estudiantesAPI;
        public string _urlEndpoint = "https://www.freetestapi.com/api/v1/students";
        private object response;

        public bool ActualizarEstudianteUDLA(EstudianteUDLA estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudianteUDLA(EstudianteUDLA estudiante)
        {
            throw new NotImplementedException();
        }

        public EstudianteUDLA DevuelveEstudianteUDLA(int id)
        {
            throw new NotImplementedException();
        }



        public IEnumerable<EstudianteUDLA> DevuelveListadoEstudiantes()
        {
            using (HttpClient httpClient = new HttpClient()) 
            {
                var response = httpClient.GetAsync(_urlEndpoint).Result;
                var json_data = response.Content.ReadAsStringAsync().Result;

                List<EstudianteAPI> estudiantesAPI = JsonConvert.DeserializeObject<List<EstudianteAPI>>(json_data);
            }
            return estudiantesAPI;
        }

        public bool EliminarEstudianteUDLA(int id)
        {
            throw new NotImplementedException();
        }
    }
}
