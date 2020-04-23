namespace WinProductos
{
    partial class FormProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
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
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.BackColor = System.Drawing.Color.OliveDrab;
            this.groupBoxDatos.Controls.Add(this.textBoxDesc);
            this.groupBoxDatos.Controls.Add(this.textBoxStock);
            this.groupBoxDatos.Controls.Add(this.textBoxPrecio);
            this.groupBoxDatos.Controls.Add(this.textBoxNom);
            this.groupBoxDatos.Controls.Add(this.labelStock);
            this.groupBoxDatos.Controls.Add(this.labelPrecio);
            this.groupBoxDatos.Controls.Add(this.labelDesc);
            this.groupBoxDatos.Controls.Add(this.labelNom);
            this.groupBoxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatos.ForeColor = System.Drawing.Color.White;
            this.groupBoxDatos.Location = new System.Drawing.Point(87, 12);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(400, 200);
            this.groupBoxDatos.TabIndex = 0;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos Producto";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDesc.Location = new System.Drawing.Point(148, 63);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(200, 44);
            this.textBoxDesc.TabIndex = 7;
            // 
            // textBoxStock
            // 
            this.textBoxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStock.Location = new System.Drawing.Point(148, 146);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(200, 22);
            this.textBoxStock.TabIndex = 6;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecio.Location = new System.Drawing.Point(148, 115);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(200, 22);
            this.textBoxPrecio.TabIndex = 5;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(148, 33);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(200, 22);
            this.textBoxNom.TabIndex = 4;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(49, 149);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(51, 16);
            this.labelStock.TabIndex = 3;
            this.labelStock.Text = "Stock:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(49, 118);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(57, 16);
            this.labelPrecio.TabIndex = 2;
            this.labelPrecio.Text = "Precio:";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(49, 63);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(95, 16);
            this.labelDesc.TabIndex = 1;
            this.labelDesc.Text = "Descripción:";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(49, 36);
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
            this.dgvBuscar.Size = new System.Drawing.Size(400, 125);
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
            this.tsbtnGurdar.Image = global::WinProductos.Properties.Resources.Save_37110;
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
            this.tsbtnEliminar.Image = global::WinProductos.Properties.Resources.trash_full_recycle_delete_delete_9751;
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
            this.tsbtnBuscar.Image = global::WinProductos.Properties.Resources.xmag_search_find_export_locate_5984;
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
            this.tsbtnCancelar.Image = global::WinProductos.Properties.Resources.cancel_stop_exit_1583;
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
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinProductos.Properties.Resources.Abstract_Wallpaper_Background_Computers_Windows_2zyemowh9qrdjkq7p4cv0q;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.dgvBuscar);
            this.Controls.Add(this.groupBoxDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProductos";
            this.Text = "Administrador de Productos";
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
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelDesc;
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
    }
}

