using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
using SQLiteNetExtensions.Extensions;

namespace RepositoryDemo.Model
{
    [Table("Empleado")]
    public class EmpleadoModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(100), Unique]
        public string NombreDelEmpleado { get; set; }
        public string CargoDelEmpleado { get; set; }



        public int UnitsInStock { get; set; }

        [ForeignKey(typeof(DepartamentoModel))]
        public int Departamento { get; set; }

        [ManyToOne]
        public DepartamentoModel departamentoModel { get; set; }

    }
}

