namespace Cau2
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
        private Button btnEncrypt;
        private Button btnDencrypt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbData;
        private TextBox tbEncryptedData;
        private TextBox tbDencryptedData;
        private TextBox tbShift;
        private void InitializeComponent()
        {
            btnEncrypt = new Button();
            btnDencrypt = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbData = new TextBox();
            tbEncryptedData = new TextBox();
            tbDencryptedData = new TextBox();
            tbShift = new TextBox();
            btn_start = new Button();
            btn_stop = new Button();
            label5 = new Label();
            tbCurrentKey = new TextBox();
            label6 = new Label();
            tbDelay = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(268, 28);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(94, 29);
            btnEncrypt.TabIndex = 0;
            btnEncrypt.Text = "MÃ HÓA";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDencrypt
            // 
            btnDencrypt.Location = new Point(268, 95);
            btnDencrypt.Name = "btnDencrypt";
            btnDencrypt.Size = new Size(94, 29);
            btnDencrypt.TabIndex = 1;
            btnDencrypt.Text = "GIẢI MÃ";
            btnDencrypt.UseVisualStyleBackColor = true;
            btnDencrypt.Click += btnDencrypt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 66);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "Dịch(Shift)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 125);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 3;
            label2.Text = "Dữ liệu (Input)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 348);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 4;
            label3.Text = "Mã hóa ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 604);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 5;
            label4.Text = "Giải Mã";
            // 
            // tbData
            // 
            tbData.Location = new Point(62, 159);
            tbData.Multiline = true;
            tbData.Name = "tbData";
            tbData.Size = new Size(663, 186);
            tbData.TabIndex = 6;
            // 
            // tbEncryptedData
            // 
            tbEncryptedData.Location = new Point(62, 380);
            tbEncryptedData.Multiline = true;
            tbEncryptedData.Name = "tbEncryptedData";
            tbEncryptedData.Size = new Size(663, 186);
            tbEncryptedData.TabIndex = 7;
            // 
            // tbDencryptedData
            // 
            tbDencryptedData.Location = new Point(62, 627);
            tbDencryptedData.Multiline = true;
            tbDencryptedData.Name = "tbDencryptedData";
            tbDencryptedData.Size = new Size(663, 306);
            tbDencryptedData.TabIndex = 8;
            // 
            // tbShift
            // 
            tbShift.Location = new Point(62, 89);
            tbShift.Name = "tbShift";
            tbShift.Size = new Size(125, 27);
            tbShift.TabIndex = 9;
            // 
            // btn_start
            // 
            btn_start.Location = new Point(597, 28);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(94, 29);
            btn_start.TabIndex = 10;
            btn_start.Text = "START ";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // btn_stop
            // 
            btn_stop.Location = new Point(697, 28);
            btn_stop.Name = "btn_stop";
            btn_stop.Size = new Size(94, 29);
            btn_stop.TabIndex = 11;
            btn_stop.Text = "STOP";
            btn_stop.UseVisualStyleBackColor = true;
            btn_stop.Click += btn_stop_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(497, 32);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 12;
            label5.Text = "BRUTE FORCE";
            // 
            // tbCurrentKey
            // 
            tbCurrentKey.Location = new Point(666, 66);
            tbCurrentKey.Name = "tbCurrentKey";
            tbCurrentKey.Size = new Size(125, 27);
            tbCurrentKey.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(526, 73);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 14;
            label6.Text = "CURRENT KEY: ";
            // 
            // tbDelay
            // 
            tbDelay.Location = new Point(666, 108);
            tbDelay.Name = "tbDelay";
            tbDelay.Size = new Size(125, 27);
            tbDelay.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(526, 104);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 16;
            label7.Text = "DELAY:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 1046);
            Controls.Add(label7);
            Controls.Add(tbDelay);
            Controls.Add(label6);
            Controls.Add(tbCurrentKey);
            Controls.Add(label5);
            Controls.Add(btn_stop);
            Controls.Add(btn_start);
            Controls.Add(tbShift);
            Controls.Add(tbDencryptedData);
            Controls.Add(tbEncryptedData);
            Controls.Add(tbData);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDencrypt);
            Controls.Add(btnEncrypt);
            Name = "Form1";
            Text = "BaiTap1";
            ResumeLayout(false);
            PerformLayout();
        }
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        #endregion

        private Button btn_start;
        private Button btn_stop;
        private Label label5;
        private TextBox tbCurrentKey;
        private Label label6;
        private TextBox tbDelay;
        private Label label7;
    }
}
