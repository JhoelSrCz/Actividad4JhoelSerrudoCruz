namespace SistemaPedidos.VISTAS.ClienteVistas
{
    partial class ClienteEditarVista
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
            label7 = new Label();
            btnCancel = new Button();
            btnGuardar = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(201, 24);
            label7.Name = "label7";
            label7.Size = new Size(251, 37);
            label7.TabIndex = 28;
            label7.Text = "EDITAR CLIENTE";
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(354, 396);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(129, 45);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "CANCELAR";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.DialogResult = DialogResult.OK;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(148, 396);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 45);
            btnGuardar.TabIndex = 26;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(191, 322);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(281, 27);
            textBox6.TabIndex = 25;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(191, 267);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(281, 27);
            textBox5.TabIndex = 24;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(191, 212);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(281, 27);
            textBox4.TabIndex = 23;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(191, 157);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(281, 27);
            textBox3.TabIndex = 22;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(191, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(281, 27);
            textBox2.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(100, 325);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 20;
            label6.Text = "DIRECCION";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 270);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 19;
            label5.Text = "TELEFONO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 215);
            label4.Name = "label4";
            label4.Size = new Size(165, 20);
            label4.TabIndex = 18;
            label4.Text = "CORREO ELECTRONICO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 160);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 17;
            label3.Text = "APELLIDO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 105);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 16;
            label2.Text = "NOMBRE";
            // 
            // ClienteEditarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 450);
            Controls.Add(label7);
            Controls.Add(btnCancel);
            Controls.Add(btnGuardar);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "ClienteEditarVista";
            Text = "ClienteEditarVista";
            Load += ClienteEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Button btnCancel;
        private Button btnGuardar;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}