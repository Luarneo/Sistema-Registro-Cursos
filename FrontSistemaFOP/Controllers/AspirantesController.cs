using FrontSistemaFOP.Models;
using FrontSistemaFOP.ServiciosAspirante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace FrontSistemaFOP.Controllers
{
    public class AspirantesController : Controller
    {
        // GET: Aspirantes
        public ActionResult Aspirantes()
        {

            ServiciosAspirante.ServicioAgenteClient ServicioAspirantes = new ServiciosAspirante.ServicioAgenteClient();

            var AspirantesSinGrupoServicio = ServicioAspirantes.ListarAspirantesActivos();

            List<AspiranteViewModel> ListaFinalAspirantes = new List<AspiranteViewModel>();

            foreach(var i in  AspirantesSinGrupoServicio)
            {
                string NombreCompleto = i.Nombre + " " + i.ApellidoPaterno + " " + i.ApellidoMaterno;

                AspiranteViewModel Aspirante = new AspiranteViewModel();

                Aspirante.IdAspirante = i.IdAspirante;
                Aspirante.NumeroEmpleado = i.NumeroEmpleado;
                Aspirante.ApellidoPaterno = i.ApellidoPaterno;
                Aspirante.ApellidoMaterno = i.ApellidoMaterno;
                Aspirante.Estatus = i.Estatus;
                Aspirante.Nombre = NombreCompleto;

                ListaFinalAspirantes.Add(Aspirante);

                NombreCompleto = "";
            }

            ServicioAspirantes.Close();
    
            return View(ListaFinalAspirantes);
        }


        public PartialViewResult NuevoAspirante()
        {
                        
            return PartialView("_NuevoAspirante", new AspiranteViewModel());

        }

        // POST: Crear Aspirante
        [HttpPost]
        public JsonResult GuardarNuevoAspirante(AspiranteViewModel NuevoAspirante)
        {
            List<string> Datos = new List<string>();

            try
            {

                ServicioAgenteClient ServicioAspirantes = new ServiciosAspirante.ServicioAgenteClient();

                //if (ModelState.IsValid)
                //{
                    var resultado = ServicioAspirantes.GuardarAspirate(new Aspirante
                    {
                        NumeroEmpleado = NuevoAspirante.NumeroEmpleado,
                        Nombre = NuevoAspirante.Nombre,
                        ApellidoPaterno = NuevoAspirante.ApellidoPaterno,
                        ApellidoMaterno = NuevoAspirante.ApellidoMaterno,
                        Estatus = NuevoAspirante.Estatus
                    });

                    //if (resultado.Value.Contains("Operacion Exitosa"))
                    //{
                    //    Datos.Add("success");
                    //    Datos.Add("La ubicación se guardo correctamente !!!");

                    //}
                    //else
                    //{
                    //    Datos.Add("danger");
                    //    Datos.Add("Error al intentar guardar la ubicación");
                    //}
                    //}
                    //else
                    //{
                    //    Datos.Add("danger");
                    //    Datos.Add("Error: información incompleta");
                    //}

                    return Json(Datos);
                //}
            }
            catch (Exception ex)
            {
                Datos.Add("danger");
                Datos.Add("Error:" + ex.Message);

                return Json(Datos);
            }

        }

        // GET: Aspirantes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Aspirantes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aspirantes/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Aspirantes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Aspirantes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Aspirantes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Aspirantes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
