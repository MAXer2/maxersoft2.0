namespace WindowsFormsApplication2
{
    partial class CalculatorForm
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
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.bunifuFlatButton7 = new ns1.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton8 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton10 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton11 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton4 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton5 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton9 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton2 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton3 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton6 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton12 = new ns1.BunifuFlatButton();
            this.ravnoButton = new ns1.BunifuFlatButton();
            this.bunifuFlatButton14 = new ns1.BunifuFlatButton();
            this.umnojitButton = new ns1.BunifuFlatButton();
            this.bunifuFlatButton16 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton17 = new ns1.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "/";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = null;
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 90D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(363, 259);
            this.bunifuFlatButton7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(76, 85);
            this.bunifuFlatButton7.TabIndex = 6;
            this.bunifuFlatButton7.Text = "/";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton7.Click += new System.EventHandler(this.bunifuFlatButton7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.resultLabel);
            this.panel1.Location = new System.Drawing.Point(21, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 100);
            this.panel1.TabIndex = 18;
            // 
            // resultLabel
            // 
            this.resultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(0, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(389, 100);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "0";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resultLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "9";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(193, 168);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(76, 85);
            this.bunifuFlatButton1.TabIndex = 19;
            this.bunifuFlatButton1.Text = "9";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton10_Click);
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 0;
            this.bunifuFlatButton8.ButtonText = "8";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = null;
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = true;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = true;
            this.bunifuFlatButton8.IconZoom = 90D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(111, 168);
            this.bunifuFlatButton8.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(76, 85);
            this.bunifuFlatButton8.TabIndex = 20;
            this.bunifuFlatButton8.Text = "8";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton8.Click += new System.EventHandler(this.bunifuFlatButton10_Click);
            // 
            // bunifuFlatButton10
            // 
            this.bunifuFlatButton10.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.bunifuFlatButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton10.BorderRadius = 0;
            this.bunifuFlatButton10.ButtonText = "7";
            this.bunifuFlatButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton10.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton10.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton10.Iconimage = null;
            this.bunifuFlatButton10.Iconimage_right = null;
            this.bunifuFlatButton10.Iconimage_right_Selected = null;
            this.bunifuFlatButton10.Iconimage_Selected = null;
            this.bunifuFlatButton10.IconMarginLeft = 0;
            this.bunifuFlatButton10.IconMarginRight = 0;
            this.bunifuFlatButton10.IconRightVisible = true;
            this.bunifuFlatButton10.IconRightZoom = 0D;
            this.bunifuFlatButton10.IconVisible = true;
            this.bunifuFlatButton10.IconZoom = 90D;
            this.bunifuFlatButton10.IsTab = false;
            this.bunifuFlatButton10.Location = new System.Drawing.Point(29, 168);
            this.bunifuFlatButton10.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton10.Name = "bunifuFlatButton10";
            this.bunifuFlatButton10.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton10.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.bunifuFlatButton10.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton10.selected = false;
            this.bunifuFlatButton10.Size = new System.Drawing.Size(76, 85);
            this.bunifuFlatButton10.TabIndex = 21;
            this.bunifuFlatButton10.Text = "7";
            this.bunifuFlatButton10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton10.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton10.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton10.Click += new System.EventHandler(this.bunifuFlatButton10_Click);
            // 
            // bunifuFlatButton11
            // 
            this.bunifuFlatButton11.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.bunifuFlatButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton11.BorderRadius = 0;
            this.bunifuFlatButton11.ButtonText = "4";
            this.bunifuFlatButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton11.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton11.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton11.Iconimage = null;
            this.bunifuFlatButton11.Iconimage_right = null;
            this.bunifuFlatButton11.Iconimage_right_Selected = null;
            this.bunifuFlatButton11.Iconimage_Selected = null;
            this.bunifuFlatButton11.IconMarginLeft = 0;
            this.bunifuFlatButton11.IconMarginRight = 0;
            this.bunifuFlatButton11.IconRightVisible = true;
            this.bunifuFlatButton11.IconRightZoom = 0D;
            this.bunifuFlatButton11.IconVisible = true;
            this.bunifuFlatButton11.IconZoom = 90D;
            this.bunifuFlatButton11.IsTab = false;
            this.bunifuFlatButton11.Location = new System.Drawing.Point(29, 259);
            this.bunifuFlatButton11.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton11.Name = "bunifuFlatButton11";
            this.bunifuFlatButton11.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton11.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.bunifuFlatButton11.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton11.selected = false;
            this.bunifuFlatButton11.Size = new System.Drawing.Size(76, 85);
            this.bunifuFlatButton11.TabIndex = 22;
            this.bunifuFlatButton11.Text = "4";
            this.bunifuFlatButton11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton11.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton11.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton11.Click += new System.EventHandler(this.bunifuFlatButton10_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "5";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(111, 259);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(76, 85);
            this.bunifuFlatButton4.TabIndex = 23;
            this.bunifuFlatButton4.Text = "5";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton10_Click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "6";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = null;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(194, 259);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(76, 85);
            this.bunifuFlatButton5.TabIndex = 24;
            this.bunifuFlatButton5.Text = "6";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton10_Click);
            // 
            // bunifuFlatButton9
            // 
            this.bunifuFlatButton9.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.bunifuFlatButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton9.BorderRadius = 0;
            this.bunifuFlatButton9.ButtonText = "-";
            this.bunifuFlatButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton9.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton9.Iconimage = null;
            this.bunifuFlatButton9.Iconimage_right = null;
            this.bunifuFlatButton9.Iconimage_right_Selected = null;
            this.bunifuFlatButton9.Iconimage_Selected = null;
            this.bunifuFlatButton9.IconMarginLeft = 0;
            this.bunifuFlatButton9.IconMarginRight = 0;
            this.bunifuFlatButton9.IconRightVisible = true;
            this.bunifuFlatButton9.IconRightZoom = 0D;
            this.bunifuFlatButton9.IconVisible = true;
            this.bunifuFlatButton9.IconZoom = 90D;
            this.bunifuFlatButton9.IsTab = false;
            this.bunifuFlatButton9.Location = new System.Drawing.Point(275, 350);
            this.bunifuFlatButton9.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton9.Name = "bunifuFlatButton9";
            this.bunifuFlatButton9.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton9.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.bunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton9.selected = false;
            this.bunifuFlatButton9.Size = new System.Drawing.Size(76, 85);
            this.bunifuFlatButton9.TabIndex = 25;
            this.bunifuFlatButton9.Text = "-";
            this.bunifuFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton9.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton9.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton9.Click += new System.EventHandler(this.bunifuFlatButton9_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "+";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(363, 350);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(76, 85);
            this.bunifuFlatButton2.TabIndex = 26;
            this.bunifuFlatButton2.Text = "+";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click_1);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "3";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(193, 350);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(76, 85);
            this.bunifuFlatButton3.TabIndex = 27;
            this.bunifuFlatButton3.Text = "3";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton10_Click);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "2";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = null;
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 90D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(111, 350);
            this.bunifuFlatButton6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(76, 85);
            this.bunifuFlatButton6.TabIndex = 28;
            this.bunifuFlatButton6.Text = "2";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton6.Click += new System.EventHandler(this.bunifuFlatButton10_Click);
            // 
            // bunifuFlatButton12
            // 
            this.bunifuFlatButton12.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.bunifuFlatButton12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton12.BorderRadius = 0;
            this.bunifuFlatButton12.ButtonText = "1";
            this.bunifuFlatButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton12.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton12.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton12.Iconimage = null;
            this.bunifuFlatButton12.Iconimage_right = null;
            this.bunifuFlatButton12.Iconimage_right_Selected = null;
            this.bunifuFlatButton12.Iconimage_Selected = null;
            this.bunifuFlatButton12.IconMarginLeft = 0;
            this.bunifuFlatButton12.IconMarginRight = 0;
            this.bunifuFlatButton12.IconRightVisible = true;
            this.bunifuFlatButton12.IconRightZoom = 0D;
            this.bunifuFlatButton12.IconVisible = true;
            this.bunifuFlatButton12.IconZoom = 90D;
            this.bunifuFlatButton12.IsTab = false;
            this.bunifuFlatButton12.Location = new System.Drawing.Point(29, 350);
            this.bunifuFlatButton12.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton12.Name = "bunifuFlatButton12";
            this.bunifuFlatButton12.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton12.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.bunifuFlatButton12.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton12.selected = false;
            this.bunifuFlatButton12.Size = new System.Drawing.Size(76, 85);
            this.bunifuFlatButton12.TabIndex = 29;
            this.bunifuFlatButton12.Text = "1";
            this.bunifuFlatButton12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton12.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton12.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton12.Click += new System.EventHandler(this.bunifuFlatButton10_Click);
            // 
            // ravnoButton
            // 
            this.ravnoButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.ravnoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.ravnoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ravnoButton.BorderRadius = 0;
            this.ravnoButton.ButtonText = "=";
            this.ravnoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ravnoButton.DisabledColor = System.Drawing.Color.Gray;
            this.ravnoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ravnoButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ravnoButton.Iconimage = null;
            this.ravnoButton.Iconimage_right = null;
            this.ravnoButton.Iconimage_right_Selected = null;
            this.ravnoButton.Iconimage_Selected = null;
            this.ravnoButton.IconMarginLeft = 0;
            this.ravnoButton.IconMarginRight = 0;
            this.ravnoButton.IconRightVisible = true;
            this.ravnoButton.IconRightZoom = 0D;
            this.ravnoButton.IconVisible = true;
            this.ravnoButton.IconZoom = 90D;
            this.ravnoButton.IsTab = false;
            this.ravnoButton.Location = new System.Drawing.Point(275, 441);
            this.ravnoButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ravnoButton.Name = "ravnoButton";
            this.ravnoButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.ravnoButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.ravnoButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ravnoButton.selected = false;
            this.ravnoButton.Size = new System.Drawing.Size(162, 85);
            this.ravnoButton.TabIndex = 30;
            this.ravnoButton.Text = "=";
            this.ravnoButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ravnoButton.Textcolor = System.Drawing.Color.White;
            this.ravnoButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ravnoButton.Click += new System.EventHandler(this.ravnoButton_Click);
            // 
            // bunifuFlatButton14
            // 
            this.bunifuFlatButton14.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.bunifuFlatButton14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton14.BorderRadius = 0;
            this.bunifuFlatButton14.ButtonText = "0";
            this.bunifuFlatButton14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton14.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton14.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton14.Iconimage = null;
            this.bunifuFlatButton14.Iconimage_right = null;
            this.bunifuFlatButton14.Iconimage_right_Selected = null;
            this.bunifuFlatButton14.Iconimage_Selected = null;
            this.bunifuFlatButton14.IconMarginLeft = 0;
            this.bunifuFlatButton14.IconMarginRight = 0;
            this.bunifuFlatButton14.IconRightVisible = true;
            this.bunifuFlatButton14.IconRightZoom = 0D;
            this.bunifuFlatButton14.IconVisible = true;
            this.bunifuFlatButton14.IconZoom = 90D;
            this.bunifuFlatButton14.IsTab = false;
            this.bunifuFlatButton14.Location = new System.Drawing.Point(34, 441);
            this.bunifuFlatButton14.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton14.Name = "bunifuFlatButton14";
            this.bunifuFlatButton14.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton14.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.bunifuFlatButton14.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton14.selected = false;
            this.bunifuFlatButton14.Size = new System.Drawing.Size(235, 85);
            this.bunifuFlatButton14.TabIndex = 31;
            this.bunifuFlatButton14.Text = "0";
            this.bunifuFlatButton14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton14.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton14.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton14.Click += new System.EventHandler(this.bunifuFlatButton10_Click);
            // 
            // umnojitButton
            // 
            this.umnojitButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.umnojitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.umnojitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.umnojitButton.BorderRadius = 0;
            this.umnojitButton.ButtonText = "*";
            this.umnojitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.umnojitButton.DisabledColor = System.Drawing.Color.Gray;
            this.umnojitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.umnojitButton.Iconcolor = System.Drawing.Color.Transparent;
            this.umnojitButton.Iconimage = null;
            this.umnojitButton.Iconimage_right = null;
            this.umnojitButton.Iconimage_right_Selected = null;
            this.umnojitButton.Iconimage_Selected = null;
            this.umnojitButton.IconMarginLeft = 0;
            this.umnojitButton.IconMarginRight = 0;
            this.umnojitButton.IconRightVisible = true;
            this.umnojitButton.IconRightZoom = 0D;
            this.umnojitButton.IconVisible = true;
            this.umnojitButton.IconZoom = 90D;
            this.umnojitButton.IsTab = false;
            this.umnojitButton.Location = new System.Drawing.Point(275, 259);
            this.umnojitButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.umnojitButton.Name = "umnojitButton";
            this.umnojitButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.umnojitButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.umnojitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.umnojitButton.selected = false;
            this.umnojitButton.Size = new System.Drawing.Size(76, 85);
            this.umnojitButton.TabIndex = 32;
            this.umnojitButton.Text = "*";
            this.umnojitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.umnojitButton.Textcolor = System.Drawing.Color.White;
            this.umnojitButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.umnojitButton.Click += new System.EventHandler(this.umnojitButtonClick);
            // 
            // bunifuFlatButton16
            // 
            this.bunifuFlatButton16.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.bunifuFlatButton16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton16.BorderRadius = 0;
            this.bunifuFlatButton16.ButtonText = "c";
            this.bunifuFlatButton16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton16.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton16.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton16.Iconimage = null;
            this.bunifuFlatButton16.Iconimage_right = null;
            this.bunifuFlatButton16.Iconimage_right_Selected = null;
            this.bunifuFlatButton16.Iconimage_Selected = null;
            this.bunifuFlatButton16.IconMarginLeft = 0;
            this.bunifuFlatButton16.IconMarginRight = 0;
            this.bunifuFlatButton16.IconRightVisible = true;
            this.bunifuFlatButton16.IconRightZoom = 0D;
            this.bunifuFlatButton16.IconVisible = true;
            this.bunifuFlatButton16.IconZoom = 90D;
            this.bunifuFlatButton16.IsTab = false;
            this.bunifuFlatButton16.Location = new System.Drawing.Point(275, 168);
            this.bunifuFlatButton16.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton16.Name = "bunifuFlatButton16";
            this.bunifuFlatButton16.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton16.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.bunifuFlatButton16.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton16.selected = false;
            this.bunifuFlatButton16.Size = new System.Drawing.Size(76, 85);
            this.bunifuFlatButton16.TabIndex = 33;
            this.bunifuFlatButton16.Text = "c";
            this.bunifuFlatButton16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton16.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton16.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton16.Click += new System.EventHandler(this.bunifuFlatButton16_Click);
            // 
            // bunifuFlatButton17
            // 
            this.bunifuFlatButton17.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton17.BackColor = System.Drawing.Color.Firebrick;
            this.bunifuFlatButton17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton17.BorderRadius = 0;
            this.bunifuFlatButton17.ButtonText = "          X";
            this.bunifuFlatButton17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton17.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton17.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton17.Iconimage = null;
            this.bunifuFlatButton17.Iconimage_right = null;
            this.bunifuFlatButton17.Iconimage_right_Selected = null;
            this.bunifuFlatButton17.Iconimage_Selected = null;
            this.bunifuFlatButton17.IconMarginLeft = 0;
            this.bunifuFlatButton17.IconMarginRight = 0;
            this.bunifuFlatButton17.IconRightVisible = true;
            this.bunifuFlatButton17.IconRightZoom = 0D;
            this.bunifuFlatButton17.IconVisible = true;
            this.bunifuFlatButton17.IconZoom = 90D;
            this.bunifuFlatButton17.IsTab = false;
            this.bunifuFlatButton17.Location = new System.Drawing.Point(387, 7);
            this.bunifuFlatButton17.Name = "bunifuFlatButton17";
            this.bunifuFlatButton17.Normalcolor = System.Drawing.Color.Firebrick;
            this.bunifuFlatButton17.OnHovercolor = System.Drawing.Color.DarkRed;
            this.bunifuFlatButton17.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton17.selected = false;
            this.bunifuFlatButton17.Size = new System.Drawing.Size(62, 32);
            this.bunifuFlatButton17.TabIndex = 34;
            this.bunifuFlatButton17.Text = "          X";
            this.bunifuFlatButton17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton17.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton17.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton17.Click += new System.EventHandler(this.bunifuFlatButton17_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(452, 550);
            this.Controls.Add(this.bunifuFlatButton17);
            this.Controls.Add(this.bunifuFlatButton16);
            this.Controls.Add(this.umnojitButton);
            this.Controls.Add(this.bunifuFlatButton14);
            this.Controls.Add(this.ravnoButton);
            this.Controls.Add(this.bunifuFlatButton12);
            this.Controls.Add(this.bunifuFlatButton6);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.bunifuFlatButton9);
            this.Controls.Add(this.bunifuFlatButton5);
            this.Controls.Add(this.bunifuFlatButton4);
            this.Controls.Add(this.bunifuFlatButton11);
            this.Controls.Add(this.bunifuFlatButton10);
            this.Controls.Add(this.bunifuFlatButton8);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuFlatButton7);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalculatorForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.SystemColors.ButtonFace;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ServiceProcess.ServiceController serviceController1;
        private ns1.BunifuFlatButton bunifuFlatButton7;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuFlatButton bunifuFlatButton1;
        private ns1.BunifuFlatButton bunifuFlatButton8;
        private ns1.BunifuFlatButton bunifuFlatButton10;
        private ns1.BunifuFlatButton bunifuFlatButton11;
        private ns1.BunifuFlatButton bunifuFlatButton4;
        private ns1.BunifuFlatButton bunifuFlatButton5;
        private ns1.BunifuFlatButton bunifuFlatButton9;
        private ns1.BunifuFlatButton bunifuFlatButton2;
        private ns1.BunifuFlatButton bunifuFlatButton3;
        private ns1.BunifuFlatButton bunifuFlatButton6;
        private ns1.BunifuFlatButton bunifuFlatButton12;
        private ns1.BunifuFlatButton ravnoButton;
        private ns1.BunifuFlatButton bunifuFlatButton14;
        private System.Windows.Forms.Label resultLabel;
        private ns1.BunifuFlatButton umnojitButton;
        private ns1.BunifuFlatButton bunifuFlatButton16;
        private ns1.BunifuFlatButton bunifuFlatButton17;
    }
}