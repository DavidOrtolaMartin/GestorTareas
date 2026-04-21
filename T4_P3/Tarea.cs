using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_P3
{
    internal class Tarea
    {

        public string nombre { get; set; }

        /*
         * public string Titulo {
         * get {
         * return titulo;
         * } set {
         * titulo = value 
         * }
         */
        public string descripcion { get; set; }
        public DateTime fecha { get; set; }
        public bool completado { get; set; }
        public bool prioridadAlta { get; set; } 
        public string categoria { get; set; }

        public List<string> Etiquetas { get; set; } = new List<string>(); // Nueva propiedad


        public Tarea(string nombre, string descripcion, DateTime fecha, string categoria, bool prioridadAlta = false)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.fecha = fecha;
            this.completado = false;
            this.categoria = categoria;
            this.prioridadAlta = prioridadAlta;
            

        }
        public override string ToString()
        {
            return nombre + " - " + fecha.ToShortDateString() + 
                   (completado ? " (Completado)" : " (Por hacer)") +
                   (string.IsNullOrWhiteSpace(categoria) ? "" : " (" + categoria + ")") +
                   (prioridadAlta ? "(Prioritaria)" : "");
        }
    }
}


