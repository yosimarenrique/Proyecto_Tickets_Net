using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Tickets2.Models
{
    public class Solicitud
    {
        private string nombre;
        private string ubicacion;
        private string telefono;
        private string descripcion;

       /* [StringLength(5, ErrorMessage = "Maximo 5 caracteres")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string tipo { get; set; }*/


        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Ubicacion
        {
            get
            {
                return ubicacion;
            }

            set
            {
                ubicacion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }
    }
}