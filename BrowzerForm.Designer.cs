namespace WindowsFormsApplication2
{
    partial class Form7
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.webBrowser4 = new System.Windows.Forms.WebBrowser();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button3 = new System.Windows.Forms.Button();
            this.webBrowser5 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 73);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1272, 788);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(1346, 294);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(413, 606);
            this.webBrowser2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 898);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "1-2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser3
            // 
            this.webBrowser3.Location = new System.Drawing.Point(1333, 38);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(480, 261);
            this.webBrowser3.TabIndex = 3;
            this.webBrowser3.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser3_DocumentCompleted);
            // 
            // webBrowser4
            // 
            this.webBrowser4.Location = new System.Drawing.Point(12, 109);
            this.webBrowser4.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser4.Name = "webBrowser4";
            this.webBrowser4.Size = new System.Drawing.Size(1272, 747);
            this.webBrowser4.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 898);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "2 - 1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Location = new System.Drawing.Point(1322, 962);
            this.trackBar1.Maximum = 350;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(547, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 939);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 42);
            this.button3.TabIndex = 7;
            this.button3.Text = "добавить окно";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // webBrowser5
            // 
            this.webBrowser5.Location = new System.Drawing.Point(1302, 143);
            this.webBrowser5.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser5.Name = "webBrowser5";
            this.webBrowser5.Size = new System.Drawing.Size(577, 570);
            this.webBrowser5.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(621, 934);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 73);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.webBrowser3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.webBrowser4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.WebBrowser webBrowser4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.WebBrowser webBrowser5;
        private System.Windows.Forms.Label label1;
    }
}