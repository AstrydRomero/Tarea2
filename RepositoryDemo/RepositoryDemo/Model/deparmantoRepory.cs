using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Exceptions;
using SQLiteNetExtensions.Extensions;
using RepositoryDemo.Services;

namespace RepositoryDemo.Model
{
    public class deparmantoRepory  : IDepartamento
    {
        public string Mensage { get; set; }
        SQLiteConnection conn;

        public deparmantoRepory(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<DepartamentoModel>();
            conn.CreateTable<EmpleadoModel>();
        }

       
        public void AddNewDepartamento(DepartamentoModel newDepartamentro)
        {
            try
            {

                conn.InsertWithChildren(newDepartamentro, recursive: true); 
                Mensage =
                          $"Registro ingresado. Product Id: {newDepartamentro.ID}, Name: {newDepartamentro.NombreDepartamento}";
            }

            catch (Exception ex)
            {

                Mensage = $"Error al guardar registro. Error: {ex.Message}";
            }
        }

        public List<DepartamentoModel> GetDepartamentoModels()
        {
            return conn.Table<DepartamentoModel>().ToList();
        }

        public List<DepartamentoModel> GetDepartamentoWithChildren()
        {
            return conn.GetAllWithChildren<DepartamentoModel>();
        }







       

    }
}

