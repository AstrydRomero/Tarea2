using System;
using System.Collections.Generic;
using System.Text;
using RepositoryDemo.Model;

namespace RepositoryDemo.Services
{
     public  interface IDepartamento
    {
        void AddNewDepartamento(DepartamentoModel newDepartamentro);

        List<DepartamentoModel> GetDepartamentoModels();
    }
}
