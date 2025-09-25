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
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 31);
            label1.Name = "label1";
            label1.Size = new Size(186, 21);
            label1.TabIndex = 0;
            label1.Text = "Información del producto";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Ivory;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(46, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(538, 270);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 37);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 1;
            label2.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 70);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 101);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 3;
            label4.Text = "Categoría";
            // 
            // button1
            // 
            button1.Location = new Point(20, 187);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 4;
            button1.Text = "Modificar producto";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(148, 187);
            button2.Name = "button2";
            button2.Size = new Size(115, 23);
            button2.TabIndex = 5;
            button2.Text = "Eliminar producto";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(269, 187);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // frmInformacionProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(662, 366);
            Controls.Add(label1);
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

        private Label label1;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}