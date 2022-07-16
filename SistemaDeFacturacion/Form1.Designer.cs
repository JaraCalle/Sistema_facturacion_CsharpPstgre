namespace SistemaDeFacturacion
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
            this.cmb_productos = new System.Windows.Forms.ComboBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.nup_cantidad = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBox_iva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_descuento = new System.Windows.Forms.TextBox();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.txtBox_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBox_nit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBox_nitC = new System.Windows.Forms.TextBox();
            this.txtBox_nombreC = new System.Windows.Forms.TextBox();
            this.txtBox_ApellidoC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_registrarse = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nup_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_productos
            // 
            this.cmb_productos.FormattingEnabled = true;
            this.cmb_productos.Items.AddRange(new object[] {
            "mouse cetus",
            "mouse cyborg",
            "teclado mintaka",
            "teclado pulsar",
            "audifonos shake",
            "audifonos gemini"});
            this.cmb_productos.Location = new System.Drawing.Point(150, 64);
            this.cmb_productos.Name = "cmb_productos";
            this.cmb_productos.Size = new System.Drawing.Size(151, 28);
            this.cmb_productos.TabIndex = 0;
            this.cmb_productos.Text = "Productos";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(326, 27);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(137, 39);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // nup_cantidad
            // 
            this.nup_cantidad.Location = new System.Drawing.Point(53, 64);
            this.nup_cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup_cantidad.Name = "nup_cantidad";
            this.nup_cantidad.Size = new System.Drawing.Size(44, 27);
            this.nup_cantidad.TabIndex = 2;
            this.nup_cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Descripcion,
            this.Precio});
            this.dataGridView1.Location = new System.Drawing.Point(43, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(429, 268);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio Unitario";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Eliminar producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBox_iva
            // 
            this.txtBox_iva.Location = new System.Drawing.Point(287, 469);
            this.txtBox_iva.Name = "txtBox_iva";
            this.txtBox_iva.Size = new System.Drawing.Size(50, 27);
            this.txtBox_iva.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "%IVA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "%Descuento";
            // 
            // txtBox_descuento
            // 
            this.txtBox_descuento.Location = new System.Drawing.Point(404, 469);
            this.txtBox_descuento.Name = "txtBox_descuento";
            this.txtBox_descuento.Size = new System.Drawing.Size(50, 27);
            this.txtBox_descuento.TabIndex = 7;
            // 
            // btn_pagar
            // 
            this.btn_pagar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pagar.Location = new System.Drawing.Point(43, 452);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(124, 57);
            this.btn_pagar.TabIndex = 9;
            this.btn_pagar.Text = "Pagar";
            this.btn_pagar.UseVisualStyleBackColor = true;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // txtBox_total
            // 
            this.txtBox_total.Enabled = false;
            this.txtBox_total.Location = new System.Drawing.Point(142, 520);
            this.txtBox_total.Name = "txtBox_total";
            this.txtBox_total.Size = new System.Drawing.Size(125, 27);
            this.txtBox_total.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total a pagar:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBox_total);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 562);
            this.panel1.TabIndex = 12;
            // 
            // txtBox_nit
            // 
            this.txtBox_nit.Location = new System.Drawing.Point(129, 53);
            this.txtBox_nit.Name = "txtBox_nit";
            this.txtBox_nit.Size = new System.Drawing.Size(138, 27);
            this.txtBox_nit.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "NIT del comprador:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 15;
            this.button2.Text = "Ingresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtBox_nit);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(510, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 167);
            this.panel2.TabIndex = 16;
            // 
            // txtBox_nitC
            // 
            this.txtBox_nitC.Location = new System.Drawing.Point(639, 402);
            this.txtBox_nitC.Name = "txtBox_nitC";
            this.txtBox_nitC.Size = new System.Drawing.Size(138, 27);
            this.txtBox_nitC.TabIndex = 17;
            // 
            // txtBox_nombreC
            // 
            this.txtBox_nombreC.Location = new System.Drawing.Point(535, 283);
            this.txtBox_nombreC.Name = "txtBox_nombreC";
            this.txtBox_nombreC.Size = new System.Drawing.Size(138, 27);
            this.txtBox_nombreC.TabIndex = 18;
            // 
            // txtBox_ApellidoC
            // 
            this.txtBox_ApellidoC.Location = new System.Drawing.Point(731, 283);
            this.txtBox_ApellidoC.Name = "txtBox_ApellidoC";
            this.txtBox_ApellidoC.Size = new System.Drawing.Size(138, 27);
            this.txtBox_ApellidoC.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(731, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Apellido:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(639, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "NIT:";
            // 
            // btn_registrarse
            // 
            this.btn_registrarse.Location = new System.Drawing.Point(648, 469);
            this.btn_registrarse.Name = "btn_registrarse";
            this.btn_registrarse.Size = new System.Drawing.Size(113, 43);
            this.btn_registrarse.TabIndex = 22;
            this.btn_registrarse.Text = "Registrarse";
            this.btn_registrarse.UseVisualStyleBackColor = true;
            this.btn_registrarse.Click += new System.EventHandler(this.btn_registrarse_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Location = new System.Drawing.Point(510, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(386, 371);
            this.panel3.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 592);
            this.Controls.Add(this.btn_registrarse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBox_ApellidoC);
            this.Controls.Add(this.txtBox_nombreC);
            this.Controls.Add(this.txtBox_nitC);
            this.Controls.Add(this.btn_pagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_descuento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_iva);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nup_cantidad);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.cmb_productos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nup_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmb_productos;
        private Button btn_agregar;
        private NumericUpDown nup_cantidad;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
        private Button button1;
        private TextBox txtBox_iva;
        private Label label1;
        private Label label2;
        private TextBox txtBox_descuento;
        private Button btn_pagar;
        private TextBox txtBox_total;
        private Label label3;
        private Panel panel1;
        private TextBox txtBox_nit;
        private Label label4;
        private Button button2;
        private Panel panel2;
        private TextBox txtBox_nitC;
        private TextBox txtBox_nombreC;
        private TextBox txtBox_ApellidoC;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btn_registrarse;
        private Panel panel3;
    }
}