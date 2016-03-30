using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tickets2.Logica;
using Tickets2.Models;


namespace Tickets2.Controllers
{
    public class EnviaremailController : Controller
    {
      
       
        public ActionResult Index()
        {
            return View("enviaremail");
        }

        public ActionResult Index2()
        {
            return View("enviaremailajax");
        }

        public ActionResult enviaremail(Solicitud solicitud)
        {
            Envio envio = new Envio();
            string email = "juandavid.valencia@techandsolve.com";


            bool mensaje = false;

            mensaje = envio.enviomensaje(solicitud.Nombre, solicitud.Ubicacion, solicitud.Telefono, solicitud.Descripcion, email);



            if (mensaje){

                
            }
            else {
               
            }
           
            return View();
        }

        [HttpPost]
        public int envia(string nombre, string ubicacion, string telefono, string descripcion)
        {
            Envio envio = new Envio();
            string email = "yosimar.valega@techandsolve.com";

            Debug.Write("Entro "+descripcion);

            bool mensaje = false;

            mensaje = envio.enviomensaje(nombre, ubicacion, telefono, descripcion, email);
            if (mensaje){

                return 1;
            }
            else {
                return 0;
            }

            
        }


    }
}