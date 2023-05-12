namespace calculodesalarioPRJ
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
            calcular = new Button();
            txtsalariobruto = new TextBox();
            transporte = new CheckBox();
            convênio = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            liquido = new TextBox();
            SuspendLayout();
            // 
            // calcular
            // 
            calcular.Location = new Point(251, 223);
            calcular.Name = "calcular";
            calcular.Size = new Size(75, 23);
            calcular.TabIndex = 0;
            calcular.Text = "Calcular";
            calcular.UseVisualStyleBackColor = true;
            calcular.Click += calcular_Click;
            // 
            // txtsalariobruto
            // 
            txtsalariobruto.Location = new Point(232, 85);
            txtsalariobruto.Name = "txtsalariobruto";
            txtsalariobruto.Size = new Size(203, 23);
            txtsalariobruto.TabIndex = 1;
            // 
            // transporte
            // 
            transporte.AutoSize = true;
            transporte.Location = new Point(103, 163);
            transporte.Name = "transporte";
            transporte.Size = new Size(147, 19);
            transporte.TabIndex = 2;
            transporte.Text = "Recebo Vale Transporte";
            transporte.UseVisualStyleBackColor = true;
            transporte.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // convênio
            // 
            convênio.AutoSize = true;
            convênio.Location = new Point(316, 163);
            convênio.Name = "convênio";
            convênio.Size = new Size(162, 19);
            convênio.TabIndex = 3;
            convênio.Text = "Recebo Convênio Médico";
            convênio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 88);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 4;
            label1.Text = "Digite o Salário Bruto (R$)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 285);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 5;
            label2.Text = "Salário Líquido (R$)";
            // 
            // liquido
            // 
            liquido.Location = new Point(251, 282);
            liquido.Name = "liquido";
            liquido.Size = new Size(197, 23);
            liquido.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 394);
            Controls.Add(liquido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(convênio);
            Controls.Add(transporte);
            Controls.Add(txtsalariobruto);
            Controls.Add(calcular);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calcular;
        private TextBox txtsalariobruto;
        private CheckBox transporte;
        private CheckBox convênio;
        private Label label1;
        private Label label2;
        private TextBox liquido;
    }
}