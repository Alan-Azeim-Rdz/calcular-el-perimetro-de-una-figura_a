namespace calcular_el_perimetro_de_una_figura
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
            Bcricle = new Button();
            Bsquare = new Button();
            Btriangle = new Button();
            radiustxt = new TextBox();
            sidetxt = new TextBox();
            side1txt = new TextBox();
            side2txt = new TextBox();
            side3txt = new TextBox();
            message1 = new TextBox();
            message2 = new TextBox();
            message3 = new TextBox();
            SuspendLayout();
            // 
            // Bcricle
            // 
            Bcricle.BackColor = Color.Goldenrod;
            Bcricle.Location = new Point(32, 106);
            Bcricle.Margin = new Padding(3, 4, 3, 4);
            Bcricle.Name = "Bcricle";
            Bcricle.Size = new Size(86, 31);
            Bcricle.TabIndex = 0;
            Bcricle.Text = "Cricle";
            Bcricle.UseVisualStyleBackColor = false;
            Bcricle.Click += Bcircle_Click;
            // 
            // Bsquare
            // 
            Bsquare.BackColor = Color.GreenYellow;
            Bsquare.Location = new Point(32, 232);
            Bsquare.Margin = new Padding(3, 4, 3, 4);
            Bsquare.Name = "Bsquare";
            Bsquare.Size = new Size(86, 31);
            Bsquare.TabIndex = 1;
            Bsquare.Text = "Square";
            Bsquare.UseVisualStyleBackColor = false;
            Bsquare.Click += Bsquare_Click;
            // 
            // Btriangle
            // 
            Btriangle.BackColor = Color.Red;
            Btriangle.Location = new Point(32, 351);
            Btriangle.Margin = new Padding(3, 4, 3, 4);
            Btriangle.Name = "Btriangle";
            Btriangle.Size = new Size(86, 31);
            Btriangle.TabIndex = 2;
            Btriangle.Text = "traingle";
            Btriangle.UseVisualStyleBackColor = false;
            Btriangle.Click += Btriangle_Click;
            // 
            // radiustxt
            // 
            radiustxt.Location = new Point(185, 106);
            radiustxt.Name = "radiustxt";
            radiustxt.Size = new Size(350, 27);
            radiustxt.TabIndex = 3;
            radiustxt.TextAlign = HorizontalAlignment.Center;
            // 
            // sidetxt
            // 
            sidetxt.Location = new Point(185, 232);
            sidetxt.Name = "sidetxt";
            sidetxt.Size = new Size(350, 27);
            sidetxt.TabIndex = 4;
            sidetxt.TextChanged += sidetxt_TextChanged;
            // 
            // side1txt
            // 
            side1txt.Location = new Point(166, 351);
            side1txt.Name = "side1txt";
            side1txt.Size = new Size(125, 27);
            side1txt.TabIndex = 6;
            // 
            // side2txt
            // 
            side2txt.Location = new Point(308, 351);
            side2txt.Name = "side2txt";
            side2txt.Size = new Size(125, 27);
            side2txt.TabIndex = 7;
            // 
            // side3txt
            // 
            side3txt.Location = new Point(454, 351);
            side3txt.Name = "side3txt";
            side3txt.Size = new Size(125, 27);
            side3txt.TabIndex = 8;
            // 
            // message1
            // 
            message1.Location = new Point(260, 73);
            message1.Name = "message1";
            message1.ReadOnly = true;
            message1.Size = new Size(210, 27);
            message1.TabIndex = 9;
            message1.Text = "What is the radio of the circle?";
            message1.TextChanged += textBox6_TextChanged;
            // 
            // message2
            // 
            message2.Location = new Point(176, 186);
            message2.Name = "message2";
            message2.ReadOnly = true;
            message2.Size = new Size(369, 27);
            message2.TabIndex = 10;
            message2.Text = "what is the measure of one of the sides of the square?";
            // 
            // message3
            // 
            message3.Location = new Point(127, 292);
            message3.Name = "message3";
            message3.ReadOnly = true;
            message3.Size = new Size(466, 27);
            message3.TabIndex = 11;
            message3.Text = "write the measure of each of the sides of the triangle, 1 for each box.";
            message3.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(654, 499);
            Controls.Add(message3);
            Controls.Add(message2);
            Controls.Add(message1);
            Controls.Add(side3txt);
            Controls.Add(side2txt);
            Controls.Add(side1txt);
            Controls.Add(sidetxt);
            Controls.Add(radiustxt);
            Controls.Add(Btriangle);
            Controls.Add(Bsquare);
            Controls.Add(Bcricle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Bcricle;
        private Button Bsquare;
        private Button Btriangle;
        private TextBox radiustxt;
        private TextBox sidetxt;
        private TextBox side1txt;
        private TextBox side2txt;
        private TextBox side3txt;
        private TextBox message1;
        private TextBox message2;
        private TextBox message3;
    }
}