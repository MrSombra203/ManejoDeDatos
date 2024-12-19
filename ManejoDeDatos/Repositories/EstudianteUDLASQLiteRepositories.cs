using ManejoDeDatos.Interfaces;
using ManejoDeDatos.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ManejoDeDatos.Repositories
{
    public class EstudianteUDLASQLiteRepositories : IEstuduanteUDLARepository
    {
        private static string NombreBD = "EstudianteUDLA.db3";
        private SQLiteConnection _connection;


        public EstudianteUDLASQLiteRepositories()
        {
            Init();
        }
        public void Init()
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, NombreBD);
            _connection = new SQLiteConnection(dbPath);
            _connection.CreateTable<EstudianteUDLA>();
        }

        public bool ActualizarEstudianteUDLA(EstudianteUDLA estudiante)
        {
            try
            {
                int insert = _connection.Update(estudiante);
                if (insert > 0)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                throw;
            }
        }

        public bool CrearEstudianteUDLA(EstudianteUDLA estudiante)
        {
            try
            {
                int insert = _connection.Insert(estudiante);
                if (insert > 0)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                throw;
            }
        }

        public EstudianteUDLA DevuelveEstudianteUDLA(int id)
        {
            try
            {
                return _connection.Get<EstudianteUDLA>(id);
            }
            catch (Exception e)
            {
                return new EstudianteUDLA();
            }

        }

        public IEnumerable<EstudianteUDLA> DevuelveListadoEstudiantes()
        {
            var listadoEstudiantes = _connection.Table<EstudianteUDLA>().ToList();
            return listadoEstudiantes;
        }

        public bool EliminarEstudianteUDLA(int id)
        {
            int eliminar = _connection.Delete<EstudianteUDLA>(id);
            if (eliminar > 0)
            {
                return true;
            }
            return false;   
        }
    }
}
