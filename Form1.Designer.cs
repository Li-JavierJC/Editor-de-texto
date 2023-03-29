namespace Aplicacion_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Caja = new System.Windows.Forms.ToolStrip();
            this.b_nuevo_archivo = new System.Windows.Forms.ToolStripButton();
            this.B_abrir_archivo = new System.Windows.Forms.ToolStripButton();
            this.B_guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Cursiva = new System.Windows.Forms.ToolStripButton();
            this.Subrayar = new System.Windows.Forms.ToolStripButton();
            this.Fuente_1 = new System.Windows.Forms.ToolStripButton();
            this.Color = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.guardar_boton = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reahacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Fuente = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Contenedor_txt = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.combox_tamf = new System.Windows.Forms.ComboBox();
            this.cb_fuente = new System.Windows.Forms.ComboBox();
            this.Caja.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Caja
            // 
            this.Caja.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.b_nuevo_archivo,
            this.B_abrir_archivo,
            this.B_guardar,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton8,
            this.toolStripButton7,
            this.toolStripButton1,
            this.Cursiva,
            this.Subrayar,
            this.Fuente_1,
            this.Color});
            this.Caja.Location = new System.Drawing.Point(0, 24);
            this.Caja.Name = "Caja";
            this.Caja.Size = new System.Drawing.Size(528, 25);
            this.Caja.TabIndex = 0;
            this.Caja.Text = "toolStrip1";
            // 
            // b_nuevo_archivo
            // 
            this.b_nuevo_archivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.b_nuevo_archivo.Image = ((System.Drawing.Image)(resources.GetObject("b_nuevo_archivo.Image")));
            this.b_nuevo_archivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_nuevo_archivo.Name = "b_nuevo_archivo";
            this.b_nuevo_archivo.Size = new System.Drawing.Size(23, 22);
            this.b_nuevo_archivo.Text = "Nuevo archivo";
            this.b_nuevo_archivo.Click += new System.EventHandler(this.b_nuevo_archivo_Click);
            // 
            // B_abrir_archivo
            // 
            this.B_abrir_archivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.B_abrir_archivo.Image = ((System.Drawing.Image)(resources.GetObject("B_abrir_archivo.Image")));
            this.B_abrir_archivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_abrir_archivo.Name = "B_abrir_archivo";
            this.B_abrir_archivo.Size = new System.Drawing.Size(23, 22);
            this.B_abrir_archivo.Text = "Abrir archivo";
            this.B_abrir_archivo.Click += new System.EventHandler(this.abrir_Click);
            // 
            // B_guardar
            // 
            this.B_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.B_guardar.Image = ((System.Drawing.Image)(resources.GetObject("B_guardar.Image")));
            this.B_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_guardar.Name = "B_guardar";
            this.B_guardar.Size = new System.Drawing.Size(23, 22);
            this.B_guardar.Text = "Guardar archivo";
            this.B_guardar.Click += new System.EventHandler(this.B_guardar_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Guardar como";
            this.toolStripButton3.Click += new System.EventHandler(this.guardar_boton_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Copiar";
            this.toolStripButton4.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Pegar";
            this.toolStripButton5.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Cortar";
            this.toolStripButton6.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Deshacer";
            this.toolStripButton8.Click += new System.EventHandler(this.deshacerToolStripMenuItem_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Reahacer";
            this.toolStripButton7.Click += new System.EventHandler(this.reahacerToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Negrita";
            this.toolStripButton1.Click += new System.EventHandler(this.b_negrita_Click);
            // 
            // Cursiva
            // 
            this.Cursiva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Cursiva.Image = ((System.Drawing.Image)(resources.GetObject("Cursiva.Image")));
            this.Cursiva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cursiva.Name = "Cursiva";
            this.Cursiva.Size = new System.Drawing.Size(23, 22);
            this.Cursiva.Text = "Cursiva";
            this.Cursiva.Click += new System.EventHandler(this.Cursiva_Click);
            // 
            // Subrayar
            // 
            this.Subrayar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Subrayar.Image = ((System.Drawing.Image)(resources.GetObject("Subrayar.Image")));
            this.Subrayar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Subrayar.Name = "Subrayar";
            this.Subrayar.Size = new System.Drawing.Size(23, 22);
            this.Subrayar.Text = "Subrayar";
            this.Subrayar.Click += new System.EventHandler(this.Subrayar_Click);
            // 
            // Fuente_1
            // 
            this.Fuente_1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Fuente_1.Image = ((System.Drawing.Image)(resources.GetObject("Fuente_1.Image")));
            this.Fuente_1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Fuente_1.Name = "Fuente_1";
            this.Fuente_1.Size = new System.Drawing.Size(23, 22);
            this.Fuente_1.Text = "Fuente";
            this.Fuente_1.Click += new System.EventHandler(this.Fuente_Click);
            // 
            // Color
            // 
            this.Color.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Color.Image = ((System.Drawing.Image)(resources.GetObject("Color.Image")));
            this.Color.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(23, 22);
            this.Color.Text = "Color";
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.edicionToolStripMenuItem,
            this.formatoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(528, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrir,
            this.guardar_boton,
            this.guardarComoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = global::Aplicacion_1.Properties.Resources.nuevo_archivo2;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.b_nuevo_archivo_Click);
            // 
            // abrir
            // 
            this.abrir.Image = global::Aplicacion_1.Properties.Resources.abrir_archivo;
            this.abrir.Name = "abrir";
            this.abrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrir.Size = new System.Drawing.Size(193, 22);
            this.abrir.Text = "Abrir";
            this.abrir.Click += new System.EventHandler(this.abrir_Click);
            // 
            // guardar_boton
            // 
            this.guardar_boton.Image = global::Aplicacion_1.Properties.Resources.guradar1;
            this.guardar_boton.Name = "guardar_boton";
            this.guardar_boton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.guardar_boton.Size = new System.Drawing.Size(193, 22);
            this.guardar_boton.Text = "Guardar";
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Image = global::Aplicacion_1.Properties.Resources.grudar1;
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como ";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardar_boton_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::Aplicacion_1.Properties.Resources.x_eliminar;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.cortarToolStripMenuItem,
            this.deshacerToolStripMenuItem,
            this.reahacerToolStripMenuItem});
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.edicionToolStripMenuItem.Text = "Edicion";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Image = global::Aplicacion_1.Properties.Resources.copy;
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Image = global::Aplicacion_1.Properties.Resources.paste;
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pegarToolStripMenuItem.Text = "Pegar";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Image = global::Aplicacion_1.Properties.Resources.Cut;
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cortarToolStripMenuItem.Text = "Cortar";
            this.cortarToolStripMenuItem.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // deshacerToolStripMenuItem
            // 
            this.deshacerToolStripMenuItem.Image = global::Aplicacion_1.Properties.Resources.Redo_rehacer;
            this.deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
            this.deshacerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.deshacerToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.deshacerToolStripMenuItem.Text = "Deshacer";
            this.deshacerToolStripMenuItem.Click += new System.EventHandler(this.deshacerToolStripMenuItem_Click);
            // 
            // reahacerToolStripMenuItem
            // 
            this.reahacerToolStripMenuItem.Image = global::Aplicacion_1.Properties.Resources.Undo_rehacer1;
            this.reahacerToolStripMenuItem.Name = "reahacerToolStripMenuItem";
            this.reahacerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.reahacerToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.reahacerToolStripMenuItem.Text = "Reahacer";
            this.reahacerToolStripMenuItem.Click += new System.EventHandler(this.reahacerToolStripMenuItem_Click);
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Fuente});
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.formatoToolStripMenuItem.Text = "Formato";
            // 
            // Fuente
            // 
            this.Fuente.Image = global::Aplicacion_1.Properties.Resources.fuente;
            this.Fuente.Name = "Fuente";
            this.Fuente.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.Fuente.Size = new System.Drawing.Size(152, 22);
            this.Fuente.Text = "Fuente";
            this.Fuente.Click += new System.EventHandler(this.Fuente_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Contenedor_txt
            // 
            this.Contenedor_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor_txt.Location = new System.Drawing.Point(0, 49);
            this.Contenedor_txt.Name = "Contenedor_txt";
            this.Contenedor_txt.Size = new System.Drawing.Size(528, 251);
            this.Contenedor_txt.TabIndex = 2;
            this.Contenedor_txt.Text = "";
            // 
            // combox_tamf
            // 
            this.combox_tamf.FormattingEnabled = true;
            this.combox_tamf.Location = new System.Drawing.Point(343, 28);
            this.combox_tamf.Name = "combox_tamf";
            this.combox_tamf.Size = new System.Drawing.Size(40, 21);
            this.combox_tamf.TabIndex = 3;
            this.combox_tamf.SelectedIndexChanged += new System.EventHandler(this.combox_tamf_SelectedIndexChanged);
            // 
            // cb_fuente
            // 
            this.cb_fuente.FormattingEnabled = true;
            this.cb_fuente.Location = new System.Drawing.Point(389, 28);
            this.cb_fuente.Name = "cb_fuente";
            this.cb_fuente.Size = new System.Drawing.Size(138, 21);
            this.cb_fuente.TabIndex = 4;
            this.cb_fuente.SelectedIndexChanged += new System.EventHandler(this.cb_fuente_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 300);
            this.Controls.Add(this.cb_fuente);
            this.Controls.Add(this.combox_tamf);
            this.Controls.Add(this.Contenedor_txt);
            this.Controls.Add(this.Caja);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Editor de texto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Caja.ResumeLayout(false);
            this.Caja.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Caja;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem guardar_boton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox Contenedor_txt;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deshacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reahacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton B_abrir_archivo;
        private System.Windows.Forms.ToolStripButton B_guardar;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Fuente;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripButton b_nuevo_archivo;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton Cursiva;
        private System.Windows.Forms.ToolStripButton Subrayar;
        private System.Windows.Forms.ToolStripButton Fuente_1;
        private System.Windows.Forms.ToolStripButton Color;
        private System.Windows.Forms.ComboBox combox_tamf;
        private System.Windows.Forms.ComboBox cb_fuente;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}

