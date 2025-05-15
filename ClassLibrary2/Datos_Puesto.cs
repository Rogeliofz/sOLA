using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2.ExT;
using ClassLibrary2.Model;

namespace ClassLibrary2
{
    public class Datos_Puesto
    {

        PracticasEntities BaseDatos = new PracticasEntities();


        public List<PuestoExt> ObtenrPuesto() { 
        
        List<PuestoExt> lista1 = new List<PuestoExt>();

            List<sp_ObtenerPuesto_Result> lista= BaseDatos.sp_ObtenerPuesto().ToList();

            foreach (sp_ObtenerPuesto_Result obj in lista) { 
            
            PuestoExt p = new PuestoExt();

                p.Id_Puesto = obj.Id_Puesto;
                p.Puesto = obj.Puesto;

                lista1.Add(p);
            
            }

            return lista1;
        
        
        }





    }
}
