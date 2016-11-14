namespace bt
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PicHour = new System.Windows.Forms.PictureBox();
            this.PicMin = new System.Windows.Forms.PictureBox();
            this.TxtHour = new System.Windows.Forms.TextBox();
            this.TxtMin = new System.Windows.Forms.TextBox();
            this.BtnSendHour = new System.Windows.Forms.Button();
            this.BtnSendMin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMin)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(47, 352);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(310, 352);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(218, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Baglan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Baglantı Kes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PicHour
            // 
            this.PicHour.Image = global::bt.Properties.Resources._default;
            this.PicHour.Location = new System.Drawing.Point(47, 46);
            this.PicHour.Name = "PicHour";
            this.PicHour.Size = new System.Drawing.Size(218, 207);
            this.PicHour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicHour.TabIndex = 6;
            this.PicHour.TabStop = false;
            // 
            // PicMin
            // 
            this.PicMin.Image = global::bt.Properties.Resources._default;
            this.PicMin.Location = new System.Drawing.Point(310, 46);
            this.PicMin.Name = "PicMin";
            this.PicMin.Size = new System.Drawing.Size(218, 207);
            this.PicMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicMin.TabIndex = 7;
            this.PicMin.TabStop = false;
            // 
            // TxtHour
            // 
            this.TxtHour.Location = new System.Drawing.Point(47, 271);
            this.TxtHour.Name = "TxtHour";
            this.TxtHour.Size = new System.Drawing.Size(218, 20);
            this.TxtHour.TabIndex = 8;
            // 
            // TxtMin
            // 
            this.TxtMin.Location = new System.Drawing.Point(310, 271);
            this.TxtMin.Name = "TxtMin";
            this.TxtMin.Size = new System.Drawing.Size(218, 20);
            this.TxtMin.TabIndex = 9;
            // 
            // BtnSendHour
            // 
            this.BtnSendHour.Location = new System.Drawing.Point(47, 298);
            this.BtnSendHour.Name = "BtnSendHour";
            this.BtnSendHour.Size = new System.Drawing.Size(75, 23);
            this.BtnSendHour.TabIndex = 10;
            this.BtnSendHour.Text = "Send";
            this.BtnSendHour.UseVisualStyleBackColor = true;
            this.BtnSendHour.Click += new System.EventHandler(this.BtnSendHour_Click);
            // 
            // BtnSendMin
            // 
            this.BtnSendMin.Location = new System.Drawing.Point(310, 298);
            this.BtnSendMin.Name = "BtnSendMin";
            this.BtnSendMin.Size = new System.Drawing.Size(75, 23);
            this.BtnSendMin.TabIndex = 11;
            this.BtnSendMin.Text = "Send";
            this.BtnSendMin.UseVisualStyleBackColor = true;
            this.BtnSendMin.Click += new System.EventHandler(this.BtnSendMin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 478);
            this.Controls.Add(this.BtnSendMin);
            this.Controls.Add(this.BtnSendHour);
            this.Controls.Add(this.TxtMin);
            this.Controls.Add(this.TxtHour);
            this.Controls.Add(this.PicMin);
            this.Controls.Add(this.PicHour);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox PicHour;
        private System.Windows.Forms.PictureBox PicMin;
        private System.Windows.Forms.TextBox TxtHour;
        private System.Windows.Forms.TextBox TxtMin;
        private System.Windows.Forms.Button BtnSendHour;
        private System.Windows.Forms.Button BtnSendMin;
    }
}

