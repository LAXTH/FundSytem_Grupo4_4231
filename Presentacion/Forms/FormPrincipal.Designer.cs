namespace Presentacion
{
    partial class FormPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnGraficas = new System.Windows.Forms.Button();
            this.btnInsumo = new System.Windows.Forms.Button();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ucGraficas1 = new Presentacion.UCGraficas();
            this.ucInsumo1 = new Presentacion.UCInsumo();
            this.ucAlmacen1 = new Presentacion.UCAlmacen();
            this.ucProveedor1 = new Presentacion.UCProveedor();
            this.ucInicio1 = new Presentacion.UCInicio();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnGraficas);
            this.panel1.Controls.Add(this.btnInsumo);
            this.panel1.Controls.Add(this.btnAlmacen);
            this.panel1.Controls.Add(this.btnProveedor);
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 682);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(75)))), ((int)(((byte)(56)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 227);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 54);
            this.SidePanel.TabIndex = 1;
            // 
            // btnGraficas
            // 
            this.btnGraficas.FlatAppearance.BorderSize = 0;
            this.btnGraficas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.btnGraficas.Image = global::Presentacion.Properties.Resources.Graficas;
            this.btnGraficas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraficas.Location = new System.Drawing.Point(24, 558);
            this.btnGraficas.Name = "btnGraficas";
            this.btnGraficas.Size = new System.Drawing.Size(197, 57);
            this.btnGraficas.TabIndex = 5;
            this.btnGraficas.Text = "     Gráficas";
            this.btnGraficas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGraficas.UseVisualStyleBackColor = true;
            this.btnGraficas.Click += new System.EventHandler(this.btnGraficas_Click);
            // 
            // btnInsumo
            // 
            this.btnInsumo.FlatAppearance.BorderSize = 0;
            this.btnInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsumo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.btnInsumo.Image = global::Presentacion.Properties.Resources.Insumo;
            this.btnInsumo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsumo.Location = new System.Drawing.Point(24, 478);
            this.btnInsumo.Name = "btnInsumo";
            this.btnInsumo.Size = new System.Drawing.Size(197, 55);
            this.btnInsumo.TabIndex = 4;
            this.btnInsumo.Text = "     Insumo";
            this.btnInsumo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsumo.UseVisualStyleBackColor = true;
            this.btnInsumo.Click += new System.EventHandler(this.btnInsumo_Click);
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.FlatAppearance.BorderSize = 0;
            this.btnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlmacen.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmacen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.btnAlmacen.Image = global::Presentacion.Properties.Resources.Almacen;
            this.btnAlmacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlmacen.Location = new System.Drawing.Point(24, 396);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(197, 55);
            this.btnAlmacen.TabIndex = 3;
            this.btnAlmacen.Text = "     Almacen";
            this.btnAlmacen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlmacen.UseVisualStyleBackColor = true;
            this.btnAlmacen.Click += new System.EventHandler(this.btnAlmacen_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.FlatAppearance.BorderSize = 0;
            this.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.btnProveedor.Image = global::Presentacion.Properties.Resources.Proveedor;
            this.btnProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedor.Location = new System.Drawing.Point(24, 309);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(197, 55);
            this.btnProveedor.TabIndex = 2;
            this.btnProveedor.Text = "     Proveedor";
            this.btnProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.btnInicio.Image = global::Presentacion.Properties.Resources.HomeWhite;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(24, 226);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(197, 55);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "     Inicio";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.IconMaster;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.button1.Image = global::Presentacion.Properties.Resources.Power;
            this.button1.Location = new System.Drawing.Point(1090, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 6;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucGraficas1
            // 
            this.ucGraficas1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.ucGraficas1.Location = new System.Drawing.Point(225, 50);
            this.ucGraficas1.Name = "ucGraficas1";
            this.ucGraficas1.Size = new System.Drawing.Size(924, 632);
            this.ucGraficas1.TabIndex = 11;
            // 
            // ucInsumo1
            // 
            this.ucInsumo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.ucInsumo1.Location = new System.Drawing.Point(225, 50);
            this.ucInsumo1.Name = "ucInsumo1";
            this.ucInsumo1.Size = new System.Drawing.Size(924, 632);
            this.ucInsumo1.TabIndex = 10;
            // 
            // ucAlmacen1
            // 
            this.ucAlmacen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.ucAlmacen1.Location = new System.Drawing.Point(225, 50);
            this.ucAlmacen1.Name = "ucAlmacen1";
            this.ucAlmacen1.Size = new System.Drawing.Size(924, 632);
            this.ucAlmacen1.TabIndex = 9;
            // 
            // ucProveedor1
            // 
            this.ucProveedor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.ucProveedor1.Location = new System.Drawing.Point(225, 50);
            this.ucProveedor1.Name = "ucProveedor1";
            this.ucProveedor1.Size = new System.Drawing.Size(924, 632);
            this.ucProveedor1.TabIndex = 8;
            // 
            // ucInicio1
            // 
            this.ucInicio1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.ucInicio1.Location = new System.Drawing.Point(225, 50);
            this.ucInicio1.Name = "ucInicio1";
            this.ucInicio1.Size = new System.Drawing.Size(924, 632);
            this.ucInicio1.TabIndex = 7;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1150, 682);
            this.Controls.Add(this.ucGraficas1);
            this.Controls.Add(this.ucInsumo1);
            this.Controls.Add(this.ucAlmacen1);
            this.Controls.Add(this.ucProveedor1);
            this.Controls.Add(this.ucInicio1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnGraficas;
        private System.Windows.Forms.Button btnInsumo;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button button1;
        private UCInicio ucInicio1;
        private UCProveedor ucProveedor1;
        private UCAlmacen ucAlmacen1;
        private UCInsumo ucInsumo1;
        private UCGraficas ucGraficas1;
    }
}