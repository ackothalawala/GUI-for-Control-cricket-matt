namespace CricketGui
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.LR = new System.Windows.Forms.TrackBar();
            this.Reset = new System.Windows.Forms.Button();
            this.textBoxLR = new System.Windows.Forms.TextBox();
            this.ServoAngleLR = new System.Windows.Forms.Button();
            this.FB = new System.Windows.Forms.TrackBar();
            this.textBoxFB = new System.Windows.Forms.TextBox();
            this.ServoAngleFB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxPort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM7";
            // 
            // LR
            // 
            this.LR.BackColor = System.Drawing.Color.Ivory;
            this.LR.Location = new System.Drawing.Point(17, 37);
            this.LR.Maximum = 180;
            this.LR.Name = "LR";
            this.LR.Size = new System.Drawing.Size(486, 45);
            this.LR.TabIndex = 1;
            this.LR.Scroll += new System.EventHandler(this.LR_Scroll);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Maroon;
            this.Reset.ForeColor = System.Drawing.Color.Snow;
            this.Reset.Location = new System.Drawing.Point(874, 85);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(158, 144);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // textBoxLR
            // 
            this.textBoxLR.BackColor = System.Drawing.Color.Lavender;
            this.textBoxLR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLR.ForeColor = System.Drawing.Color.Red;
            this.textBoxLR.Location = new System.Drawing.Point(195, 111);
            this.textBoxLR.Name = "textBoxLR";
            this.textBoxLR.Size = new System.Drawing.Size(100, 26);
            this.textBoxLR.TabIndex = 5;
            this.textBoxLR.TextChanged += new System.EventHandler(this.textBoxLR_TextChanged);
            // 
            // ServoAngleLR
            // 
            this.ServoAngleLR.BackColor = System.Drawing.Color.Snow;
            this.ServoAngleLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServoAngleLR.ForeColor = System.Drawing.Color.Green;
            this.ServoAngleLR.Location = new System.Drawing.Point(326, 106);
            this.ServoAngleLR.Name = "ServoAngleLR";
            this.ServoAngleLR.Size = new System.Drawing.Size(100, 37);
            this.ServoAngleLR.TabIndex = 7;
            this.ServoAngleLR.Text = "Send Angle ";
            this.ServoAngleLR.UseVisualStyleBackColor = false;
            this.ServoAngleLR.Click += new System.EventHandler(this.ServoAngleLR_Click);
            // 
            // FB
            // 
            this.FB.BackColor = System.Drawing.Color.Ivory;
            this.FB.Location = new System.Drawing.Point(13, 32);
            this.FB.Maximum = 180;
            this.FB.Name = "FB";
            this.FB.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.FB.Size = new System.Drawing.Size(45, 486);
            this.FB.TabIndex = 2;
            this.FB.Scroll += new System.EventHandler(this.FB_Scroll);
            // 
            // textBoxFB
            // 
            this.textBoxFB.BackColor = System.Drawing.Color.Lavender;
            this.textBoxFB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFB.ForeColor = System.Drawing.Color.Red;
            this.textBoxFB.Location = new System.Drawing.Point(102, 272);
            this.textBoxFB.Name = "textBoxFB";
            this.textBoxFB.Size = new System.Drawing.Size(100, 26);
            this.textBoxFB.TabIndex = 4;
            this.textBoxFB.TextChanged += new System.EventHandler(this.textBoxFB_TextChanged);
            // 
            // ServoAngleFB
            // 
            this.ServoAngleFB.BackColor = System.Drawing.Color.Snow;
            this.ServoAngleFB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServoAngleFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServoAngleFB.ForeColor = System.Drawing.Color.DarkGreen;
            this.ServoAngleFB.Location = new System.Drawing.Point(102, 320);
            this.ServoAngleFB.Margin = new System.Windows.Forms.Padding(5);
            this.ServoAngleFB.Name = "ServoAngleFB";
            this.ServoAngleFB.Size = new System.Drawing.Size(100, 37);
            this.ServoAngleFB.TabIndex = 6;
            this.ServoAngleFB.Text = "Send Value";
            this.ServoAngleFB.UseVisualStyleBackColor = false;
            this.ServoAngleFB.Click += new System.EventHandler(this.ServoAngleFB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(75, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Input Angle Value";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(13, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Input Angle Value";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.FB);
            this.groupBox1.Controls.Add(this.ServoAngleFB);
            this.groupBox1.Controls.Add(this.textBoxFB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(57, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(246, 531);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Front and Back ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox2.Controls.Add(this.LR);
            this.groupBox2.Controls.Add(this.ServoAngleLR);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxLR);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(315, 438);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(532, 161);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Left and Right";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cBoxPort);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(315, 73);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox3.Size = new System.Drawing.Size(257, 129);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "COM Port Select";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Braud Rate";
            // 
            // cBoxPort
            // 
            this.cBoxPort.FormattingEnabled = true;
            this.cBoxPort.Location = new System.Drawing.Point(101, 35);
            this.cBoxPort.Name = "cBoxPort";
            this.cBoxPort.Size = new System.Drawing.Size(121, 28);
            this.cBoxPort.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "COM Port";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 26);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1044, 623);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Reset);
            this.Name = "Form1";
            this.Text = "Arduino Graphical User Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TrackBar LR;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox textBoxLR;
        private System.Windows.Forms.Button ServoAngleLR;
        private System.Windows.Forms.TrackBar FB;
        private System.Windows.Forms.TextBox textBoxFB;
        private System.Windows.Forms.Button ServoAngleFB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

