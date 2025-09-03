namespace pryAppRegistros
{
    partial class frmRegistro
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
            btnAceptar = new Button();
            lblPrincipal = new Label();
            lblFecha = new Label();
            lblProducto = new Label();
            lblCantidad = new Label();
            lblPrecio = new Label();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            btnCancelar = new Button();
            lstProducto = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Tan;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = SystemColors.ActiveCaptionText;
            btnAceptar.Location = new Point(54, 233);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(88, 34);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // lblPrincipal
            // 
            lblPrincipal.AutoSize = true;
            lblPrincipal.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrincipal.Location = new Point(54, 24);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new Size(97, 30);
            lblPrincipal.TabIndex = 2;
            lblPrincipal.Text = "Kioscubi";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Nirmala UI", 11.25F);
            lblFecha.Location = new Point(54, 76);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 20);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Nirmala UI", 11.25F);
            lblProducto.Location = new Point(54, 114);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(69, 20);
            lblProducto.TabIndex = 4;
            lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Nirmala UI", 11.25F);
            lblCantidad.Location = new Point(54, 149);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 20);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Nirmala UI", 11.25F);
            lblPrecio.Location = new Point(54, 185);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(105, 20);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio unitario";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(161, 184);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 23);
            textBox4.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(102, 75);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(129, 149);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(52, 23);
            numericUpDown1.TabIndex = 11;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.SkyBlue;
            btnCancelar.BackgroundImageLayout = ImageLayout.None;
            btnCancelar.FlatStyle = FlatStyle.System;
            btnCancelar.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.Location = new Point(148, 233);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 34);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lstProducto
            // 
            lstProducto.FormattingEnabled = true;
            lstProducto.Location = new Point(125, 114);
            lstProducto.Name = "lstProducto";
            lstProducto.Size = new Size(146, 23);
            lstProducto.TabIndex = 13;
            lstProducto.SelectedIndexChanged += lstProducto_SelectedIndexChanged;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(337, 293);
            Controls.Add(lstProducto);
            Controls.Add(btnCancelar);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(lblPrecio);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblFecha);
            Controls.Add(lblPrincipal);
            Controls.Add(btnAceptar);
            Name = "frmRegistro";
            Text = "frmRegistro";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAceptar;
        private Label lblPrincipal;
        private Label lblFecha;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblPrecio;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private Button btnCancelar;
        private ComboBox lstProducto;
    }
}