using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tickets2.Models;
using Tickets2.Logica;

namespace Tickets2.Tests.Testlogica
{
    [TestClass]
    public class TestEnvio
    {
        
        Solicitud solicitud = new Solicitud();
        Envio envio = new Envio();

        String email;

        [TestInitialize]
        public void init()
        {
            solicitud.Nombre = "Yosimar";
            solicitud.Ubicacion = "En el baño";
            solicitud.Telefono = "3005458538";
            solicitud.Descripcion = "Necesito papel";
            email = "juandavid.valencia@techandsolve.com";
        }

        [TestMethod]
        public void Testenvio()
        {
           // init();
            bool mensaje;

            mensaje = envio.enviomensaje(solicitud.Nombre, solicitud.Ubicacion, solicitud.Telefono, solicitud.Descripcion, email);
            Assert.AreEqual(true, mensaje);
        }

    }
}
