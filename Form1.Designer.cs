namespace Hospital
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
            label1 = new Label();
            btn_Salir = new Button();
            btn_Limpiar = new Button();
            btn_Distribuir = new Button();
            txt_Laboratorio = new TextBox();
            txt_Emergencias = new TextBox();
            txt_Imagenes = new TextBox();
            txt_Administracion = new TextBox();
            txt_Suministros = new TextBox();
            txt_Cirugia = new TextBox();
            txt_Presupuesto = new TextBox();
            Laboratorio = new Label();
            Imagenes = new Label();
            Administracion = new Label();
            Suministros = new Label();
            Cirugia = new Label();
            Emergencias = new Label();
            Presupuesto = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(761, 31);
            label1.TabIndex = 37;
            label1.Text = "DISTRIBUCION DEL PRESUPUESTO DEL HOSPITAL";
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = SystemColors.HighlightText;
            btn_Salir.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            btn_Salir.Location = new Point(311, 287);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(129, 40);
            btn_Salir.TabIndex = 36;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor = SystemColors.HighlightText;
            btn_Limpiar.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            btn_Limpiar.Location = new Point(311, 222);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(129, 39);
            btn_Limpiar.TabIndex = 35;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = false;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Distribuir
            // 
            btn_Distribuir.BackColor = SystemColors.HighlightText;
            btn_Distribuir.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            btn_Distribuir.Location = new Point(311, 168);
            btn_Distribuir.Name = "btn_Distribuir";
            btn_Distribuir.Size = new Size(129, 34);
            btn_Distribuir.TabIndex = 34;
            btn_Distribuir.Text = "Distribuir";
            btn_Distribuir.UseVisualStyleBackColor = false;
            btn_Distribuir.Click += btn_Distribuir_Click;
            // 
            // txt_Laboratorio
            // 
            txt_Laboratorio.Location = new Point(168, 292);
            txt_Laboratorio.Name = "txt_Laboratorio";
            txt_Laboratorio.Size = new Size(103, 23);
            txt_Laboratorio.TabIndex = 33;
            // 
            // txt_Emergencias
            // 
            txt_Emergencias.Location = new Point(168, 117);
            txt_Emergencias.Name = "txt_Emergencias";
            txt_Emergencias.Size = new Size(103, 23);
            txt_Emergencias.TabIndex = 32;
            // 
            // txt_Imagenes
            // 
            txt_Imagenes.Location = new Point(168, 333);
            txt_Imagenes.Name = "txt_Imagenes";
            txt_Imagenes.Size = new Size(103, 23);
            txt_Imagenes.TabIndex = 31;
            // 
            // txt_Administracion
            // 
            txt_Administracion.Location = new Point(168, 254);
            txt_Administracion.Name = "txt_Administracion";
            txt_Administracion.Size = new Size(103, 23);
            txt_Administracion.TabIndex = 30;
            // 
            // txt_Suministros
            // 
            txt_Suministros.Location = new Point(168, 211);
            txt_Suministros.Name = "txt_Suministros";
            txt_Suministros.Size = new Size(103, 23);
            txt_Suministros.TabIndex = 29;
            // 
            // txt_Cirugia
            // 
            txt_Cirugia.Location = new Point(168, 168);
            txt_Cirugia.Name = "txt_Cirugia";
            txt_Cirugia.Size = new Size(103, 23);
            txt_Cirugia.TabIndex = 28;
            // 
            // txt_Presupuesto
            // 
            txt_Presupuesto.Location = new Point(296, 112);
            txt_Presupuesto.Name = "txt_Presupuesto";
            txt_Presupuesto.Size = new Size(122, 23);
            txt_Presupuesto.TabIndex = 27;
            // 
            // Laboratorio
            // 
            Laboratorio.AutoSize = true;
            Laboratorio.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            Laboratorio.Location = new Point(49, 291);
            Laboratorio.Name = "Laboratorio";
            Laboratorio.Size = new Size(95, 21);
            Laboratorio.TabIndex = 26;
            Laboratorio.Text = "Laboratorio";
            // 
            // Imagenes
            // 
            Imagenes.AutoSize = true;
            Imagenes.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            Imagenes.Location = new Point(49, 332);
            Imagenes.Name = "Imagenes";
            Imagenes.Size = new Size(80, 21);
            Imagenes.TabIndex = 25;
            Imagenes.Text = "Imagenes";
            // 
            // Administracion
            // 
            Administracion.AutoSize = true;
            Administracion.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            Administracion.Location = new Point(49, 253);
            Administracion.Name = "Administracion";
            Administracion.Size = new Size(123, 21);
            Administracion.TabIndex = 24;
            Administracion.Text = "Administracion";
            // 
            // Suministros
            // 
            Suministros.AutoSize = true;
            Suministros.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            Suministros.Location = new Point(49, 210);
            Suministros.Name = "Suministros";
            Suministros.Size = new Size(98, 21);
            Suministros.TabIndex = 23;
            Suministros.Text = "Suministros";
            // 
            // Cirugia
            // 
            Cirugia.AutoSize = true;
            Cirugia.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            Cirugia.Location = new Point(49, 167);
            Cirugia.Name = "Cirugia";
            Cirugia.Size = new Size(65, 21);
            Cirugia.TabIndex = 22;
            Cirugia.Text = "Cirugia";
            // 
            // Emergencias
            // 
            Emergencias.AutoSize = true;
            Emergencias.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            Emergencias.Location = new Point(49, 116);
            Emergencias.Name = "Emergencias";
            Emergencias.Size = new Size(102, 21);
            Emergencias.TabIndex = 21;
            Emergencias.Text = "Emergencias";
            // 
            // Presupuesto
            // 
            Presupuesto.AutoSize = true;
            Presupuesto.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            Presupuesto.Location = new Point(296, 76);
            Presupuesto.Name = "Presupuesto";
            Presupuesto.Size = new Size(100, 21);
            Presupuesto.TabIndex = 19;
            Presupuesto.Text = "Presupuesto";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.area_de_hospitales;
            pictureBox1.Location = new Point(446, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 333);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Distribuir);
            Controls.Add(txt_Laboratorio);
            Controls.Add(txt_Emergencias);
            Controls.Add(txt_Imagenes);
            Controls.Add(txt_Administracion);
            Controls.Add(txt_Suministros);
            Controls.Add(txt_Cirugia);
            Controls.Add(txt_Presupuesto);
            Controls.Add(Laboratorio);
            Controls.Add(Imagenes);
            Controls.Add(Administracion);
            Controls.Add(Suministros);
            Controls.Add(Cirugia);
            Controls.Add(Emergencias);
            Controls.Add(Presupuesto);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Salir;
        private Button btn_Limpiar;
        private Button btn_Distribuir;
        private TextBox txt_Laboratorio;
        private TextBox txt_Emergencias;
        private TextBox txt_Imagenes;
        private TextBox txt_Administracion;
        private TextBox txt_Suministros;
        private TextBox txt_Cirugia;
        private TextBox txt_Presupuesto;
        private Label Laboratorio;
        private Label Imagenes;
        private Label Administracion;
        private Label Suministros;
        private Label Cirugia;
        private Label Emergencias;
        private Label Presupuesto;
        private PictureBox pictureBox1;
    }
}
