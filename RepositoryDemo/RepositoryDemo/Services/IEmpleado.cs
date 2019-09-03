using System;
using System.Collections.Generic;
using System.Text;
using RepositoryDemo.Model;

namespace RepositoryDemo.Services
{
    public interface IEmpleado
    {
         void AddNewEmpleado(EmpleadoModel newEmpleado);
        List<Model.EmpleadoModel> get();
        bool EmpleadoToUpdate(EmpleadoModel EmpleadoToUpdate);
    }
}
