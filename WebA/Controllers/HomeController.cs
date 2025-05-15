using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassLibrary1;
using ClassLibrary2.ExT;
using ClassLibrary2.Model;

namespace WebA.Controllers
{
    public class HomeController : Controller
    {
        Negocio_t negocio = new Negocio_t();
        Negocio_Puesto negociop = new Negocio_Puesto();

        // GET: Home
        public ActionResult Index()
        {
            List<PuestoExt> lista = negociop.ObtenerPuesto();
            //ViewBag.CatalogoPuestos = new SelectList(lista, "Id_Puesto", "Puesto");
            ViewBag.CatalogoPuestos= lista;

            return View("Index");
        }

        public JsonResult Obtener() {

            try
            {
                List<Empleados_ext> lista = negocio.Obtener();

                return Json(new { mensaje = "ok", ls = lista }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { mensaje = ex.Message }, JsonRequestBehavior.AllowGet);
                
            }
                
        
        }

        public JsonResult Agregar(T_EMPLEADOS emp)
        {

            try
            {
                negocio.Agregar(emp);

                return Json(new { mensaje = "ok" });
            }
            catch (Exception ex)
            {

                return Json(new { mensaje = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        
        
        }


        public JsonResult Eliminar(int id)
        {

            try
            {
                negocio.Eliminar(id);

                return Json(new { mensaje = "ok" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(new { mensaje = ex.Message }, JsonRequestBehavior.AllowGet);
                
            }
        
        
        }

        public JsonResult ObtenerporId(int id) {

            try
            {
                Empleados_ext empleado = negocio.ObtenerporId(id);

                return Json(new { mensaje = "ok", objeto = empleado }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(new { mensaje = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        
        
        
        }

        public JsonResult Editar(Empleados_ext emp) {

            try
            {
                negocio.Editar(emp);
                return Json(new { mensaje = "ok" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(new { mensaje = ex.Message }, JsonRequestBehavior.AllowGet);
            }
       
        
        }

    }
}