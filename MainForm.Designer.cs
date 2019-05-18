namespace WindowsFormsApplication2
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.exitPanel = new System.Windows.Forms.Panel();
            this.exitButton = new ns1.BunifuFlatButton();
            this.bunifuFlatButton17 = new ns1.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new ns1.BunifuFlatButton();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.Dropdown1 = new ns1.BunifuDropdown();
            this.bunifuTileButton1 = new ns1.BunifuTileButton();
            this.bunifuTileButton2 = new ns1.BunifuTileButton();
            this.bunifuTileButton3 = new ns1.BunifuTileButton();
            this.bunifuTileButton4 = new ns1.BunifuTileButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton3 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton4 = new ns1.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.bunifuFlatButton5 = new ns1.BunifuFlatButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ButtonVk = new ns1.BunifuTileButton();
            this.ButtonDc = new ns1.BunifuTileButton();
            this.bunifuTileButton5 = new ns1.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.exitPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(559, 877);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(695, 26);
            this.textBox1.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Brown;
            this.button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button.BackgroundImage")));
            this.button.Cursor = System.Windows.Forms.Cursors.No;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button.Location = new System.Drawing.Point(1152, 867);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(170, 85);
            this.button.TabIndex = 3;
            this.button.Text = "Отправить";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.butt_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // exitPanel
            // 
            this.exitPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exitPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.exitPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitPanel.BackgroundImage")));
            this.exitPanel.Controls.Add(this.exitButton);
            this.exitPanel.Controls.Add(this.bunifuFlatButton17);
            this.exitPanel.Controls.Add(this.panel3);
            this.exitPanel.Controls.Add(this.bunifuFlatButton2);
            this.exitPanel.Location = new System.Drawing.Point(-339, 0);
            this.exitPanel.Name = "exitPanel";
            this.exitPanel.Size = new System.Drawing.Size(2259, 20);
            this.exitPanel.TabIndex = 6;
            this.exitPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.exitPanel_Paint);
            // 
            // exitButton
            // 
            this.exitButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.exitButton.BackColor = System.Drawing.Color.Firebrick;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.BorderRadius = 0;
            this.exitButton.ButtonText = "          X";
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.DisabledColor = System.Drawing.Color.Gray;
            this.exitButton.Iconcolor = System.Drawing.Color.Transparent;
            this.exitButton.Iconimage = null;
            this.exitButton.Iconimage_right = null;
            this.exitButton.Iconimage_right_Selected = null;
            this.exitButton.Iconimage_Selected = null;
            this.exitButton.IconMarginLeft = 0;
            this.exitButton.IconMarginRight = 0;
            this.exitButton.IconRightVisible = true;
            this.exitButton.IconRightZoom = 0D;
            this.exitButton.IconVisible = true;
            this.exitButton.IconZoom = 90D;
            this.exitButton.IsTab = false;
            this.exitButton.Location = new System.Drawing.Point(1585, -2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Normalcolor = System.Drawing.Color.Firebrick;
            this.exitButton.OnHovercolor = System.Drawing.Color.DarkRed;
            this.exitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.exitButton.selected = false;
            this.exitButton.Size = new System.Drawing.Size(53, 22);
            this.exitButton.TabIndex = 40;
            this.exitButton.Text = "          X";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Textcolor = System.Drawing.Color.White;
            this.exitButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Click += new System.EventHandler(this.bunifuFlatButton6_Click_1);
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
            this.bunifuFlatButton17.Location = new System.Drawing.Point(1894, 0);
            this.bunifuFlatButton17.Name = "bunifuFlatButton17";
            this.bunifuFlatButton17.Normalcolor = System.Drawing.Color.Firebrick;
            this.bunifuFlatButton17.OnHovercolor = System.Drawing.Color.DarkRed;
            this.bunifuFlatButton17.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton17.selected = false;
            this.bunifuFlatButton17.Size = new System.Drawing.Size(55, 20);
            this.bunifuFlatButton17.TabIndex = 39;
            this.bunifuFlatButton17.Text = "          X";
            this.bunifuFlatButton17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton17.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton17.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton17.Click += new System.EventHandler(this.bunifuFlatButton17_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(105, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(820, 538);
            this.panel3.TabIndex = 8;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "X";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Right;
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(2198, 0);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(61, 20);
            this.bunifuFlatButton2.TabIndex = 0;
            this.bunifuFlatButton2.Text = "X";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // Dropdown1
            // 
            this.Dropdown1.BackColor = System.Drawing.Color.Transparent;
            this.Dropdown1.BorderRadius = 3;
            this.Dropdown1.ForeColor = System.Drawing.Color.White;
            this.Dropdown1.Items = new string[] {
        "rlica",
        "sdfsdf",
        "sdfs"};
            this.Dropdown1.Location = new System.Drawing.Point(1057, 84);
            this.Dropdown1.Name = "Dropdown1";
            this.Dropdown1.NomalColor = System.Drawing.Color.Red;
            this.Dropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Dropdown1.selectedIndex = -1;
            this.Dropdown1.Size = new System.Drawing.Size(217, 35);
            this.Dropdown1.TabIndex = 9;
            this.Dropdown1.onItemSelected += new System.EventHandler(this.Dropdown1_onItemSelected);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 14;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 29;
            this.bunifuTileButton1.LabelText = "Калькулятор";
            this.bunifuTileButton1.Location = new System.Drawing.Point(651, 237);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(271, 183);
            this.bunifuTileButton1.TabIndex = 10;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton2.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
            this.bunifuTileButton2.ImagePosition = 14;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 29;
            this.bunifuTileButton2.LabelText = "Галерея";
            this.bunifuTileButton2.Location = new System.Drawing.Point(148, 40);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(238, 182);
            this.bunifuTileButton2.TabIndex = 11;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton3.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton3.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton3.Image")));
            this.bunifuTileButton3.ImagePosition = 14;
            this.bunifuTileButton3.ImageZoom = 50;
            this.bunifuTileButton3.LabelPosition = 29;
            this.bunifuTileButton3.LabelText = "Браузер";
            this.bunifuTileButton3.Location = new System.Drawing.Point(148, 250);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(238, 182);
            this.bunifuTileButton3.TabIndex = 12;
            this.bunifuTileButton3.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // bunifuTileButton4
            // 
            this.bunifuTileButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton4.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton4.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTileButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton4.Image")));
            this.bunifuTileButton4.ImagePosition = 14;
            this.bunifuTileButton4.ImageZoom = 50;
            this.bunifuTileButton4.LabelPosition = 29;
            this.bunifuTileButton4.LabelText = "Заметки";
            this.bunifuTileButton4.Location = new System.Drawing.Point(402, 30);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(238, 195);
            this.bunifuTileButton4.TabIndex = 13;
            this.bunifuTileButton4.Click += new System.EventHandler(this.bunifuTileButton4_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Britannic Bold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 23;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 80D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 115);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Red;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(117, 79);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Britannic Bold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 25;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 80D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 43);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.Red;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(120, 76);
            this.bunifuFlatButton3.TabIndex = 1;
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Font = new System.Drawing.Font("Britannic Bold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 35;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 81D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(-82, 210);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.Red;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(130, 81);
            this.bunifuFlatButton4.TabIndex = 9;
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(127)))), ((int)(((byte)(139)))));
            this.label1.Location = new System.Drawing.Point(-4, 1016);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "0000000";
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuPanel.BackgroundImage")));
            this.menuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuPanel.Controls.Add(this.bunifuFlatButton5);
            this.menuPanel.Controls.Add(this.label1);
            this.menuPanel.Controls.Add(this.bunifuFlatButton4);
            this.menuPanel.Controls.Add(this.bunifuFlatButton3);
            this.menuPanel.Controls.Add(this.bunifuFlatButton1);
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(120, 1148);
            this.menuPanel.TabIndex = 7;
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Font = new System.Drawing.Font("Britannic Bold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 25;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 95D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(3, 743);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.Red;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(114, 71);
            this.bunifuFlatButton5.TabIndex = 11;
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.richTextBox1.Location = new System.Drawing.Point(242, 125);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(973, 672);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // ButtonVk
            // 
            this.ButtonVk.BackColor = System.Drawing.Color.Transparent;
            this.ButtonVk.color = System.Drawing.Color.Transparent;
            this.ButtonVk.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.ButtonVk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonVk.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonVk.ForeColor = System.Drawing.Color.White;
            this.ButtonVk.Image = ((System.Drawing.Image)(resources.GetObject("ButtonVk.Image")));
            this.ButtonVk.ImagePosition = 14;
            this.ButtonVk.ImageZoom = 50;
            this.ButtonVk.LabelPosition = 29;
            this.ButtonVk.LabelText = "ВКонтакте";
            this.ButtonVk.Location = new System.Drawing.Point(402, 250);
            this.ButtonVk.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ButtonVk.Name = "ButtonVk";
            this.ButtonVk.Size = new System.Drawing.Size(238, 182);
            this.ButtonVk.TabIndex = 14;
            this.ButtonVk.Click += new System.EventHandler(this.ButtonVk_Click);
            // 
            // ButtonDc
            // 
            this.ButtonDc.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDc.color = System.Drawing.Color.Transparent;
            this.ButtonDc.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.ButtonDc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDc.ForeColor = System.Drawing.Color.White;
            this.ButtonDc.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDc.Image")));
            this.ButtonDc.ImagePosition = 14;
            this.ButtonDc.ImageZoom = 50;
            this.ButtonDc.LabelPosition = 29;
            this.ButtonDc.LabelText = "Discord";
            this.ButtonDc.Location = new System.Drawing.Point(656, 250);
            this.ButtonDc.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ButtonDc.Name = "ButtonDc";
            this.ButtonDc.Size = new System.Drawing.Size(238, 182);
            this.ButtonDc.TabIndex = 15;
            this.ButtonDc.Click += new System.EventHandler(this.ButtonDc_Click);
            // 
            // bunifuTileButton5
            // 
            this.bunifuTileButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton5.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton5.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.bunifuTileButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTileButton5.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton5.Image")));
            this.bunifuTileButton5.ImagePosition = 14;
            this.bunifuTileButton5.ImageZoom = 50;
            this.bunifuTileButton5.LabelPosition = 29;
            this.bunifuTileButton5.LabelText = "РИСОВАЛКА";
            this.bunifuTileButton5.Location = new System.Drawing.Point(656, 40);
            this.bunifuTileButton5.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuTileButton5.Name = "bunifuTileButton5";
            this.bunifuTileButton5.Size = new System.Drawing.Size(238, 182);
            this.bunifuTileButton5.TabIndex = 16;
            this.bunifuTileButton5.Click += new System.EventHandler(this.bunifuTileButton5_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1300, 1044);
            this.Controls.Add(this.bunifuTileButton5);
            this.Controls.Add(this.exitPanel);
            this.Controls.Add(this.ButtonDc);
            this.Controls.Add(this.ButtonVk);
            this.Controls.Add(this.bunifuTileButton4);
            this.Controls.Add(this.bunifuTileButton3);
            this.Controls.Add(this.bunifuTileButton2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.Dropdown1);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "kla$$";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.exitPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Panel exitPanel;
        private ns1.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panel3;
        private ns1.BunifuDropdown Dropdown1;
        private ns1.BunifuTileButton bunifuTileButton1;
        private ns1.BunifuTileButton bunifuTileButton2;
        private ns1.BunifuTileButton bunifuTileButton3;
        private ns1.BunifuTileButton bunifuTileButton4;
        private System.Windows.Forms.Timer timer1;
        private ns1.BunifuFlatButton bunifuFlatButton3;
        private ns1.BunifuFlatButton bunifuFlatButton4;
        private ns1.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private ns1.BunifuTileButton ButtonVk;
        private ns1.BunifuTileButton ButtonDc;
        private ns1.BunifuFlatButton bunifuFlatButton5;
        private ns1.BunifuFlatButton bunifuFlatButton17;
        private ns1.BunifuTileButton bunifuTileButton5;
        private ns1.BunifuFlatButton exitButton;
    }
}

