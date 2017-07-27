using jTableMvc.Entidades;
using jTableMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jTableMvc.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult getClientes()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            try
            {
                List<Clientes> cliente = new List<Clientes>() { 
   
                    new Clientes{Nombre = "Wilmer", Apellido="Ramirez", Cedula="112122", Nacimiento= Convert.ToDateTime("12/12/12")}

                };
                Console.Write(cliente);
                return Json(new { Result = "OK", Records = cliente }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }


  
        public JsonResult Create(Clientes Model)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            try
            {
                db.cliente.Add(Model);
                db.SaveChanges();
                return Json(new { Result = "OK", Records = Model }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }



        public JsonResult Edit(Clientes Model)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            try
            {
                db.Entry(Model).State = EntityState.Modified;
                db.SaveChanges();
                return Json(new { Result = "OK" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

    
        public JsonResult Delete(String ID)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            try
            {
                Clientes marks = db.cliente.Find(ID);
                db.cliente.Remove(marks);
                db.SaveChanges();
                return Json(new { Result = "OK" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
    }
}