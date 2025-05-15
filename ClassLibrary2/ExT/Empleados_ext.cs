using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2.Model;

namespace ClassLibrary2.ExT
{
    public class Empleados_ext
    {

        public int Id_NumEmp { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Id_Puesto { get; set; }

        public PuestoExt PuestoEXT { get; set; }


    }
}
