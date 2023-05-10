namespace calculadoraPRJ
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
            NUDprimeironumero = new NumericUpDown();
            NUDsegundonumero = new NumericUpDown();
            textBox1 = new TextBox();
            label1 = new Label();
            primeirooperando = new Label();
            label2 = new Label();
            radiomais = new RadioButton();
            radiomenos = new RadioButton();
            radiovezes = new RadioButton();
            radiodivisao = new RadioButton();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)NUDprimeironumero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDsegundonumero).BeginInit();
            SuspendLayout();
            // 
            // NUDprimeironumero
            // 
            NUDprimeironumero.Location = new Point(158, 135);
            NUDprimeironumero.Maximum = new decimal(new int[] { -1486618624, 232830643, 0, 0 });
            NUDprimeironumero.Name = "NUDprimeironumero";
            NUDprimeironumero.Size = new Size(268, 23);
            NUDprimeironumero.TabIndex = 7;
            // 
            // NUDsegundonumero
            // 
            NUDsegundonumero.Location = new Point(158, 192);
            NUDsegundonumero.Maximum = new decimal(new int[] { -1486618624, 232830643, 0, 0 });
            NUDsegundonumero.Name = "NUDsegundonumero";
            NUDsegundonumero.Size = new Size(268, 23);
            NUDsegundonumero.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(283, 384);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 33);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 10;
            label1.Text = "label1";
            // 
            // primeirooperando
            // 
            primeirooperando.AutoSize = true;
            primeirooperando.Location = new Point(35, 135);
            primeirooperando.Name = "primeirooperando";
            primeirooperando.Size = new Size(109, 15);
            primeirooperando.TabIndex = 11;
            primeirooperando.Text = "Primeiro operando:";
            primeirooperando.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 194);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 12;
            label2.Text = "Segundo operando:";
            // 
            // radiomais
            // 
            radiomais.AutoSize = true;
            radiomais.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            radiomais.Location = new Point(171, 241);
            radiomais.Name = "radiomais";
            radiomais.Size = new Size(48, 36);
            radiomais.TabIndex = 13;
            radiomais.TabStop = true;
            radiomais.Text = "+";
            radiomais.UseVisualStyleBackColor = true;
            // 
            // radiomenos
            // 
            radiomenos.AutoSize = true;
            radiomenos.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            radiomenos.Location = new Point(232, 241);
            radiomenos.Name = "radiomenos";
            radiomenos.Size = new Size(42, 36);
            radiomenos.TabIndex = 14;
            radiomenos.TabStop = true;
            radiomenos.Text = "-";
            radiomenos.UseVisualStyleBackColor = true;
            // 
            // radiovezes
            // 
            radiovezes.AutoSize = true;
            radiovezes.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            radiovezes.Location = new Point(294, 241);
            radiovezes.Name = "radiovezes";
            radiovezes.Size = new Size(43, 36);
            radiovezes.TabIndex = 15;
            radiovezes.TabStop = true;
            radiovezes.Text = "x";
            radiovezes.UseVisualStyleBackColor = true;
            // 
            // radiodivisao
            // 
            radiodivisao.AutoSize = true;
            radiodivisao.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            radiodivisao.Location = new Point(352, 241);
            radiodivisao.Name = "radiodivisao";
            radiodivisao.Size = new Size(41, 36);
            radiodivisao.TabIndex = 16;
            radiodivisao.TabStop = true;
            radiodivisao.Text = "/";
            radiodivisao.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(114, 381);
            label3.Name = "label3";
            label3.Size = new Size(118, 32);
            label3.TabIndex = 17;
            label3.Text = "Resultado";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(158, 307);
            button1.Name = "button1";
            button1.Size = new Size(226, 43);
            button1.TabIndex = 18;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 489);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(radiodivisao);
            Controls.Add(radiovezes);
            Controls.Add(radiomenos);
            Controls.Add(radiomais);
            Controls.Add(label2);
            Controls.Add(primeirooperando);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(NUDsegundonumero);
            Controls.Add(NUDprimeironumero);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)NUDprimeironumero).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDsegundonumero).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown NUDprimeironumero;
        private NumericUpDown NUDsegundonumero;
        private TextBox textBox1;
        private Label label1;
        private Label primeirooperando;
        private Label label2;
        private RadioButton radiomais;
        private RadioButton radiomenos;
        private RadioButton radiovezes;
        private RadioButton radiodivisao;
        private Label label3;
        private Button button1;
    }
}