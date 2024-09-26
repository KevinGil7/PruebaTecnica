namespace PruebaTecnica
{
    partial class Compra
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnagregar = new PictureBox();
            txtnombre = new TextBox();
            txtdescripcion = new TextBox();
            txtprecio = new TextBox();
            txtcantidad = new TextBox();
            btnactualizar = new PictureBox();
            btneliminar = new PictureBox();
            btndescargar = new PictureBox();
            label6 = new Label();
            txttotalfinal = new TextBox();
            dgvproductos = new DataGridView();
            salir = new Button();
            toolTip1 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            label7 = new Label();
            toolTip2 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnagregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnactualizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btneliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btndescargar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvproductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(335, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 40);
            label1.TabIndex = 1;
            label1.Text = "COMPRAS";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 81);
            label2.Name = "label2";
            label2.Size = new Size(183, 21);
            label2.TabIndex = 2;
            label2.Text = "Nombre del producto: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_azul_SM_1024x269;
            pictureBox1.Location = new Point(3, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(441, 81);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 4;
            label3.Text = "Descripcion: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(106, 125);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 5;
            label4.Text = "Precio: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(441, 127);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 6;
            label5.Text = "Cantidad:";
            // 
            // btnagregar
            // 
            btnagregar.Image = Properties.Resources._92844241;
            btnagregar.Location = new Point(664, 110);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(72, 56);
            btnagregar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnagregar.TabIndex = 9;
            btnagregar.TabStop = false;
            toolTip1.SetToolTip(btnagregar, "Agregar al carrito");
            btnagregar.Click += btnagregar_Click;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(187, 84);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(233, 23);
            txtnombre.TabIndex = 10;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(544, 81);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(244, 23);
            txtdescripcion.TabIndex = 11;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(187, 125);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(125, 23);
            txtprecio.TabIndex = 12;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(544, 129);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(77, 23);
            txtcantidad.TabIndex = 13;
            // 
            // btnactualizar
            // 
            btnactualizar.Image = Properties.Resources.ac;
            btnactualizar.Location = new Point(597, 231);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(77, 56);
            btnactualizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnactualizar.TabIndex = 14;
            btnactualizar.TabStop = false;
            toolTip2.SetToolTip(btnactualizar, "Actualizar Carrito");
            btnactualizar.Click += btnactualizar_Click;
            // 
            // btneliminar
            // 
            btneliminar.Image = Properties.Resources.eli;
            btneliminar.Location = new Point(711, 231);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(77, 56);
            btneliminar.SizeMode = PictureBoxSizeMode.StretchImage;
            btneliminar.TabIndex = 15;
            btneliminar.TabStop = false;
            toolTip3.SetToolTip(btneliminar, "Eliminar Carrito");
            btneliminar.Click += btneliminar_Click;
            // 
            // btndescargar
            // 
            btndescargar.Image = Properties.Resources.pd;
            btndescargar.Location = new Point(544, 342);
            btndescargar.Name = "btndescargar";
            btndescargar.Size = new Size(82, 88);
            btndescargar.SizeMode = PictureBoxSizeMode.StretchImage;
            btndescargar.TabIndex = 16;
            btndescargar.TabStop = false;
            toolTip4.SetToolTip(btndescargar, "Imprimir pdf");
            btndescargar.Click += btndescargar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(632, 400);
            label6.Name = "label6";
            label6.Size = new Size(89, 30);
            label6.TabIndex = 17;
            label6.Text = "Total: Q";
            // 
            // txttotalfinal
            // 
            txttotalfinal.Location = new Point(718, 407);
            txttotalfinal.Name = "txttotalfinal";
            txttotalfinal.ReadOnly = true;
            txttotalfinal.Size = new Size(100, 23);
            txttotalfinal.TabIndex = 18;
            // 
            // dgvproductos
            // 
            dgvproductos.AllowUserToAddRows = false;
            dgvproductos.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvproductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvproductos.ColumnHeadersHeight = 30;
            dgvproductos.EnableHeadersVisualStyles = false;
            dgvproductos.Location = new Point(13, 182);
            dgvproductos.MultiSelect = false;
            dgvproductos.Name = "dgvproductos";
            dgvproductos.ReadOnly = true;
            dgvproductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvproductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvproductos.Size = new Size(525, 248);
            dgvproductos.TabIndex = 86;
            dgvproductos.CellContentClick += dgvproductos_CellContentClick;
            // 
            // salir
            // 
            salir.BackColor = Color.Maroon;
            salir.ForeColor = SystemColors.Control;
            salir.Location = new Point(677, 9);
            salir.Name = "salir";
            salir.Size = new Size(118, 43);
            salir.TabIndex = 87;
            salir.Text = "SALIR";
            salir.UseVisualStyleBackColor = false;
            salir.Click += salir_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 161);
            label7.Name = "label7";
            label7.Size = new Size(140, 21);
            label7.TabIndex = 88;
            label7.Text = "Detalle del Carrito:";
            // 
            // Compra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(818, 447);
            Controls.Add(label7);
            Controls.Add(salir);
            Controls.Add(txttotalfinal);
            Controls.Add(label6);
            Controls.Add(btndescargar);
            Controls.Add(btneliminar);
            Controls.Add(btnactualizar);
            Controls.Add(txtcantidad);
            Controls.Add(txtprecio);
            Controls.Add(txtdescripcion);
            Controls.Add(txtnombre);
            Controls.Add(btnagregar);
            Controls.Add(dgvproductos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Compra";
            Text = "Compra";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnagregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnactualizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btneliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btndescargar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvproductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox btnagregar;
        private TextBox txtnombre;
        private TextBox txtdescripcion;
        private TextBox txtprecio;
        private TextBox txtcantidad;
        private PictureBox btnactualizar;
        private PictureBox btneliminar;
        private PictureBox btndescargar;
        private Label label6;
        private TextBox txttotalfinal;
        private DataGridView dgvproductos;
        private Button salir;
        private ToolTip toolTip1;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
        private Label label7;
        private ToolTip toolTip2;
    }
}
