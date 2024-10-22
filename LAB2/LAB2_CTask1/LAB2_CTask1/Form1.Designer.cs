namespace LAB2_CTask1
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
            button1 = new Button();
            tb8 = new TextBox();
            tb16 = new TextBox();
            tb64 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lvMersenne = new ListBox();
            button2 = new Button();
            listBox2 = new ListBox();
            button3 = new Button();
            tbCheck = new TextBox();
            button4 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbfirstnumber = new TextBox();
            tbsecondnumber = new TextBox();
            label7 = new Label();
            label8 = new Label();
            btnLook = new Button();
            tbKetQua = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            tbA = new TextBox();
            tbX = new TextBox();
            tbB = new TextBox();
            label15 = new Label();
            tbResult = new TextBox();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(376, 100);
            button1.Name = "button1";
            button1.Size = new Size(180, 29);
            button1.TabIndex = 0;
            button1.Text = "Generate Prime numbers";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tb8
            // 
            tb8.Location = new Point(142, 32);
            tb8.Name = "tb8";
            tb8.Size = new Size(195, 27);
            tb8.TabIndex = 1;
            // 
            // tb16
            // 
            tb16.Location = new Point(142, 102);
            tb16.Name = "tb16";
            tb16.Size = new Size(195, 27);
            tb16.TabIndex = 2;
            // 
            // tb64
            // 
            tb64.Location = new Point(142, 177);
            tb64.Name = "tb64";
            tb64.Size = new Size(195, 27);
            tb64.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 39);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 4;
            label1.Text = "8 bits";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 109);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 5;
            label2.Text = "16 bits";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 184);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 6;
            label3.Text = "64 bits";
            // 
            // lvMersenne
            // 
            lvMersenne.FormattingEnabled = true;
            lvMersenne.Location = new Point(58, 239);
            lvMersenne.Name = "lvMersenne";
            lvMersenne.Size = new Size(279, 184);
            lvMersenne.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(376, 304);
            button2.Name = "button2";
            button2.Size = new Size(271, 29);
            button2.TabIndex = 8;
            button2.Text = "Generate 10 first Mersenne Prime Numbers";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(58, 457);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(279, 184);
            listBox2.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(362, 539);
            button3.Name = "button3";
            button3.Size = new Size(271, 55);
            button3.TabIndex = 10;
            button3.Text = "Generate 10 largest Prime Number under 10 first Mersenne Prime Numbers";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tbCheck
            // 
            tbCheck.Location = new Point(884, 85);
            tbCheck.Name = "tbCheck";
            tbCheck.Size = new Size(196, 27);
            tbCheck.TabIndex = 11;
            // 
            // button4
            // 
            button4.Location = new Point(1121, 83);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 12;
            button4.Text = "Check";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(700, 92);
            label4.Name = "label4";
            label4.Size = new Size(156, 20);
            label4.TabIndex = 13;
            label4.Text = "Nhập số cần kiểm tra: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(700, 32);
            label5.Name = "label5";
            label5.Size = new Size(237, 20);
            label5.TabIndex = 14;
            label5.Text = "Tìm số nguyên tố nhỏ hơn 2^89 -1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(700, 193);
            label6.Name = "label6";
            label6.Size = new Size(172, 20);
            label6.TabIndex = 15;
            label6.Text = "Tìm ước chung lớn nhất: ";
            // 
            // tbfirstnumber
            // 
            tbfirstnumber.Location = new Point(1090, 239);
            tbfirstnumber.Name = "tbfirstnumber";
            tbfirstnumber.Size = new Size(196, 27);
            tbfirstnumber.TabIndex = 16;
            // 
            // tbsecondnumber
            // 
            tbsecondnumber.Location = new Point(1090, 334);
            tbsecondnumber.Name = "tbsecondnumber";
            tbsecondnumber.Size = new Size(196, 27);
            tbsecondnumber.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(700, 246);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 18;
            label7.Text = "Số thứ nhất: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(700, 334);
            label8.Name = "label8";
            label8.Size = new Size(83, 20);
            label8.TabIndex = 19;
            label8.Text = "Số thứ hai: ";
            // 
            // btnLook
            // 
            btnLook.Location = new Point(1244, 285);
            btnLook.Name = "btnLook";
            btnLook.Size = new Size(94, 29);
            btnLook.TabIndex = 20;
            btnLook.Text = "Tìm";
            btnLook.UseVisualStyleBackColor = true;
            btnLook.Click += btnLook_Click;
            // 
            // tbKetQua
            // 
            tbKetQua.Location = new Point(1090, 408);
            tbKetQua.Name = "tbKetQua";
            tbKetQua.Size = new Size(196, 27);
            tbKetQua.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(700, 411);
            label9.Name = "label9";
            label9.Size = new Size(123, 20);
            label9.TabIndex = 22;
            label9.Text = "Kết quả thu được";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(700, 484);
            label10.Name = "label10";
            label10.Size = new Size(195, 20);
            label10.TabIndex = 23;
            label10.Text = "Tìm kết quả của A^X mod B";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(700, 539);
            label11.Name = "label11";
            label11.Size = new Size(0, 20);
            label11.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(700, 539);
            label12.Name = "label12";
            label12.Size = new Size(62, 20);
            label12.TabIndex = 25;
            label12.Text = "Nhập A:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(700, 596);
            label13.Name = "label13";
            label13.Size = new Size(61, 20);
            label13.TabIndex = 26;
            label13.Text = "Nhập X:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(701, 643);
            label14.Name = "label14";
            label14.Size = new Size(61, 20);
            label14.TabIndex = 27;
            label14.Text = "Nhập B:";
            // 
            // tbA
            // 
            tbA.Location = new Point(1042, 532);
            tbA.Name = "tbA";
            tbA.Size = new Size(196, 27);
            tbA.TabIndex = 28;
            // 
            // tbX
            // 
            tbX.Location = new Point(1042, 589);
            tbX.Name = "tbX";
            tbX.Size = new Size(196, 27);
            tbX.TabIndex = 29;
            // 
            // tbB
            // 
            tbB.Location = new Point(1042, 643);
            tbB.Name = "tbB";
            tbB.Size = new Size(196, 27);
            tbB.TabIndex = 30;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(652, 724);
            label15.Name = "label15";
            label15.Size = new Size(123, 20);
            label15.TabIndex = 32;
            label15.Text = "Kết quả thu được";
            // 
            // tbResult
            // 
            tbResult.Location = new Point(1042, 721);
            tbResult.Name = "tbResult";
            tbResult.Size = new Size(196, 27);
            tbResult.TabIndex = 31;
            // 
            // button5
            // 
            button5.Location = new Point(855, 678);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 33;
            button5.Text = "Tính";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 845);
            Controls.Add(button5);
            Controls.Add(label15);
            Controls.Add(tbResult);
            Controls.Add(tbB);
            Controls.Add(tbX);
            Controls.Add(tbA);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(tbKetQua);
            Controls.Add(btnLook);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(tbsecondnumber);
            Controls.Add(tbfirstnumber);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(tbCheck);
            Controls.Add(button3);
            Controls.Add(listBox2);
            Controls.Add(button2);
            Controls.Add(lvMersenne);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb64);
            Controls.Add(tb16);
            Controls.Add(tb8);
            Controls.Add(button1);
            Name = "Form1";
            Text = "PRIME NUMBER";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tb8;
        private TextBox tb16;
        private TextBox tb64;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lvMersenne;
        private Button button2;
        private ListBox listBox2;
        private Button button3;
        private TextBox tbCheck;
        private Button button4;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbfirstnumber;
        private TextBox tbsecondnumber;
        private Label label7;
        private Label label8;
        private Button btnLook;
        private TextBox tbKetQua;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox tbA;
        private TextBox tbX;
        private TextBox tbB;
        private Label label15;
        private TextBox tbResult;
        private Button button5;
    }
}
