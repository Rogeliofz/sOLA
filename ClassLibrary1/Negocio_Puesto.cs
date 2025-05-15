using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;
using ClassLibrary2.ExT;

namespace ClassLibrary1
{
    public class Negocio_Puesto
    {
        Datos_Puesto datos = new Datos_Puesto();

        public List<PuestoExt> ObtenerPuesto() { 
        
        List<PuestoExt> lista = datos.ObtenrPuesto();

            return lista;

        
        }




    }
}
