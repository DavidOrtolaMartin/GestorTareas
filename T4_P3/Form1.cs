namespace T4_P3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GestorTareas gestor = new GestorTareas(100);

        /// <summary>
        /// Agrego una Tarea con los valores del formulario. Si puedo añadir la tarea al array entonces
        /// limpio mi listBox actual y lo vuelvo a rellenar con el nuevo array. 
        /// Si  añadirTarea es false entonces enseño un mensaje 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Tarea t = new Tarea(textBoxNombre.Text, textBoxDescrip.Text, fecha.Value, chkAltaPrioridad.Checked);
            
            if (gestor.anadirTarea(t))
            {

                listBoxTareas.Items.Clear();
                for (int i = 0; i < gestor.getContadorTareas(); i++)
                {
                    listBoxTareas.Items.Add(gestor.getTareas()[i]);
                }
            }
            else
            {
                MessageBox.Show("No se pudo añadir la tarea (ya existe o capacidad llena).");
            }
            /*
             * string titulo = textBox_titulo.Text;
             * string descripcion = textBox_descripcion.Text;
             * Datetime fecha = dateTimePicker_fechaTarea.Value;
             * 
             * Tarea t = new Tarea(titulo, descripcion, false, fecha)
             * 
             */
        }

        /// <summary>
        /// Si elijo una tarea del listBox y la puedo eliminar, entonces limpio el listBox y 
        /// lo relleno con el nuevo array de tareas. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            if (listBoxTareas.SelectedItem != null)
            {
                Tarea t = (Tarea)listBoxTareas.SelectedItem;
                gestor.eliminarTarea(t);


                listBoxTareas.Items.Clear();
                for (int i = 0; i < gestor.getContadorTareas(); i++)
                {
                    listBoxTareas.Items.Add(gestor.getTareas()[i]);
                }
            }


        }

        /// <summary>
        /// Selecciono una tarea(es un texto del ToString() del listBox, la casteo a Tarea 
        /// y la completo, limpio el listBox y vuelvo a añadir el array modificado 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCompletar_Click(object sender, EventArgs e)
        {

            if (listBoxTareas.SelectedItem != null)
            {
                Tarea t = (Tarea)listBoxTareas.SelectedItem;


                gestor.completarTarea(t);


                listBoxTareas.Items.Clear();
                for (int i = 0; i < gestor.getContadorTareas(); i++)
                {
                    listBoxTareas.Items.Add(gestor.getTareas()[i]);
                }
            }





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Selecciono una tarea(es un object del listBox, la casteo a Tarea 
        /// y me aparece la descripcion en el textBox que yo le diga. Esto es porque es el 
        /// selectedIndexChanged del listBox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTareas.SelectedItem != null)
            {
                Tarea tarea = (Tarea)listBoxTareas.SelectedItem;
                textBoxSoloDescrip.Text = tarea.descripcion;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
