using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Diagnostics;

namespace Tickets2.Logica
{
    public class Envio
    {

        public bool enviomensaje(String nombre, String ubicacion, String telefono, String descripcion, String email)
        {
            
           bool mensaje;

            Debug.WriteLine("Descripción: " + descripcion);

           


            try
            {
                MailMessage email2 = new MailMessage();
                email2.To.Add(new MailAddress(email));
                email2.From = new MailAddress("solicitudesti@gmail.com");
                email2.Subject = "Solicitud TI";
                email2.Body = "<table width='100%' cellspacing='0' cellpadding='0' border='0' bgcolor='2499CC' >"
                       + "<tr><td align='center' > <b><font face='verdana,arial,helvetica' size='4' color='ffffff'>Solicitud TI</font></b></td>"
                       + "</tr></table> "
                       + "<table width='100%' cellspacing='0' cellpadding='2' border='0'>"
                       + "<tr><td  width='20%'><img src='http://www.techandsolve.com/web/images/logo.png' alt='logo tech' width='150' height='180'></td><td  width='5%'></td><td valign='top'><b><font face='verdana,arial,helvetica' size='3' color='2499CC'>Soy</font>"
                       + "<font face='verdana,arial,helvetica' size='4' color='2499CC'><br>Solver<br></font>" + nombre + "</b>"
                       + "<br><br> <b><font face='verdana,arial,helvetica' size='4' color='2499CC'>DESCRIPCION DE LA SOLICITUD</font>"
                       + "<br><br>" + descripcion + "</b><br><br><br><br>"
                       + "<b><font face='verdana,arial,helvetica' size='4' color='2499CC'>Ubicacion</font>"
                       + "<br>" + ubicacion + "</b><br><br><b><font face='verdana,arial,helvetica' size='4' color='2499CC'>Telefono</font>"
                           + "<br>" + telefono + "</b><b></td></tr></table> ";
                email2.IsBodyHtml = true;
                email2.Priority = MailPriority.Normal;


                //Especificamos el smtp

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("solicitudesti@gmail.com", "solicitudesti123");

                //enviamos

                smtp.Send(email2);
                email2.Dispose();

                mensaje = true;
            }
            catch (Exception ex){
                mensaje = false;
                ex.ToString();
            }

            return mensaje;
        }

    }
}