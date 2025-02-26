namespace PooOperacionesBasicas2025
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
            label1 = new Label();
            label2 = new Label();
            TxtValor1 = new TextBox();
            TxtValor2 = new TextBox();
            BtnMultiplicacion = new Button();
            BtnDivision = new Button();
            BtnSuma = new Button();
            BtnResta = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 34);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Valor1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 92);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 0;
            label2.Text = "Valor 2:";
            // 
            // TxtValor1
            // 
            TxtValor1.Location = new Point(344, 34);
            TxtValor1.Name = "TxtValor1";
            TxtValor1.Size = new Size(110, 27);
            TxtValor1.TabIndex = 1;
            TxtValor1.Text = "0.00";
            TxtValor1.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtValor2
            // 
            TxtValor2.Location = new Point(344, 85);
            TxtValor2.Name = "TxtValor2";
            TxtValor2.Size = new Size(110, 27);
            TxtValor2.TabIndex = 1;
            TxtValor2.Text = "0.00";
            TxtValor2.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnMultiplicacion
            // 
            BtnMultiplicacion.Font = new Font("Segoe UI", 20F);
            BtnMultiplicacion.Location = new Point(249, 265);
            BtnMultiplicacion.Name = "BtnMultiplicacion";
            BtnMultiplicacion.Size = new Size(94, 75);
            BtnMultiplicacion.TabIndex = 2;
            BtnMultiplicacion.Text = "*";
            BtnMultiplicacion.UseVisualStyleBackColor = true;
            BtnMultiplicacion.Click += BtnMultiplicacion_Click;
            // 
            // BtnDivision
            // 
            BtnDivision.Font = new Font("Segoe UI", 20F);
            BtnDivision.Location = new Point(360, 265);
            BtnDivision.Name = "BtnDivision";
            BtnDivision.Size = new Size(94, 75);
            BtnDivision.TabIndex = 2;
            BtnDivision.Text = "/";
            BtnDivision.UseVisualStyleBackColor = true;
            BtnDivision.Click += BtnDivision_Click;
            // 
            // BtnSuma
            // 
            BtnSuma.Font = new Font("Segoe UI", 20F);
            BtnSuma.Location = new Point(249, 157);
            BtnSuma.Name = "BtnSuma";
            BtnSuma.Size = new Size(94, 75);
            BtnSuma.TabIndex = 2;
            BtnSuma.Text = "+";
            BtnSuma.UseVisualStyleBackColor = true;
            BtnSuma.Click += BtnSuma_Click;
            // 
            // BtnResta
            // 
            BtnResta.Font = new Font("Segoe UI", 20F);
            BtnResta.Location = new Point(360, 157);
            BtnResta.Name = "BtnResta";
            BtnResta.Size = new Size(94, 75);
            BtnResta.TabIndex = 2;
            BtnResta.Text = "-";
            BtnResta.UseVisualStyleBackColor = true;
            BtnResta.Click += BtnResta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 429);
            Controls.Add(BtnResta);
            Controls.Add(BtnSuma);
            Controls.Add(BtnDivision);
            Controls.Add(BtnMultiplicacion);
            Controls.Add(TxtValor2);
            Controls.Add(TxtValor1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtValor1;
        private TextBox TxtValor2;
        private Button BtnMultiplicacion;
        private Button BtnDivision;
        private Button BtnSuma;
        private Button BtnResta;
    }
}
