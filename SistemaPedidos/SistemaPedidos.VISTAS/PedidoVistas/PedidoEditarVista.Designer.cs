namespace SistemaPedidos.VISTAS.PedidoVistas
{
    partial class PedidoEditarVista
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
            button1 = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            btnCancel = new Button();
            btnGuardar = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(544, 106);
            button1.Name = "button1";
            button1.Size = new Size(152, 45);
            button1.TabIndex = 46;
            button1.Text = "SELECCIONAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(248, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 27);
            textBox1.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 121);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 44;
            label4.Text = "IDCLIENTE";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(248, 265);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(281, 27);
            textBox3.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 268);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 42;
            label1.Text = "ESTADO";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(248, 165);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(281, 27);
            dateTimePicker1.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(146, 49);
            label7.Name = "label7";
            label7.Size = new Size(422, 37);
            label7.TabIndex = 40;
            label7.Text = "AGREGUE UN NUEVO PEDIDO";
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(400, 318);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(129, 45);
            btnCancel.TabIndex = 39;
            btnCancel.Text = "CANCELAR";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.DialogResult = DialogResult.OK;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(194, 318);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 45);
            btnGuardar.TabIndex = 38;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(248, 217);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(281, 27);
            textBox2.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 220);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 36;
            label3.Text = "TOTAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 165);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 35;
            label2.Text = "FECHA";
            // 
            // PedidoEditarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(btnCancel);
            Controls.Add(btnGuardar);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "PedidoEditarVista";
            Text = "PedidoEditarVista";
            Load += PedidoEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox3;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Button btnCancel;
        private Button btnGuardar;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
    }
}