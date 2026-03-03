using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_P3
{
    internal class GestorTareas
    {

        

        private int capacidad;
        private int contadorTareas;
        private Tarea[] tareas;
        public GestorTareas(int CAPACIDAD)
        {
            this.capacidad = CAPACIDAD;
            tareas = new Tarea[capacidad];
            contadorTareas = 0;
        }

        /// <summary>
        /// Añade una tarea al array si todavía hay capacidad disponible
        /// y no existe otra tarea con el mismo nombre.
        /// </summary>
        /// <param name="t"> tarea que se desea añadir </param>
        /// <returns>
        /// devuelve false si esta lleno el array       
        /// devuelve false si coincide mismo nombre de tarea
        /// devuelve true si se añade la tarea correctamente
        /// </returns>
        public bool anadirTarea(Tarea t)
        {
            if (contadorTareas == this.capacidad)
                return false;
            for (int i = 0; i < contadorTareas; i++)
            {
                if (tareas[i].nombre == t.nombre)
                {
                    return false;
                }
            }
            tareas[contadorTareas] = t;
            contadorTareas++;
            return true;
        }

        /// <summary>
        /// Elimina una tarea si existe en el array
        /// </summary>
        /// <param name="t"> tarea que se desea eliminar</param>
        /// <returns>
        /// devuelve true si se elimina
        /// devuelve false si no se elimina
        /// </returns>

        public bool eliminarTarea(Tarea t)
        {
            for (int i = 0; i < contadorTareas; i++)
            {
                if (tareas[i] == t) 
                {
                    tareas[i] = tareas[contadorTareas - 1];
                    tareas[contadorTareas - 1] = null;
                    contadorTareas--;
                    return true;
                }
            }
            return false;

        }

        /// <summary>
        /// Modifica la variable completado de una tarea si existe dicha tarea en el array
        /// </summary>
        /// <param name="t"> Tarea que vamos a completar</param>
        /// <returns>
        /// devuelve true si existe la tarea en el array
        /// devuelve false si no existe la tarea en array
        /// </returns>
        public bool completarTarea(Tarea t)
        {
            for (int i = 0; i < contadorTareas; i++)
            {
                if (tareas[i] == t) 
                {
                    tareas[i].completado = true; 
                    return true; 
                }
            }
            return false; 
        }

        /// <summary>
        /// Consigo mi array de tareas para usarlo en los botones del Form1.cs
        /// </summary>
        /// <returns>
        /// devuelve mi array de tareas
        /// </returns>
        public Tarea[] getTareas()
        {
            return tareas;
        }

        /// <summary>
        /// consigo el index de mi array, contadorTareas 
        /// </summary>
        /// <returns>
        /// devuelve el int de contadorTareas
        /// </returns>
        public int getContadorTareas()
        {
            return contadorTareas;
        }



    }
}
