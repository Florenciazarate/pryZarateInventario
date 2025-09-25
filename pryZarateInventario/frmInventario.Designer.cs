namespace pryZarateInventario
{
    partial class frmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventario));
            lblInventario = new Label();
            panel1 = new Panel();
            btnAgregar = new Button();
            txtProducto = new TextBox();
            lblBuscarProducto = new Label();
            btnBuscar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblInventario
            // 
            lblInventario.AutoSize = true;
            lblInventario.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInventario.Location = new Point(48, 26);
            lblInventario.Name = "lblInventario";
            lblInventario.Size = new Size(106, 30);
            lblInventario.TabIndex = 0;
            lblInventario.Text = "Inventario";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Ivory;
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(lblBuscarProducto);
            panel1.Controls.Add(txtProducto);
            panel1.Controls.Add(btnAgregar);
            panel1.Location = new Point(45, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(515, 330);
            panel1.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Nirmala Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(23, 167);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(183, 44);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar un producto";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtProducto
            // 
            txtProducto.BackColor = Color.Ivory;
            txtProducto.Location = new Point(19, 67);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(208, 23);
            txtProducto.TabIndex = 1;
            // 
            // lblBuscarProducto
            // 
            lblBuscarProducto.AutoSize = true;
            lblBuscarProducto.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscarProducto.Location = new Point(12, 35);
            lblBuscarProducto.Name = "lblBuscarProducto";
            lblBuscarProducto.Size = new Size(363, 21);
            lblBuscarProducto.TabIndex = 3;
            lblBuscarProducto.Text = "Ingresa el nombre, código o categoría del producto";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkKhaki;
            btnBuscar.Font = new Font("Nirmala Text", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscar.Location = new Point(21, 100);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(76, 31);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(620, 450);
            Controls.Add(lblInventario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInventario;
        private Panel panel1;
        private Button btnBuscar;
        private Label lblBuscarProducto;
        private TextBox txtProducto;
        private Button btnAgregar;
    }
}