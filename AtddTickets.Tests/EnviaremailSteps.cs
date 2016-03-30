using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace AtddTickets.Tests
{
    [Binding]
    public class EnviaremailSteps
    {
        private static ChromeDriver driverCh;

        [Before()]
        public void Setup()
        {
            driverCh = new ChromeDriver();
        }
       

        [Given(@"el usuario ingresa a index\.xhtml")]
        public void GivenElUsuarioIngresaAIndex_Xhtml()
        {
            driverCh.Navigate().GoToUrl("http://localhost:49686/Enviaremail/Index2");
        }
        
        [When(@"el usuario ingresa el nombre (.*)")]
        public void WhenElUsuarioIngresaElNombre(string nombre)
        {
            driverCh.FindElement(By.Id("nombre")).SendKeys(nombre);
        }
        
        [When(@"se ingresa la ubicacion (.*)")]
        public void WhenSeIngresaLaUbicacion(string ubicacion)
        {
            driverCh.FindElement(By.Id("ubicacion")).SendKeys(ubicacion);
        }
        
        [When(@"se ingresa el telefono (.*)")]
        public void WhenSeIngresaElTelefono(string telefono)
        {
            driverCh.FindElement(By.Id("telefono")).SendKeys(telefono);
        }
        
        [When(@"se ingresa la descripcion (.*)")]
        public void WhenSeIngresaLaDescripcion(string descripcion)
        {
            driverCh.FindElement(By.Id("descripcion")).SendKeys(descripcion);
        }
        
        [When(@"presiona el boton enviar correo")]
        public void WhenPresionaElBotonEnviarCorreo()
        {
            driverCh.FindElement(By.Id("enviar")).Click();
        }
        
        [Then(@"se muestra mensaje de envio")]
        public void ThenSeMuestraMensajeDeEnvio()
        {
            Thread.Sleep(4000);
            string mensaje=driverCh.FindElement(By.Id("men")).Text;

            Assert.AreEqual("¡Bien hecho! Correo enviado Exitosamente", mensaje);

        }

        [After]
        public void Cerrar()
        {
            driverCh.Quit();
        }

    }
}
