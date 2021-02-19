namespace Assginment1_YiTan
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pointX = new System.Windows.Forms.TextBox();
            this.pointY = new System.Windows.Forms.TextBox();
            this.numOfRd = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nonInteligentBtn = new System.Windows.Forms.RadioButton();
            this.smartBtn = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input a starting point : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Input the number of times you would like to run: ";
            // 
            // pointX
            // 
            this.pointX.Location = new System.Drawing.Point(113, 225);
            this.pointX.Name = "pointX";
            this.pointX.Size = new System.Drawing.Size(44, 22);
            this.pointX.TabIndex = 5;
            this.pointX.Text = "0";

            // 
            // pointY
            // 
            this.pointY.Location = new System.Drawing.Point(113, 260);
            this.pointY.Name = "pointY";
            this.pointY.Size = new System.Drawing.Size(44, 22);
            this.pointY.TabIndex = 6;
            this.pointY.Text = "0";
            this.pointY.UseWaitCursor = true;

            // 
            // numOfRd
            // 
            this.numOfRd.Location = new System.Drawing.Point(18, 332);
            this.numOfRd.Name = "numOfRd";
            this.numOfRd.Size = new System.Drawing.Size(100, 22);
            this.numOfRd.TabIndex = 7;

            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(18, 379);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(110, 47);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.smartBtn);
            this.groupBox1.Controls.Add(this.nonInteligentBtn);
            this.groupBox1.Location = new System.Drawing.Point(18, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 72);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a version";

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "(X, Y : any integer  >=0 or <=7)";
            // 
            // nonInteligentBtn
            // 
            this.nonInteligentBtn.AutoSize = true;
            this.nonInteligentBtn.Location = new System.Drawing.Point(6, 35);
            this.nonInteligentBtn.Name = "nonInteligentBtn";
            this.nonInteligentBtn.Size = new System.Drawing.Size(172, 21);
            this.nonInteligentBtn.TabIndex = 0;
            this.nonInteligentBtn.TabStop = true;
            this.nonInteligentBtn.Text = "Non-Intelligent Version";
            this.nonInteligentBtn.UseVisualStyleBackColor = true;
            // 
            // smartBtn
            // 
            this.smartBtn.AutoSize = true;
            this.smartBtn.Location = new System.Drawing.Point(219, 35);
            this.smartBtn.Name = "smartBtn";
            this.smartBtn.Size = new System.Drawing.Size(118, 21);
            this.smartBtn.TabIndex = 1;
            this.smartBtn.TabStop = true;
            this.smartBtn.Text = "Smart Version";
            this.smartBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 185);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 0);
            this.textBox1.TabIndex = 12;
            // 
            // resultBox
            // 
            this.resultBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.resultBox.Location = new System.Drawing.Point(411, 111);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(340, 295);
            this.resultBox.TabIndex = 13;
            this.resultBox.Text = "show result...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "X:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = global::Assginment1_YiTan.Properties.Resources.Knight_s_Tour;
            this.pictureBox1.Location = new System.Drawing.Point(193, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Book Antiqua", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(287, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(291, 54);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "Knight\'s Tour";
          
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.numOfRd);
            this.Controls.Add(this.pointY);
            this.Controls.Add(this.pointX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pointX;
        private System.Windows.Forms.TextBox pointY;
        private System.Windows.Forms.TextBox numOfRd;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton smartBtn;
        private System.Windows.Forms.RadioButton nonInteligentBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

