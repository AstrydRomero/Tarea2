using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Extensions;
using SQLiteNetExtensions.Attributes;

namespace RepositoryDemo.Model
{ [Table("Departamento")]
    public class DepartamentoModel
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }

          [MaxLength(100),Unique]
        public string NombreDepartamento { get; set; }
        public string NombreSupervisor { get; set; }

        [ManyToOne(CascadeOperations  = CascadeOperation.CascadeInsert)]
        public List<EmpleadoModel>empleados { get; set; }
    }
}
