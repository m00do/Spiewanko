namespace SpiewnikHarce
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
            panel1 = new Panel();
            DodajPiosenkePrzycisk = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            MM = new Button();
            EkranPowitalny = new Panel();
            panel7 = new Panel();
            richTextBox1 = new RichTextBox();
            panel6 = new Panel();
            MPH = new Label();
            PiosenkowyPanel = new Panel();
            panel4 = new Panel();
            richTextBox2 = new RichTextBox();
            label3 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            textBox2 = new TextBox();
            PanelLogowaniaWendroli = new Panel();
            panel5 = new Panel();
            LoginTextBox = new TextBox();
            button2 = new Button();
            PassCodePanel = new TextBox();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            button5 = new Button();
            TekstDodanejPiosenki = new RichTextBox();
            DodanaPiosenkaTytul = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            EkranPowitalny.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            PiosenkowyPanel.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            PanelLogowaniaWendroli.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(DodajPiosenkePrzycisk);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(282, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 10);
            panel1.TabIndex = 0;
            panel1.Visible = false;
            // 
            // DodajPiosenkePrzycisk
            // 
            DodajPiosenkePrzycisk.Enabled = false;
            DodajPiosenkePrzycisk.Location = new Point(12, 259);
            DodajPiosenkePrzycisk.Name = "DodajPiosenkePrzycisk";
            DodajPiosenkePrzycisk.Size = new Size(176, 23);
            DodajPiosenkePrzycisk.TabIndex = 7;
            DodajPiosenkePrzycisk.Text = "DodajPiosenke";
            DodajPiosenkePrzycisk.UseVisualStyleBackColor = true;
            DodajPiosenkePrzycisk.Visible = false;
            DodajPiosenkePrzycisk.Click += DodajPiosenkePrzycisk_Click;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(12, 220);
            button4.Name = "button4";
            button4.Size = new Size(176, 23);
            button4.TabIndex = 6;
            button4.Text = "Bochaterowie";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(75, 531);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Zaloguj Się";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(194, 177);
            button1.Name = "button1";
            button1.Size = new Size(52, 23);
            button1.TabIndex = 1;
            button1.Text = "szukaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 160);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 1;
            label1.Text = "Wyszukaj Piosenke:";
            // 
            // textBox1
            // 
            textBox1.AutoCompleteCustomSource.AddRange(new string[] { "Hej Przyjaciele" });
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.Location = new Point(12, 178);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Wpisz Tytuł";
            textBox1.Size = new Size(176, 23);
            textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MM
            // 
            MM.ForeColor = Color.ForestGreen;
            MM.ImageKey = "(brak)";
            MM.Location = new Point(70, 32);
            MM.Name = "MM";
            MM.Size = new Size(41, 34);
            MM.TabIndex = 1;
            MM.Text = "MM";
            MM.UseVisualStyleBackColor = true;
            MM.Click += button2_Click;
            // 
            // EkranPowitalny
            // 
            EkranPowitalny.Controls.Add(panel7);
            EkranPowitalny.Controls.Add(panel6);
            EkranPowitalny.Location = new Point(266, -2);
            EkranPowitalny.Name = "EkranPowitalny";
            EkranPowitalny.Size = new Size(10, 10);
            EkranPowitalny.TabIndex = 2;
            EkranPowitalny.Visible = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Bisque;
            panel7.Controls.Add(richTextBox1);
            panel7.Location = new Point(44, 168);
            panel7.Name = "panel7";
            panel7.Size = new Size(544, 308);
            panel7.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Bisque;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = Color.ForestGreen;
            richTextBox1.Location = new Point(7, 10);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(511, 278);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "Lorem Ipsum del el sol";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Bisque;
            panel6.Controls.Add(MPH);
            panel6.Location = new Point(41, 34);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 42);
            panel6.TabIndex = 2;
            // 
            // MPH
            // 
            MPH.AutoSize = true;
            MPH.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            MPH.ForeColor = Color.ForestGreen;
            MPH.Location = new Point(61, 6);
            MPH.Name = "MPH";
            MPH.Size = new Size(64, 32);
            MPH.TabIndex = 0;
            MPH.Text = "Hejo";
            MPH.Click += MPH_Click;
            // 
            // PiosenkowyPanel
            // 
            PiosenkowyPanel.BackColor = Color.FloralWhite;
            PiosenkowyPanel.Controls.Add(panel4);
            PiosenkowyPanel.Controls.Add(panel3);
            PiosenkowyPanel.Location = new Point(218, -2);
            PiosenkowyPanel.Name = "PiosenkowyPanel";
            PiosenkowyPanel.Size = new Size(10, 10);
            PiosenkowyPanel.TabIndex = 3;
            PiosenkowyPanel.Visible = false;
            PiosenkowyPanel.Paint += PiosenkowyPanel_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.PeachPuff;
            panel4.Controls.Add(richTextBox2);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(89, 105);
            panel4.Name = "panel4";
            panel4.Size = new Size(504, 437);
            panel4.TabIndex = 6;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.PeachPuff;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.ForeColor = Color.DarkGreen;
            richTextBox2.Location = new Point(10, 41);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(468, 380);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(10, 8);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // panel3
            // 
            panel3.BackColor = Color.PeachPuff;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBox2);
            panel3.Location = new Point(86, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(379, 71);
            panel3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(13, 13);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "Tytuł";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.PeachPuff;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = Color.DarkGreen;
            textBox2.Location = new Point(13, 39);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(199, 16);
            textBox2.TabIndex = 0;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // PanelLogowaniaWendroli
            // 
            PanelLogowaniaWendroli.BackColor = Color.FloralWhite;
            PanelLogowaniaWendroli.Controls.Add(panel5);
            PanelLogowaniaWendroli.Location = new Point(234, -2);
            PanelLogowaniaWendroli.Name = "PanelLogowaniaWendroli";
            PanelLogowaniaWendroli.Size = new Size(10, 10);
            PanelLogowaniaWendroli.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.ForestGreen;
            panel5.Controls.Add(LoginTextBox);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(PassCodePanel);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(214, 142);
            panel5.Name = "panel5";
            panel5.Size = new Size(284, 216);
            panel5.TabIndex = 5;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(11, 57);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(257, 23);
            LoginTextBox.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(93, 178);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Zaloguj się";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // PassCodePanel
            // 
            PassCodePanel.Location = new Point(11, 127);
            PassCodePanel.Name = "PassCodePanel";
            PassCodePanel.Size = new Size(257, 23);
            PassCodePanel.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 100);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 3;
            label5.Text = "Wpisz Hasło";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 26);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 2;
            label4.Text = "Wpisz Login:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(TekstDodanejPiosenki);
            panel2.Controls.Add(DodanaPiosenkaTytul);
            panel2.Location = new Point(250, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 10);
            panel2.TabIndex = 5;
            panel2.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 72);
            label7.Name = "label7";
            label7.Size = new Size(132, 15);
            label7.TabIndex = 4;
            label7.Text = "Tu Wpisz tekst Piosenki:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 14);
            label6.Name = "label6";
            label6.Size = new Size(132, 15);
            label6.TabIndex = 3;
            label6.Text = "Tu Wpisz Tytuł Piosenki:";
            label6.Click += label6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(361, 501);
            button5.Name = "button5";
            button5.Size = new Size(72, 37);
            button5.TabIndex = 2;
            button5.Text = "Dodaj";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // TekstDodanejPiosenki
            // 
            TekstDodanejPiosenki.Location = new Point(19, 105);
            TekstDodanejPiosenki.Name = "TekstDodanejPiosenki";
            TekstDodanejPiosenki.Size = new Size(414, 361);
            TekstDodanejPiosenki.TabIndex = 1;
            TekstDodanejPiosenki.Text = "";
            // 
            // DodanaPiosenkaTytul
            // 
            DodanaPiosenkaTytul.Location = new Point(19, 45);
            DodanaPiosenkaTytul.Name = "DodanaPiosenkaTytul";
            DodanaPiosenkaTytul.PlaceholderText = "Tak Tutaj";
            DodanaPiosenkaTytul.Size = new Size(235, 23);
            DodanaPiosenkaTytul.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 564);
            Controls.Add(panel2);
            Controls.Add(PanelLogowaniaWendroli);
            Controls.Add(PiosenkowyPanel);
            Controls.Add(EkranPowitalny);
            Controls.Add(MM);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            EkranPowitalny.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            PiosenkowyPanel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            PanelLogowaniaWendroli.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button MM;
        private Panel EkranPowitalny;
        private RichTextBox richTextBox1;
        private Label MPH;
        private Panel PiosenkowyPanel;
        private RichTextBox richTextBox2;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Panel PanelLogowaniaWendroli;
        private Button button2;
        private Label label5;
        private Label label4;
        private TextBox PassCodePanel;
        private TextBox LoginTextBox;
        private Button button3;
        private Button button4;
        private Panel panel2;
        private Button button5;
        private RichTextBox TekstDodanejPiosenki;
        private TextBox DodanaPiosenkaTytul;
        private Button DodajPiosenkePrzycisk;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label6;
        private Label label7;
        private Panel panel6;
        private Panel panel7;
    }
}