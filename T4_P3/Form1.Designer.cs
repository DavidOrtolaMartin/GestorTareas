namespace T4_P3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }






        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxNombre = new TextBox();
            textBoxDescrip = new TextBox();
            fecha = new DateTimePicker();
            listBoxTareas = new ListBox();
            buttonAgregar = new Button();
            buttonEliminar = new Button();
            buttonCompletar = new Button();
            labelNombre = new Label();
            labelDescripcion = new Label();
            labelFecha = new Label();
            textBoxSoloDescrip = new TextBox();
            chkAltaPrioridad = new CheckBox();
            labelPrioridad = new Label();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(169, 41);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(108, 27);
            textBoxNombre.TabIndex = 0;
            // 
            // textBoxDescrip
            // 
            textBoxDescrip.Location = new Point(169, 87);
            textBoxDescrip.Name = "textBoxDescrip";
            textBoxDescrip.Size = new Size(286, 27);
            textBoxDescrip.TabIndex = 1;
            // 
            // fecha
            // 
            fecha.Location = new Point(169, 131);
            fecha.Name = "fecha";
            fecha.Size = new Size(250, 27);
            fecha.TabIndex = 2;
            // 
            // listBoxTareas
            // 
            listBoxTareas.FormattingEnabled = true;
            listBoxTareas.Location = new Point(80, 253);
            listBoxTareas.Name = "listBoxTareas";
            listBoxTareas.Size = new Size(339, 124);
            listBoxTareas.TabIndex = 4;
            listBoxTareas.SelectedIndexChanged += listBoxTareas_SelectedIndexChanged;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(169, 218);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(132, 29);
            buttonAgregar.TabIndex = 3;
            buttonAgregar.Text = "Añadir tarea";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(490, 253);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(132, 29);
            buttonEliminar.TabIndex = 6;
            buttonEliminar.Text = "Eliminar tarea";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonCompletar
            // 
            buttonCompletar.Location = new Point(490, 313);
            buttonCompletar.Name = "buttonCompletar";
            buttonCompletar.Size = new Size(215, 29);
            buttonCompletar.TabIndex = 7;
            buttonCompletar.Text = "Marcar como completada";
            buttonCompletar.UseVisualStyleBackColor = true;
            buttonCompletar.Click += buttonCompletar_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(73, 48);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(67, 20);
            labelNombre.TabIndex = 7;
            labelNombre.Text = "Nombre:";
            labelNombre.Click += label1_Click;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Location = new Point(73, 90);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(90, 20);
            labelDescripcion.TabIndex = 8;
            labelDescripcion.Text = "Descripción:";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Location = new Point(73, 131);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(50, 20);
            labelFecha.TabIndex = 9;
            labelFecha.Text = "Fecha:";
            labelFecha.Click += label3_Click;
            // 
            // textBoxSoloDescrip
            // 
            textBoxSoloDescrip.AccessibleName = "BoxDescrip";
            textBoxSoloDescrip.Location = new Point(80, 397);
            textBoxSoloDescrip.Multiline = true;
            textBoxSoloDescrip.Name = "textBoxSoloDescrip";
            textBoxSoloDescrip.Size = new Size(339, 52);
            textBoxSoloDescrip.TabIndex = 5;
            // 
            // chkAltaPrioridad
            // 
            chkAltaPrioridad.AutoSize = true;
            chkAltaPrioridad.Location = new Point(169, 176);
            chkAltaPrioridad.Name = "chkAltaPrioridad";
            chkAltaPrioridad.Size = new Size(124, 24);
            chkAltaPrioridad.TabIndex = 10;
            chkAltaPrioridad.Text = "Alta prioridad";
            chkAltaPrioridad.UseVisualStyleBackColor = true;
            // 
            // labelPrioridad
            // 
            labelPrioridad.AutoSize = true;
            labelPrioridad.Location = new Point(73, 176);
            labelPrioridad.Name = "labelPrioridad";
            labelPrioridad.Size = new Size(73, 20);
            labelPrioridad.TabIndex = 11;
            labelPrioridad.Text = "Prioridad:";
            labelPrioridad.Click += label1_Click_1;
            // 
            // Form1
            // 
            AccessibleName = "BoxDescrip";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(890, 478);
            Controls.Add(labelPrioridad);
            Controls.Add(chkAltaPrioridad);
            Controls.Add(textBoxSoloDescrip);
            Controls.Add(labelFecha);
            Controls.Add(labelDescripcion);
            Controls.Add(labelNombre);
            Controls.Add(buttonCompletar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonAgregar);
            Controls.Add(listBoxTareas);
            Controls.Add(fecha);
            Controls.Add(textBoxDescrip);
            Controls.Add(textBoxNombre);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombre;
        private TextBox textBoxDescrip;
        private DateTimePicker fecha;
        private ListBox listBoxTareas;
        private Button buttonAgregar;
        private Button buttonEliminar;
        private Button buttonCompletar;
        private Label labelNombre;
        private Label labelDescripcion;
        private Label labelFecha;
        private TextBox textBoxSoloDescrip;
        private CheckBox chkAltaPrioridad;
        private Label labelPrioridad;
    }
}
