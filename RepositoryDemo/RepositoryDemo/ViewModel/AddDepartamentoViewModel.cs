using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using RepositoryDemo.Model;
using RepositoryDemo.Services;
using Xamarin.Forms;

namespace RepositoryDemo.ViewModel
{
    public class AddDepartamentoViewModel
    {
        IDepartamento Repository;
        public AddDepartamentoViewModel(IDepartamento repository)
        {
            Repository = repository;

            AddEmpleadoCommand = new Command(AddEmpleadoCollection);
            SaveDepartamentoCommand = new Command(SaveNewDepartamento);

            Empleado = new ObservableCollection<EmpleadoModel>();
        }

        private void SaveNewDepartamento()
        {
            DepartamentoModel E = new DepartamentoModel
            {
                NombreDepartamento = NombreDepartamento,
                NombreSupervisor = NombreSupervisor
            };
            E.empleados = new List<EmpleadoModel>(Empleado);

            Repository.AddNewDepartamento(E);
        }

        private void AddEmpleadoCollection()
        {
            Empleado.Add(new EmpleadoModel
            {
                NombreDelEmpleado = NombreDelEmpleado,
              

            });
        }
        
        #region Properties
        public ObservableCollection<EmpleadoModel> Empleado { get; set; }
        public string NombreDepartamento { get; set; }
        public string NombreDelEmpleado { get; set; }

        public string NombreSupervisor { get; set; }
        #endregion


        #region Commands
        public Command AddEmpleadoCommand { get; set; }
        public Command SaveDepartamentoCommand { get; set; }
        #endregion
    


    }
  

}
