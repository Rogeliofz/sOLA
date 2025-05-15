using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2.ExT;
using ClassLibrary2.Model;

namespace ClassLibrary2
{
    public class Datos_t
    {

        PracticasEntities BaseDatos = new PracticasEntities();

        public List<Empleados_ext> Obtener()
        { 
        
            List<sp_Obtener_Result> lista = new List<sp_Obtener_Result>();

            List<Empleados_ext> lista1 = new List<Empleados_ext>();

            lista = BaseDatos.sp_Obtener().ToList();

            foreach (sp_Obtener_Result obj in lista) { 
            
                Empleados_ext e = new Empleados_ext();
                PuestoExt p = new PuestoExt();

                e.Id_NumEmp = obj.Id_NumEmp;
                e.Nombre = obj.Nombre;
                e.Apellidos = obj.Apellidos; 
                e.Id_Puesto = obj.Id_Puesto;

                p.Id_Puesto = obj.Id_Puesto;
                p.Puesto = obj.Puesto;

                e.PuestoEXT = p;

                lista1.Add(e);
                  
            }

            return lista1;
        
        
        }


        public void Agregar(T_EMPLEADOS emp)
        {

            BaseDatos.sp_Agregar(emp.Nombre, emp.Apellidos, emp.Id_Puesto);
            BaseDatos.SaveChanges();
            BaseDatos.Dispose();
                    
        }

        public void Eliminar(int id) { 
        
        BaseDatos.Eliminar(id);
            BaseDatos.SaveChanges();
            BaseDatos.Dispose();
        
        }


        public Empleados_ext obtenerporId(int id) {

            ObtenerporId_Result Empleado = BaseDatos.ObtenerporId(id).FirstOrDefault();

            Empleados_ext e = new Empleados_ext();
            PuestoExt p = new PuestoExt();

            e.Id_NumEmp = Empleado.Id_NumEmp;
            e.Nombre = Empleado.Nombre;
            e.Apellidos = Empleado.Apellidos;
            e.Id_Puesto = Empleado.Id_Puesto;

            p.Id_Puesto = Empleado.Id_Puesto;
            p.Puesto = Empleado.Puesto;

            e.PuestoEXT = p;

            return e;
        
        }

        public void Editar(Empleados_ext emp) { 
        
            BaseDatos.sp_Editar(emp.Id_NumEmp, emp.Nombre, emp.Apellidos, emp.Id_Puesto);
            BaseDatos.Dispose();
                
        }









    }
}
