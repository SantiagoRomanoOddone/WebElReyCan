using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebElReyCan.Data;
using WebElReyCan.Models;

namespace WebElReyCan.Controllers
{
    public class MascotaController : Controller
    {
        private MascotaDbContext context = new MascotaDbContext();
        public ActionResult Index()
        {
            var mascotas = context.Mascotas.ToList();
            return View("Index", mascotas);
        }
        //public ActionResult Index()
        //{
        //    string hoy = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
        //    var turnos = (from t in context.Mascotas
        //                  where Convert.ToString(t.Fecha) == hoy
        //                  select t).ToList();

        //    return View("Index", turnos);
        //}

        public ActionResult Create()
        {
            Mascota mascota = new Mascota();
            return View("Create", mascota);
        }
        [HttpPost]
        public ActionResult Create(Mascota mascota)
        {
            if (ModelState.IsValid)
            {
                context.Mascotas.Add(mascota);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("create", mascota);
        }
        public ActionResult Delete(int id)
        {
            Mascota mascota = context.Mascotas.Find(id);
            if (mascota != null)
            {
                return View("Delete", mascota);
            }
            else
            {
                return HttpNotFound();
            }
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Mascota mascota = context.Mascotas.Find(id);

            context.Mascotas.Remove(mascota);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            Mascota mascota = context.Mascotas.Find(id);

            if (mascota != null)
            {
                return View("Edit", mascota);
            }
            else
            {
                return HttpNotFound();
            }
        }
        [HttpPost]
        [ActionName("Edit")]
        public ActionResult EditConfirmed(Mascota mascota)
        {
            if (ModelState.IsValid)
            {
                context.Entry(mascota).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Edit", mascota);
        }
        public ActionResult SearchByName(string nombreMascota)
        {
            if (nombreMascota == null)
            {
                return RedirectToAction("Index");
            }
            List<Mascota> mascotas = (
                from o in context.Mascotas
                where o.NombreMascota == nombreMascota
                select o).ToList();
            return View("Index", nombreMascota);
        }
    }
}