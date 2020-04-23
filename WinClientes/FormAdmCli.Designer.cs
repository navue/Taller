namespace WinClientes
{
    partial class FormAdmCli
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmCli));
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.textBoxAp = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelDir = new System.Windows.Forms.Label();
            this.labelFechNac = new System.Windows.Forms.Label();
            this.labelApe = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnGurdar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.linkLabelBlog = new System.Windows.Forms.LinkLabel();
            this.linkLabelYoutube = new System.Windows.Forms.LinkLabel();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.BackColor = System.Drawing.Color.OliveDrab;
            this.groupBoxDatos.Controls.Add(this.dtpFecha);
            this.groupBoxDatos.Controls.Add(this.textBoxDir);
            this.groupBoxDatos.Controls.Add(this.textBoxAp);
            this.groupBoxDatos.Controls.Add(this.textBoxNom);
            this.groupBoxDatos.Controls.Add(this.labelDir);
            this.groupBoxDatos.Controls.Add(this.labelFechNac);
            this.groupBoxDatos.Controls.Add(this.labelApe);
            this.groupBoxDatos.Controls.Add(this.labelNom);
            this.groupBoxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatos.ForeColor = System.Drawing.Color.White;
            this.groupBoxDatos.Location = new System.Drawing.Point(87, 12);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(411, 200);
            this.groupBoxDatos.TabIndex = 0;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos Personales";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(184, 93);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 8;
            // 
            // textBoxDir
            // 
            this.textBoxDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDir.Location = new System.Drawing.Point(184, 125);
            this.textBoxDir.Multiline = true;
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(200, 44);
            this.textBoxDir.TabIndex = 7;
            // 
            // textBoxAp
            // 
            this.textBoxAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAp.Location = new System.Drawing.Point(184, 63);
            this.textBoxAp.Name = "textBoxAp";
            this.textBoxAp.Size = new System.Drawing.Size(200, 20);
            this.textBoxAp.TabIndex = 5;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(184, 33);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(200, 20);
            this.textBoxNom.TabIndex = 4;
            // 
            // labelDir
            // 
            this.labelDir.AutoSize = true;
            this.labelDir.Location = new System.Drawing.Point(16, 128);
            this.labelDir.Name = "labelDir";
            this.labelDir.Size = new System.Drawing.Size(78, 16);
            this.labelDir.TabIndex = 3;
            this.labelDir.Text = "Dirección:";
            // 
            // labelFechNac
            // 
            this.labelFechNac.AutoSize = true;
            this.labelFechNac.Location = new System.Drawing.Point(16, 98);
            this.labelFechNac.Name = "labelFechNac";
            this.labelFechNac.Size = new System.Drawing.Size(159, 16);
            this.labelFechNac.TabIndex = 2;
            this.labelFechNac.Text = "Fecha de Nacimiento:";
            // 
            // labelApe
            // 
            this.labelApe.AutoSize = true;
            this.labelApe.Location = new System.Drawing.Point(16, 66);
            this.labelApe.Name = "labelApe";
            this.labelApe.Size = new System.Drawing.Size(70, 16);
            this.labelApe.TabIndex = 1;
            this.labelApe.Text = "Apellido:";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(16, 36);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(67, 16);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nombre:";
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.Location = new System.Drawing.Point(87, 230);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.Size = new System.Drawing.Size(411, 125);
            this.dgvBuscar.TabIndex = 1;
            this.dgvBuscar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscar_CellClick);
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.Color.OliveDrab;
            this.toolStripMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnGurdar,
            this.toolStripSeparator1,
            this.tsbtnEliminar,
            this.toolStripSeparator2,
            this.tsbtnBuscar,
            this.toolStripSeparator3,
            this.tsbtnCancelar,
            this.toolStripSeparator4});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 386);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(584, 25);
            this.toolStripMenu.TabIndex = 2;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbtnGurdar
            // 
            this.tsbtnGurdar.AutoSize = false;
            this.tsbtnGurdar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnGurdar.Image = global::WinClientes.Properties.Resources.Save_37110;
            this.tsbtnGurdar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnGurdar.Name = "tsbtnGurdar";
            this.tsbtnGurdar.Size = new System.Drawing.Size(74, 22);
            this.tsbtnGurdar.Text = "&Guardar";
            this.tsbtnGurdar.Click += new System.EventHandler(this.tsbtnGurdar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnEliminar
            // 
            this.tsbtnEliminar.AutoSize = false;
            this.tsbtnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnEliminar.Image = global::WinClientes.Properties.Resources.trash_full_recycle_delete_delete_9751;
            this.tsbtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEliminar.Name = "tsbtnEliminar";
            this.tsbtnEliminar.Size = new System.Drawing.Size(74, 22);
            this.tsbtnEliminar.Text = "&Eliminar";
            this.tsbtnEliminar.Click += new System.EventHandler(this.tsbtnEliminar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnBuscar
            // 
            this.tsbtnBuscar.AutoSize = false;
            this.tsbtnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnBuscar.Image = global::WinClientes.Properties.Resources.xmag_search_find_export_locate_5984;
            this.tsbtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBuscar.Name = "tsbtnBuscar";
            this.tsbtnBuscar.Size = new System.Drawing.Size(74, 22);
            this.tsbtnBuscar.Text = "&Buscar";
            this.tsbtnBuscar.Click += new System.EventHandler(this.tsbtnBuscar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnCancelar
            // 
            this.tsbtnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnCancelar.Image = global::WinClientes.Properties.Resources.cancel_stop_exit_1583;
            this.tsbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancelar.Name = "tsbtnCancelar";
            this.tsbtnCancelar.Size = new System.Drawing.Size(74, 22);
            this.tsbtnCancelar.Text = "&Cancelar";
            this.tsbtnCancelar.Click += new System.EventHandler(this.tsbtnCancelar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // linkLabelBlog
            // 
            this.linkLabelBlog.AutoSize = true;
            this.linkLabelBlog.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelBlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelBlog.LinkColor = System.Drawing.Color.Black;
            this.linkLabelBlog.Location = new System.Drawing.Point(12, 9);
            this.linkLabelBlog.Name = "linkLabelBlog";
            this.linkLabelBlog.Size = new System.Drawing.Size(54, 18);
            this.linkLabelBlog.TabIndex = 3;
            this.linkLabelBlog.TabStop = true;
            this.linkLabelBlog.Text = "Al Blog";
            // 
            // linkLabelYoutube
            // 
            this.linkLabelYoutube.AutoSize = true;
            this.linkLabelYoutube.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelYoutube.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelYoutube.LinkColor = System.Drawing.Color.Black;
            this.linkLabelYoutube.Location = new System.Drawing.Point(514, 9);
            this.linkLabelYoutube.Name = "linkLabelYoutube";
            this.linkLabelYoutube.Size = new System.Drawing.Size(62, 18);
            this.linkLabelYoutube.TabIndex = 4;
            this.linkLabelYoutube.TabStop = true;
            this.linkLabelYoutube.Text = "Youtube";
            // 
            // FormAdmCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinClientes.Properties.Resources.Abstract_Wallpaper_Background_Computers_Windows_2zyemowh9qrdjkq7p4cv0q;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.linkLabelYoutube);
            this.Controls.Add(this.linkLabelBlog);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.dgvBuscar);
            this.Controls.Add(this.groupBoxDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmCli";
            this.Text = "Administrador de Clientes";
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.TextBox textBoxAp;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelDir;
        private System.Windows.Forms.Label labelFechNac;
        private System.Windows.Forms.Label labelApe;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbtnGurdar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.LinkLabel linkLabelBlog;
        private System.Windows.Forms.LinkLabel linkLabelYoutube;
    }
}

