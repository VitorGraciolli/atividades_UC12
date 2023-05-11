namespace passouOUnãoESCOLA_PRJ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            NUDfaltas = new NumericUpDown();
            TXTfaltas = new TextBox();
            TXTnota1 = new TextBox();
            TXTnota2 = new TextBox();
            TXTnota3 = new TextBox();
            NUDnota3 = new NumericUpDown();
            NUDnota2 = new NumericUpDown();
            NUDnota1 = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)NUDfaltas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDnota3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDnota2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDnota1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Swis721 Ex BT", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(55, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(275, 33);
            textBox1.TabIndex = 10;
            textBox1.Text = "calculo para aprovação";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // NUDfaltas
            // 
            NUDfaltas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NUDfaltas.Location = new Point(159, 62);
            NUDfaltas.Maximum = new decimal(new int[] { -1486618624, 232830643, 0, 0 });
            NUDfaltas.Name = "NUDfaltas";
            NUDfaltas.Size = new Size(187, 29);
            NUDfaltas.TabIndex = 0;
            NUDfaltas.Tag = "1";
            NUDfaltas.ValueChanged += NUDsegundonumero_ValueChanged;
            // 
            // TXTfaltas
            // 
            TXTfaltas.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            TXTfaltas.Location = new Point(34, 60);
            TXTfaltas.Name = "TXTfaltas";
            TXTfaltas.Size = new Size(55, 30);
            TXTfaltas.TabIndex = 10;
            TXTfaltas.Text = "Faltas";
            // 
            // TXTnota1
            // 
            TXTnota1.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            TXTnota1.Location = new Point(34, 106);
            TXTnota1.Name = "TXTnota1";
            TXTnota1.Size = new Size(110, 30);
            TXTnota1.TabIndex = 40;
            TXTnota1.Text = "primeira nota";
            // 
            // TXTnota2
            // 
            TXTnota2.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            TXTnota2.Location = new Point(34, 157);
            TXTnota2.Name = "TXTnota2";
            TXTnota2.Size = new Size(117, 30);
            TXTnota2.TabIndex = 50;
            TXTnota2.Text = "segunda nota";
            // 
            // TXTnota3
            // 
            TXTnota3.Font = new Font("Swis721 Lt BT", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            TXTnota3.Location = new Point(34, 207);
            TXTnota3.Name = "TXTnota3";
            TXTnota3.Size = new Size(104, 30);
            TXTnota3.TabIndex = 60;
            TXTnota3.Text = "terceira nota";
            // 
            // NUDnota3
            // 
            NUDnota3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NUDnota3.Location = new Point(159, 207);
            NUDnota3.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            NUDnota3.Name = "NUDnota3";
            NUDnota3.Size = new Size(187, 29);
            NUDnota3.TabIndex = 3;
            NUDnota3.Tag = "1";
            // 
            // NUDnota2
            // 
            NUDnota2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NUDnota2.Location = new Point(159, 158);
            NUDnota2.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            NUDnota2.Name = "NUDnota2";
            NUDnota2.Size = new Size(187, 29);
            NUDnota2.TabIndex = 2;
            NUDnota2.Tag = "1";
            // 
            // NUDnota1
            // 
            NUDnota1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NUDnota1.Location = new Point(159, 108);
            NUDnota1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            NUDnota1.Name = "NUDnota1";
            NUDnota1.Size = new Size(187, 29);
            NUDnota1.TabIndex = 1;
            NUDnota1.Tag = "1";
            // 
            // button1
            // 
            button1.Location = new Point(111, 280);
            button1.Name = "button1";
            button1.Size = new Size(145, 57);
            button1.TabIndex = 4;
            button1.Text = "aprovado? ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(373, 401);
            Controls.Add(button1);
            Controls.Add(NUDnota1);
            Controls.Add(NUDnota2);
            Controls.Add(NUDnota3);
            Controls.Add(TXTnota3);
            Controls.Add(TXTnota2);
            Controls.Add(TXTnota1);
            Controls.Add(TXTfaltas);
            Controls.Add(NUDfaltas);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NUDfaltas).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDnota3).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDnota2).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDnota1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private NumericUpDown NUDfaltas;
        private TextBox TXTfaltas;
        private TextBox TXTnota1;
        private TextBox TXTnota2;
        private TextBox TXTnota3;
        private NumericUpDown NUDnota3;
        private NumericUpDown NUDnota2;
        private NumericUpDown NUDnota1;
        private Button button1;
    }
}