using System;
using System.Collections.Generic;
using System.Text;
using RepositoryDemo.Model;
using RepositoryDemo.Services;
using Xamarin.Forms;

namespace RepositoryDemo.ViewModel
{
    public class ListaDepartamentoViewModel
    {
        private readonly IDepartamento repository;


        public ListaDepartamentoViewModel(IDepartamento repository)
        {
            this.repository = repository;
            Departamento = new List<DepartamentoModel>
                (((deparmantoRepory)repository).GetDepartamentoWithChildren());

            ShowEmpleadoOfDepartaSelectedCommand = new Command(ShowEmpleado);

        }

        private void ShowEmpleado()
        {
            Empleado.Clear();

            Empleado = new List<EmpleadoModel>(SelectedDepartamento.empleados);
        }
        #region Properties
        public List<DepartamentoModel> Departamento { get; set; }
        public DepartamentoModel SelectedDepartamento { get; set; }
        public List<EmpleadoModel> Empleado { get; set; }
        #endregion

        #region Commands
        public Command ShowEmpleadoOfDepartaSelectedCommand { get; set; }
       
        #endregion
    }


}



