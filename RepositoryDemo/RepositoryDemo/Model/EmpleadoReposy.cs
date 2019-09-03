using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using RepositoryDemo.Services;

namespace RepositoryDemo.Model
{
   public  class EmpleadoReposy : IEmpleado
    {
        public string Mensage { get; set; }
        SQLiteConnection conn;
        public EmpleadoReposy(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<EmpleadoModel>();
        }
        public void AddNewEmpleado(EmpleadoModel newEmpleado)
        {
            try
            {

                conn.Insert(newEmpleado); //
                Mensage =
                    $"Registro ingresado. Empleado: {newEmpleado.ID}, Name: {newEmpleado.ID}";
            }

            catch (Exception ex)
            {

                Mensage = $"Error al guardar registro. Error: {ex.Message}";
            }

        }

        public List<EmpleadoModel> Get()
        {
            return conn.Table<EmpleadoModel>().ToList();
        }

        public bool EmpleadoToUpdate(EmpleadoModel EmpleadoToUpdate)
        {
            return conn.Update(EmpleadoToUpdate) > 1;
        }

        public List<EmpleadoModel> get()
        {
            throw new NotImplementedException();
        }
    }
}
