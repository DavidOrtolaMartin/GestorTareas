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
            cmbCategoria = new ComboBox();
            labelCategoria = new Label();
            lblContadorTareas = new Label();
            labelNumTareas = new Label();
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
            listBoxTareas.Location = new Point(504, 87);
            listBoxTareas.Name = "listBoxTareas";
            listBoxTareas.Size = new Size(374, 184);
            listBoxTareas.TabIndex = 4;
            listBoxTareas.SelectedIndexChanged += listBoxTareas_SelectedIndexChanged;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(169, 276);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(132, 29);
            buttonAgregar.TabIndex = 3;
            buttonAgregar.Text = "Añadir tarea";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(169, 332);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(132, 29);
            buttonEliminar.TabIndex = 6;
            buttonEliminar.Text = "Eliminar tarea";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonCompletar
            // 
            buttonCompletar.Location = new Point(169, 391);
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
            textBoxSoloDescrip.Location = new Point(504, 314);
            textBoxSoloDescrip.Multiline = true;
            textBoxSoloDescrip.Name = "textBoxSoloDescrip";
            textBoxSoloDescrip.Size = new Size(374, 120);
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
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Trabajo", "Personal", "Estudios" });
            cmbCategoria.Location = new Point(169, 218);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(151, 28);
            cmbCategoria.TabIndex = 12;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(73, 226);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(77, 20);
            labelCategoria.TabIndex = 13;
            labelCategoria.Text = "Categoria:";
            // 
            // lblContadorTareas
            // 
            lblContadorTareas.AutoSize = true;
            lblContadorTareas.Location = new Point(571, 44);
            lblContadorTareas.Name = "lblContadorTareas";
            lblContadorTareas.Size = new Size(17, 20);
            lblContadorTareas.TabIndex = 14;
            lblContadorTareas.Text = "0";
            // 
            // labelNumTareas
            // 
            labelNumTareas.AutoSize = true;
            labelNumTareas.Location = new Point(504, 44);
            labelNumTareas.Name = "labelNumTareas";
            labelNumTareas.Size = new Size(70, 20);
            labelNumTareas.TabIndex = 15;
            labelNumTareas.Text = "NºTareas:";
            // 
            // Form1
            // 
            AccessibleName = "BoxDescrip";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(890, 510);
            Controls.Add(labelNumTareas);
            Controls.Add(lblContadorTareas);
            Controls.Add(labelCategoria);
            Controls.Add(cmbCategoria);
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
        private ComboBox cmbCategoria;
        private Label labelCategoria;
        private Label lblContadorTareas;
        private Label labelNumTareas;
    }
}
