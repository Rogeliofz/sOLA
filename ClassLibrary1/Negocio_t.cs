using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;
using ClassLibrary2.ExT;
using ClassLibrary2.Model;

namespace ClassLibrary1
{
    public class Negocio_t
    {
        Datos_t datos = new Datos_t();

        public List<Empleados_ext> Obtener()
        { 
       
            List<Empleados_ext> lista = datos.Obtener();

            return lista;

        
        }

        public void Agregar(T_EMPLEADOS emp)
        { 
        
            datos.Agregar(emp);
        
        }

        public void Eliminar(int id) { 
        
        datos.Eliminar(id);
        
        
        }

        public Empleados_ext ObtenerporId(int id) { 
        
        Empleados_ext empleado = datos.obtenerporId(id);
            
        return empleado;
        
        }


        public void Editar(Empleados_ext emp) { 
        
        datos.Editar(emp);
        
        }




    }
}
