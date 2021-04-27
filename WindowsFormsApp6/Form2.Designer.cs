namespace WindowsFormsApp6
{
    partial class Form2
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.nameb = new Guna.UI2.WinForms.Guna2TextBox();
            this.date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.surnb = new Guna.UI2.WinForms.Guna2TextBox();
            this.regb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.streetn = new Guna.UI2.WinForms.Guna2TextBox();
            this.Housen = new Guna.UI2.WinForms.Guna2TextBox();
            this.town = new Guna.UI2.WinForms.Guna2TextBox();
            this.postcode = new Guna.UI2.WinForms.Guna2TextBox();
            this.county = new Guna.UI2.WinForms.Guna2TextBox();
            this.itemname1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.vat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.price = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.itemname2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.url = new Guna.UI2.WinForms.Guna2TextBox();
            this.currency = new Guna.UI2.WinForms.Guna2ComboBox();
            this.quan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pb1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.webBrowser1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(311, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(595, 841);
            this.guna2Panel1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(595, 841);
            this.webBrowser1.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(53, 759);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Generate";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // nameb
            // 
            this.nameb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameb.DefaultText = "name";
            this.nameb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameb.DisabledState.Parent = this.nameb;
            this.nameb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameb.FocusedState.Parent = this.nameb;
            this.nameb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameb.HoverState.Parent = this.nameb;
            this.nameb.Location = new System.Drawing.Point(16, 39);
            this.nameb.Name = "nameb";
            this.nameb.PasswordChar = '\0';
            this.nameb.PlaceholderText = "";
            this.nameb.SelectedText = "";
            this.nameb.SelectionStart = 4;
            this.nameb.ShadowDecoration.Parent = this.nameb;
            this.nameb.Size = new System.Drawing.Size(254, 27);
            this.nameb.TabIndex = 2;
            // 
            // date
            // 
            this.date.CheckedState.Parent = this.date;
            this.date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date.HoverState.Parent = this.date;
            this.date.Location = new System.Drawing.Point(16, 558);
            this.date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.ShadowDecoration.Parent = this.date;
            this.date.Size = new System.Drawing.Size(254, 27);
            this.date.TabIndex = 3;
            this.date.Value = new System.DateTime(2021, 4, 14, 19, 7, 54, 721);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Surname:";
            // 
            // surnb
            // 
            this.surnb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.surnb.DefaultText = "surname";
            this.surnb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.surnb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.surnb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.surnb.DisabledState.Parent = this.surnb;
            this.surnb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.surnb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.surnb.FocusedState.Parent = this.surnb;
            this.surnb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.surnb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.surnb.HoverState.Parent = this.surnb;
            this.surnb.Location = new System.Drawing.Point(16, 92);
            this.surnb.Name = "surnb";
            this.surnb.PasswordChar = '\0';
            this.surnb.PlaceholderText = "";
            this.surnb.SelectedText = "";
            this.surnb.SelectionStart = 7;
            this.surnb.ShadowDecoration.Parent = this.surnb;
            this.surnb.Size = new System.Drawing.Size(254, 27);
            this.surnb.TabIndex = 7;
            // 
            // regb
            // 
            this.regb.BackColor = System.Drawing.Color.Transparent;
            this.regb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.regb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regb.FocusedState.Parent = this.regb;
            this.regb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.regb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.regb.HoverState.Parent = this.regb;
            this.regb.ItemHeight = 30;
            this.regb.Items.AddRange(new object[] {
            "DE",
            "GB",
            "ES",
            "FR"});
            this.regb.ItemsAppearance.Parent = this.regb;
            this.regb.Location = new System.Drawing.Point(16, 145);
            this.regb.Name = "regb";
            this.regb.ShadowDecoration.Parent = this.regb;
            this.regb.Size = new System.Drawing.Size(123, 36);
            this.regb.TabIndex = 8;
            this.regb.SelectedIndexChanged += new System.EventHandler(this.regb_SelectedIndexChanged);
            // 
            // streetn
            // 
            this.streetn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.streetn.DefaultText = "fakestret";
            this.streetn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.streetn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.streetn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.streetn.DisabledState.Parent = this.streetn;
            this.streetn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.streetn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.streetn.FocusedState.Parent = this.streetn;
            this.streetn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.streetn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.streetn.HoverState.Parent = this.streetn;
            this.streetn.Location = new System.Drawing.Point(111, 207);
            this.streetn.Name = "streetn";
            this.streetn.PasswordChar = '\0';
            this.streetn.PlaceholderText = "";
            this.streetn.SelectedText = "";
            this.streetn.SelectionStart = 9;
            this.streetn.ShadowDecoration.Parent = this.streetn;
            this.streetn.Size = new System.Drawing.Size(159, 27);
            this.streetn.TabIndex = 10;
            // 
            // Housen
            // 
            this.Housen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Housen.DefaultText = "123";
            this.Housen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Housen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Housen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Housen.DisabledState.Parent = this.Housen;
            this.Housen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Housen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Housen.FocusedState.Parent = this.Housen;
            this.Housen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Housen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Housen.HoverState.Parent = this.Housen;
            this.Housen.Location = new System.Drawing.Point(16, 207);
            this.Housen.Name = "Housen";
            this.Housen.PasswordChar = '\0';
            this.Housen.PlaceholderText = "";
            this.Housen.SelectedText = "";
            this.Housen.SelectionStart = 3;
            this.Housen.ShadowDecoration.Parent = this.Housen;
            this.Housen.Size = new System.Drawing.Size(89, 27);
            this.Housen.TabIndex = 9;
            // 
            // town
            // 
            this.town.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.town.DefaultText = "town";
            this.town.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.town.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.town.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.town.DisabledState.Parent = this.town;
            this.town.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.town.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.town.FocusedState.Parent = this.town;
            this.town.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.town.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.town.HoverState.Parent = this.town;
            this.town.Location = new System.Drawing.Point(16, 260);
            this.town.Name = "town";
            this.town.PasswordChar = '\0';
            this.town.PlaceholderText = "";
            this.town.SelectedText = "";
            this.town.SelectionStart = 4;
            this.town.ShadowDecoration.Parent = this.town;
            this.town.Size = new System.Drawing.Size(254, 27);
            this.town.TabIndex = 11;
            // 
            // postcode
            // 
            this.postcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.postcode.DefaultText = "postcode";
            this.postcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.postcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.postcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.postcode.DisabledState.Parent = this.postcode;
            this.postcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.postcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.postcode.FocusedState.Parent = this.postcode;
            this.postcode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.postcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.postcode.HoverState.Parent = this.postcode;
            this.postcode.Location = new System.Drawing.Point(16, 366);
            this.postcode.Name = "postcode";
            this.postcode.PasswordChar = '\0';
            this.postcode.PlaceholderText = "";
            this.postcode.SelectedText = "";
            this.postcode.SelectionStart = 8;
            this.postcode.ShadowDecoration.Parent = this.postcode;
            this.postcode.Size = new System.Drawing.Size(254, 27);
            this.postcode.TabIndex = 13;
            // 
            // county
            // 
            this.county.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.county.DefaultText = "county";
            this.county.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.county.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.county.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.county.DisabledState.Parent = this.county;
            this.county.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.county.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.county.FocusedState.Parent = this.county;
            this.county.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.county.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.county.HoverState.Parent = this.county;
            this.county.Location = new System.Drawing.Point(16, 313);
            this.county.Name = "county";
            this.county.PasswordChar = '\0';
            this.county.PlaceholderText = "";
            this.county.SelectedText = "";
            this.county.SelectionStart = 6;
            this.county.ShadowDecoration.Parent = this.county;
            this.county.Size = new System.Drawing.Size(254, 27);
            this.county.TabIndex = 12;
            // 
            // itemname1
            // 
            this.itemname1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.itemname1.DefaultText = "item name1";
            this.itemname1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.itemname1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.itemname1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemname1.DisabledState.Parent = this.itemname1;
            this.itemname1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemname1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemname1.FocusedState.Parent = this.itemname1;
            this.itemname1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.itemname1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemname1.HoverState.Parent = this.itemname1;
            this.itemname1.Location = new System.Drawing.Point(16, 419);
            this.itemname1.Name = "itemname1";
            this.itemname1.PasswordChar = '\0';
            this.itemname1.PlaceholderText = "";
            this.itemname1.SelectedText = "";
            this.itemname1.SelectionStart = 10;
            this.itemname1.ShadowDecoration.Parent = this.itemname1;
            this.itemname1.Size = new System.Drawing.Size(254, 27);
            this.itemname1.TabIndex = 14;
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(215, 505);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(55, 27);
            this.guna2Button2.TabIndex = 15;
            this.guna2Button2.Text = "Generate";
            // 
            // vat
            // 
            this.vat.BackColor = System.Drawing.Color.Transparent;
            this.vat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.vat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vat.FocusedState.Parent = this.vat;
            this.vat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.vat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.vat.HoverState.Parent = this.vat;
            this.vat.ItemHeight = 30;
            this.vat.Items.AddRange(new object[] {
            "0%",
            "1%",
            "2%",
            "3%",
            "4%",
            "5%",
            "6%",
            "7%",
            "8%",
            "9%",
            "10%",
            "11%",
            "12%",
            "13%",
            "14%",
            "15%",
            "16%",
            "17%",
            "18%",
            "19%",
            "20%",
            "21%",
            "22%",
            "23%",
            "24%",
            "25%",
            "26%",
            "27%",
            "28%",
            "29%",
            "30%"});
            this.vat.ItemsAppearance.Parent = this.vat;
            this.vat.Location = new System.Drawing.Point(145, 145);
            this.vat.Name = "vat";
            this.vat.ShadowDecoration.Parent = this.vat;
            this.vat.Size = new System.Drawing.Size(125, 36);
            this.vat.TabIndex = 16;
            // 
            // price
            // 
            this.price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.price.DefaultText = "125";
            this.price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price.DisabledState.Parent = this.price;
            this.price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price.FocusedState.Parent = this.price;
            this.price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price.HoverState.Parent = this.price;
            this.price.Location = new System.Drawing.Point(16, 611);
            this.price.Name = "price";
            this.price.PasswordChar = '\0';
            this.price.PlaceholderText = "";
            this.price.SelectedText = "";
            this.price.SelectionStart = 3;
            this.price.ShadowDecoration.Parent = this.price;
            this.price.Size = new System.Drawing.Size(254, 27);
            this.price.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(18, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Region";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(18, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "House No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(121, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Street Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(18, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Town / Village";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(18, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Item Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gray;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(16, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Post Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(16, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "County";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Gray;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(18, 641);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Currency";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Gray;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(18, 588);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Price";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Gray;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(18, 535);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Date of invoice";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Gray;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(145, 641);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Quantity";
            // 
            // guna2Button3
            // 
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(16, 706);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(123, 25);
            this.guna2Button3.TabIndex = 31;
            this.guna2Button3.Text = "Save";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(145, 706);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(125, 25);
            this.guna2Button4.TabIndex = 32;
            this.guna2Button4.Text = "Load";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // itemname2
            // 
            this.itemname2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.itemname2.DefaultText = "item name 2";
            this.itemname2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.itemname2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.itemname2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemname2.DisabledState.Parent = this.itemname2;
            this.itemname2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemname2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemname2.FocusedState.Parent = this.itemname2;
            this.itemname2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.itemname2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemname2.HoverState.Parent = this.itemname2;
            this.itemname2.Location = new System.Drawing.Point(16, 452);
            this.itemname2.Name = "itemname2";
            this.itemname2.PasswordChar = '\0';
            this.itemname2.PlaceholderText = "";
            this.itemname2.SelectedText = "";
            this.itemname2.SelectionStart = 11;
            this.itemname2.ShadowDecoration.Parent = this.itemname2;
            this.itemname2.Size = new System.Drawing.Size(254, 27);
            this.itemname2.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Gray;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Silver;
            this.label14.Location = new System.Drawing.Point(18, 482);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 20);
            this.label14.TabIndex = 34;
            this.label14.Text = "ASIN";
            // 
            // url
            // 
            this.url.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.url.DefaultText = "product id";
            this.url.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.url.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.url.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.url.DisabledState.Parent = this.url;
            this.url.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.url.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.url.FocusedState.Parent = this.url;
            this.url.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.url.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.url.HoverState.Parent = this.url;
            this.url.Location = new System.Drawing.Point(20, 505);
            this.url.Name = "url";
            this.url.PasswordChar = '\0';
            this.url.PlaceholderText = "";
            this.url.SelectedText = "";
            this.url.SelectionStart = 10;
            this.url.ShadowDecoration.Parent = this.url;
            this.url.Size = new System.Drawing.Size(189, 27);
            this.url.TabIndex = 35;
            // 
            // currency
            // 
            this.currency.BackColor = System.Drawing.Color.Transparent;
            this.currency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currency.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.currency.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.currency.FocusedState.Parent = this.currency;
            this.currency.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.currency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.currency.HoverState.Parent = this.currency;
            this.currency.ItemHeight = 30;
            this.currency.Items.AddRange(new object[] {
            "€",
            "£",
            "$",
            "¥"});
            this.currency.ItemsAppearance.Parent = this.currency;
            this.currency.Location = new System.Drawing.Point(16, 664);
            this.currency.Name = "currency";
            this.currency.ShadowDecoration.Parent = this.currency;
            this.currency.Size = new System.Drawing.Size(123, 36);
            this.currency.TabIndex = 36;
            // 
            // quan
            // 
            this.quan.BackColor = System.Drawing.Color.Transparent;
            this.quan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.quan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quan.FocusedState.Parent = this.quan;
            this.quan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.quan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.quan.HoverState.Parent = this.quan;
            this.quan.ItemHeight = 30;
            this.quan.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.quan.ItemsAppearance.Parent = this.quan;
            this.quan.Location = new System.Drawing.Point(145, 664);
            this.quan.Name = "quan";
            this.quan.ShadowDecoration.Parent = this.quan;
            this.quan.Size = new System.Drawing.Size(125, 36);
            this.quan.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Gray;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Silver;
            this.label15.Location = new System.Drawing.Point(145, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 20);
            this.label15.TabIndex = 38;
            this.label15.Text = "VAT";
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Transparent;
            this.pb1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.pb1.Location = new System.Drawing.Point(-51, 831);
            this.pb1.Name = "pb1";
            this.pb1.ProgressColor = System.Drawing.Color.CornflowerBlue;
            this.pb1.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.pb1.ShadowDecoration.Parent = this.pb1;
            this.pb1.Size = new System.Drawing.Size(376, 10);
            this.pb1.TabIndex = 39;
            this.pb1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(906, 841);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.quan);
            this.Controls.Add(this.currency);
            this.Controls.Add(this.url);
            this.Controls.Add(this.itemname2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.nameb);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.surnb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.regb);
            this.Controls.Add(this.itemname1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vat);
            this.Controls.Add(this.postcode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Housen);
            this.Controls.Add(this.county);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.streetn);
            this.Controls.Add(this.town);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox nameb;
        private Guna.UI2.WinForms.Guna2DateTimePicker date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox surnb;
        private Guna.UI2.WinForms.Guna2ComboBox regb;
        private Guna.UI2.WinForms.Guna2TextBox streetn;
        private Guna.UI2.WinForms.Guna2TextBox Housen;
        private Guna.UI2.WinForms.Guna2TextBox town;
        private Guna.UI2.WinForms.Guna2TextBox postcode;
        private Guna.UI2.WinForms.Guna2TextBox county;
        private Guna.UI2.WinForms.Guna2TextBox itemname1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2ComboBox vat;
        private Guna.UI2.WinForms.Guna2TextBox price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Guna.UI2.WinForms.Guna2TextBox itemname2;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TextBox url;
        private Guna.UI2.WinForms.Guna2ComboBox currency;
        private Guna.UI2.WinForms.Guna2ComboBox quan;
        private System.Windows.Forms.Label label15;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2ProgressBar pb1;
    }
}