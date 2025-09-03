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
            txtPrecioU = new TextBox();
            dateFecha = new DateTimePicker();
            lstCantidad = new NumericUpDown();
            btnCancelar = new Button();
            lstProducto = new ComboBox();
            lblResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)lstCantidad).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.DarkSalmon;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = SystemColors.Control;
            btnAceptar.Location = new Point(54, 233);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(88, 34);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
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
            // txtPrecioU
            // 
            txtPrecioU.Location = new Point(161, 184);
            txtPrecioU.Name = "txtPrecioU";
            txtPrecioU.Size = new Size(110, 23);
            txtPrecioU.TabIndex = 9;
            // 
            // dateFecha
            // 
            dateFecha.Location = new Point(102, 75);
            dateFecha.Name = "dateFecha";
            dateFecha.Size = new Size(200, 23);
            dateFecha.TabIndex = 10;
            // 
            // lstCantidad
            // 
            lstCantidad.Enabled = false;
            lstCantidad.Location = new Point(129, 149);
            lstCantidad.Name = "lstCantidad";
            lstCantidad.Size = new Size(52, 23);
            lstCantidad.TabIndex = 11;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.SkyBlue;
            btnCancelar.BackgroundImageLayout = ImageLayout.None;
            btnCancelar.FlatStyle = FlatStyle.System;
            btnCancelar.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
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
            lstProducto.TextChanged += lstProducto_TextChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.PaleGoldenrod;
            lblResultado.BorderStyle = BorderStyle.FixedSingle;
            lblResultado.FlatStyle = FlatStyle.Flat;
            lblResultado.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(54, 276);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(2, 17);
            lblResultado.TabIndex = 14;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(337, 317);
            Controls.Add(lblResultado);
            Controls.Add(lstProducto);
            Controls.Add(btnCancelar);
            Controls.Add(lstCantidad);
            Controls.Add(dateFecha);
            Controls.Add(txtPrecioU);
            Controls.Add(lblPrecio);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblFecha);
            Controls.Add(lblPrincipal);
            Controls.Add(btnAceptar);
            Name = "frmRegistro";
            Text = "frmRegistro";
            ((System.ComponentModel.ISupportInitialize)lstCantidad).EndInit();
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
        private TextBox txtPrecioU;
        private DateTimePicker dateFecha;
        private NumericUpDown lstCantidad;
        private Button btnCancelar;
        private ComboBox lstProducto;
        private Label lblResultado;
    }
}