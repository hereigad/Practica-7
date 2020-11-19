namespace Practica_7
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.boton = new System.Windows.Forms.ToolStripButton();
            this.etiqueta = new System.Windows.Forms.ToolStripLabel();
            this.separador = new System.Windows.Forms.ToolStripSeparator();
            this.botonSplit = new System.Windows.Forms.ToolStripSplitButton();
            this.botonDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.arribaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izquierdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verBarraDeHerramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocultarBarraDeHerramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.opcion1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcion2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcion3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ContextMenuStrip = this.contextMenuStrip1;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boton,
            this.etiqueta,
            this.separador,
            this.botonSplit,
            this.botonDropDown,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // boton
            // 
            this.boton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boton.Image = ((System.Drawing.Image)(resources.GetObject("boton.Image")));
            this.boton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(23, 22);
            this.boton.Text = "toolStripButton1";
            this.boton.Click += new System.EventHandler(this.boton_Click);
            // 
            // etiqueta
            // 
            this.etiqueta.AutoToolTip = true;
            this.etiqueta.Name = "etiqueta";
            this.etiqueta.Size = new System.Drawing.Size(86, 22);
            this.etiqueta.Text = "toolStripLabel1";
            // 
            // separador
            // 
            this.separador.Name = "separador";
            this.separador.Size = new System.Drawing.Size(6, 25);
            // 
            // botonSplit
            // 
            this.botonSplit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botonSplit.DropDown = this.contextMenuStrip3;
            this.botonSplit.Image = ((System.Drawing.Image)(resources.GetObject("botonSplit.Image")));
            this.botonSplit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botonSplit.Name = "botonSplit";
            this.botonSplit.Size = new System.Drawing.Size(32, 22);
            this.botonSplit.Text = "toolStripSplitButton1";
            this.botonSplit.ButtonClick += new System.EventHandler(this.boton_Click);
            // 
            // botonDropDown
            // 
            this.botonDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("botonDropDown.Image")));
            this.botonDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botonDropDown.Name = "botonDropDown";
            this.botonDropDown.Size = new System.Drawing.Size(29, 22);
            this.botonDropDown.Text = "toolStripDropDownButton1";
            this.botonDropDown.Click += new System.EventHandler(this.boton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arribaToolStripMenuItem,
            this.abajoToolStripMenuItem,
            this.izquierdaToolStripMenuItem,
            this.derechaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 92);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verBarraDeHerramientasToolStripMenuItem,
            this.ocultarBarraDeHerramientasToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(232, 48);
            // 
            // arribaToolStripMenuItem
            // 
            this.arribaToolStripMenuItem.Name = "arribaToolStripMenuItem";
            this.arribaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.arribaToolStripMenuItem.Text = "Arriba";
            // 
            // abajoToolStripMenuItem
            // 
            this.abajoToolStripMenuItem.Name = "abajoToolStripMenuItem";
            this.abajoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.abajoToolStripMenuItem.Text = "Abajo";
            // 
            // izquierdaToolStripMenuItem
            // 
            this.izquierdaToolStripMenuItem.Name = "izquierdaToolStripMenuItem";
            this.izquierdaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.izquierdaToolStripMenuItem.Text = "Izquierda";
            // 
            // derechaToolStripMenuItem
            // 
            this.derechaToolStripMenuItem.Name = "derechaToolStripMenuItem";
            this.derechaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.derechaToolStripMenuItem.Text = "Derecha";
            // 
            // verBarraDeHerramientasToolStripMenuItem
            // 
            this.verBarraDeHerramientasToolStripMenuItem.Name = "verBarraDeHerramientasToolStripMenuItem";
            this.verBarraDeHerramientasToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.verBarraDeHerramientasToolStripMenuItem.Text = "Ver barra de herramientas";
            this.verBarraDeHerramientasToolStripMenuItem.Click += new System.EventHandler(this.verBarraDeHerramientasToolStripMenuItem_Click);
            // 
            // ocultarBarraDeHerramientasToolStripMenuItem
            // 
            this.ocultarBarraDeHerramientasToolStripMenuItem.Name = "ocultarBarraDeHerramientasToolStripMenuItem";
            this.ocultarBarraDeHerramientasToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.ocultarBarraDeHerramientasToolStripMenuItem.Text = "Ocultar barra de herramientas";
            this.ocultarBarraDeHerramientasToolStripMenuItem.Click += new System.EventHandler(this.ocultarBarraDeHerramientasToolStripMenuItem_Click);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcion1ToolStripMenuItem,
            this.opcion2ToolStripMenuItem,
            this.opcion3ToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(123, 70);
            // 
            // opcion1ToolStripMenuItem
            // 
            this.opcion1ToolStripMenuItem.Name = "opcion1ToolStripMenuItem";
            this.opcion1ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.opcion1ToolStripMenuItem.Text = "Opcion1";
            // 
            // opcion2ToolStripMenuItem
            // 
            this.opcion2ToolStripMenuItem.Name = "opcion2ToolStripMenuItem";
            this.opcion2ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.opcion2ToolStripMenuItem.Text = "Opcion 2";
            // 
            // opcion3ToolStripMenuItem
            // 
            this.opcion3ToolStripMenuItem.Name = "opcion3ToolStripMenuItem";
            this.opcion3ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.opcion3ToolStripMenuItem.Text = "Opcion 3";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "a",
            "b",
            "c",
            "d"});
            this.toolStripComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toolStripComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.bToolStripMenuItem,
            this.cToolStripMenuItem,
            this.dToolStripMenuItem});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(82, 92);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.aToolStripMenuItem.Text = "a";
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.bToolStripMenuItem.Text = "b";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.cToolStripMenuItem.Text = "c";
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.dToolStripMenuItem.Text = "d";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton boton;
        private System.Windows.Forms.ToolStripLabel etiqueta;
        private System.Windows.Forms.ToolStripSeparator separador;
        private System.Windows.Forms.ToolStripSplitButton botonSplit;
        private System.Windows.Forms.ToolStripDropDownButton botonDropDown;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arribaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izquierdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derechaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem opcion1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcion2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcion3ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem verBarraDeHerramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocultarBarraDeHerramientasToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
    }
}

