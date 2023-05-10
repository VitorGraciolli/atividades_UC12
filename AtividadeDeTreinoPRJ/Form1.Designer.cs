namespace AtividadeDeTreinoPRJ
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
            RADIOdólar = new RadioButton();
            RADIOeuro = new RadioButton();
            converter = new Button();
            textBox1 = new TextBox();
            NUDnumeros = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)NUDnumeros).BeginInit();
            SuspendLayout();
            // 
            // RADIOdólar
            // 
            RADIOdólar.AutoSize = true;
            RADIOdólar.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Italic, GraphicsUnit.Point);
            RADIOdólar.Location = new Point(106, 120);
            RADIOdólar.Name = "RADIOdólar";
            RADIOdólar.Size = new Size(63, 23);
            RADIOdólar.TabIndex = 0;
            RADIOdólar.Text = "Dólar";
            RADIOdólar.UseVisualStyleBackColor = true;
            RADIOdólar.CheckedChanged += BNTdólar_CheckedChanged;
            // 
            // RADIOeuro
            // 
            RADIOeuro.AutoSize = true;
            RADIOeuro.Font = new Font("Swis721 Lt BT", 12F, FontStyle.Italic, GraphicsUnit.Point);
            RADIOeuro.Location = new Point(251, 120);
            RADIOeuro.Name = "RADIOeuro";
            RADIOeuro.Size = new Size(59, 23);
            RADIOeuro.TabIndex = 1;
            RADIOeuro.Text = "Euro";
            RADIOeuro.UseVisualStyleBackColor = true;
            RADIOeuro.CheckedChanged += BNTeuro_CheckedChanged;
            // 
            // converter
            // 
            converter.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            converter.Location = new Point(116, 152);
            converter.Name = "converter";
            converter.Size = new Size(185, 45);
            converter.TabIndex = 2;
            converter.Text = "converter";
            converter.UseVisualStyleBackColor = true;
            converter.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(59, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "Coloque o valor total a ser convertido para euro ou euro";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // NUDnumeros
            // 
            NUDnumeros.Location = new Point(78, 74);
            NUDnumeros.Maximum = new decimal(new int[] { -1486618624, 232830643, 0, 0 });
            NUDnumeros.Name = "NUDnumeros";
            NUDnumeros.Size = new Size(268, 23);
            NUDnumeros.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 303);
            Controls.Add(NUDnumeros);
            Controls.Add(textBox1);
            Controls.Add(converter);
            Controls.Add(RADIOeuro);
            Controls.Add(RADIOdólar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NUDnumeros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton RADIOdólar;
        private RadioButton RADIOeuro;
        private Button converter;
        private TextBox textBox1;
        private NumericUpDown NUDnumeros;
    }
}