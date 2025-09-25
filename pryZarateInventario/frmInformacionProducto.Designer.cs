namespace pryZarateInventario
{
    partial class frmInformacionProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformacionProducto));
            lblInfomacion = new Label();
            panel1 = new Panel();
            btnEliminar = new Button();
            btnModificar = new Button();
            lblCategoria = new Label();
            lblNombre = new Label();
            lblCodigo = new Label();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblInfomacion
            // 
            lblInfomacion.AutoSize = true;
            lblInfomacion.Font = new Font("Nirmala Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfomacion.Location = new Point(53, 31);
            lblInfomacion.Name = "lblInfomacion";
            lblInfomacion.Size = new Size(186, 21);
            lblInfomacion.TabIndex = 0;
            lblInfomacion.Text = "Información del producto";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Ivory;
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(lblCategoria);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(lblCodigo);
            panel1.Location = new Point(46, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(538, 218);
            panel1.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Ivory;
            btnEliminar.Font = new Font("Nirmala Text", 9.75F);
            btnEliminar.Location = new Point(210, 170);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(180, 30);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar producto";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Ivory;
            btnModificar.Font = new Font("Nirmala Text", 9.75F);
            btnModificar.Location = new Point(24, 170);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(180, 32);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar producto";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Nirmala Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(20, 101);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(80, 21);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "Categoría:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Nirmala Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(20, 70);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 21);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Nirmala Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(20, 37);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(63, 21);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código:";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Nirmala Text", 9.75F);
            btnCancelar.Location = new Point(451, 318);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(133, 30);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmInformacionProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(662, 366);
            Controls.Add(btnCancelar);
            Controls.Add(lblInfomacion);
            Controls.Add(panel1);
            Font = new Font("Nirmala Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmInformacionProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Información del producto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfomacion;
        private Panel panel1;
        private Label lblCategoria;
        private Label lblNombre;
        private Label lblCodigo;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnModificar;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}