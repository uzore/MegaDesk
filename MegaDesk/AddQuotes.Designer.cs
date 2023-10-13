namespace MegaDesk
{
    partial class AddQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuotes));
            this.MenuButton = new System.Windows.Forms.Button();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.DisplayQuoteButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.RushBox = new System.Windows.Forms.ComboBox();
            this.RushOrderBox = new System.Windows.Forms.Label();
            this.DepthBox = new System.Windows.Forms.NumericUpDown();
            this.DrawerBox = new System.Windows.Forms.ComboBox();
            this.CustomerAddress = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.WidthBox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.MaterialListBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WidthButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerNameBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MenuButton.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.MenuButton.ForeColor = System.Drawing.Color.White;
            this.MenuButton.Location = new System.Drawing.Point(-1, -1);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(0);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(45, 29);
            this.MenuButton.TabIndex = 7;
            this.MenuButton.Text = "&Menu";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // DateTime
            // 
            this.DateTime.CalendarForeColor = System.Drawing.Color.LightSkyBlue;
            this.DateTime.CalendarTrailingForeColor = System.Drawing.Color.LightSkyBlue;
            this.DateTime.Enabled = false;
            this.DateTime.Location = new System.Drawing.Point(678, 576);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(182, 20);
            this.DateTime.TabIndex = 8;
            this.DateTime.Value = new System.DateTime(2023, 9, 27, 0, 0, 0, 0);
            this.DateTime.Visible = false;
            // 
            // DisplayQuoteButton
            // 
            this.DisplayQuoteButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DisplayQuoteButton.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayQuoteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DisplayQuoteButton.Location = new System.Drawing.Point(499, 398);
            this.DisplayQuoteButton.Name = "DisplayQuoteButton";
            this.DisplayQuoteButton.Size = new System.Drawing.Size(135, 33);
            this.DisplayQuoteButton.TabIndex = 12;
            this.DisplayQuoteButton.Text = "Display Quote";
            this.DisplayQuoteButton.UseVisualStyleBackColor = false;
            this.DisplayQuoteButton.Click += new System.EventHandler(this.DisplayQuoteButton_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(701, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "MEGA-DESK ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // GroupBox
            // 
            this.GroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GroupBox.CausesValidation = false;
            this.GroupBox.Controls.Add(this.RushBox);
            this.GroupBox.Controls.Add(this.RushOrderBox);
            this.GroupBox.Controls.Add(this.DepthBox);
            this.GroupBox.Controls.Add(this.DrawerBox);
            this.GroupBox.Controls.Add(this.CustomerAddress);
            this.GroupBox.Controls.Add(this.AddressBox);
            this.GroupBox.Controls.Add(this.WidthBox);
            this.GroupBox.Controls.Add(this.label7);
            this.GroupBox.Controls.Add(this.MaterialListBox);
            this.GroupBox.Controls.Add(this.label6);
            this.GroupBox.Controls.Add(this.label2);
            this.GroupBox.Controls.Add(this.WidthButton);
            this.GroupBox.Controls.Add(this.label1);
            this.GroupBox.Controls.Add(this.CustomerNameBox);
            this.GroupBox.Controls.Add(this.SubmitButton);
            this.GroupBox.Controls.Add(this.DisplayQuoteButton);
            this.GroupBox.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.GroupBox.Location = new System.Drawing.Point(51, 58);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(750, 480);
            this.GroupBox.TabIndex = 26;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Quote Form";
            this.GroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RushBox
            // 
            this.RushBox.BackColor = System.Drawing.Color.White;
            this.RushBox.DropDownHeight = 70;
            this.RushBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RushBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.RushBox.FormattingEnabled = true;
            this.RushBox.IntegralHeight = false;
            this.RushBox.ItemHeight = 20;
            this.RushBox.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.RushBox.Location = new System.Drawing.Point(484, 307);
            this.RushBox.MaxDropDownItems = 10;
            this.RushBox.Name = "RushBox";
            this.RushBox.Size = new System.Drawing.Size(47, 28);
            this.RushBox.TabIndex = 43;
            // 
            // RushOrderBox
            // 
            this.RushOrderBox.AutoSize = true;
            this.RushOrderBox.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrderBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.RushOrderBox.Location = new System.Drawing.Point(335, 311);
            this.RushOrderBox.Name = "RushOrderBox";
            this.RushOrderBox.Size = new System.Drawing.Size(109, 20);
            this.RushOrderBox.TabIndex = 42;
            this.RushOrderBox.Text = "Rush Order";
            // 
            // DepthBox
            // 
            this.DepthBox.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.DepthBox.Location = new System.Drawing.Point(178, 263);
            this.DepthBox.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.DepthBox.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DepthBox.Name = "DepthBox";
            this.DepthBox.Size = new System.Drawing.Size(55, 27);
            this.DepthBox.TabIndex = 41;
            this.DepthBox.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // DrawerBox
            // 
            this.DrawerBox.BackColor = System.Drawing.Color.White;
            this.DrawerBox.DropDownHeight = 70;
            this.DrawerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrawerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawerBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.DrawerBox.FormattingEnabled = true;
            this.DrawerBox.IntegralHeight = false;
            this.DrawerBox.ItemHeight = 20;
            this.DrawerBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.DrawerBox.Location = new System.Drawing.Point(484, 220);
            this.DrawerBox.MaxDropDownItems = 10;
            this.DrawerBox.Name = "DrawerBox";
            this.DrawerBox.Size = new System.Drawing.Size(47, 28);
            this.DrawerBox.TabIndex = 40;
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.AutoSize = true;
            this.CustomerAddress.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerAddress.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.CustomerAddress.Location = new System.Drawing.Point(91, 119);
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.Size = new System.Drawing.Size(169, 20);
            this.CustomerAddress.TabIndex = 39;
            this.CustomerAddress.Text = "Customer Address";
            this.CustomerAddress.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // AddressBox
            // 
            this.AddressBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.AddressBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.AddressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressBox.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.AddressBox.Location = new System.Drawing.Point(263, 116);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(386, 27);
            this.AddressBox.TabIndex = 38;
            this.AddressBox.TextChanged += new System.EventHandler(this.AddressBox_TextChanged);
            // 
            // WidthBox
            // 
            this.WidthBox.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.WidthBox.Location = new System.Drawing.Point(178, 224);
            this.WidthBox.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.WidthBox.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(55, 27);
            this.WidthBox.TabIndex = 33;
            this.WidthBox.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.WidthBox.ValueChanged += new System.EventHandler(this.WidthBox_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Location = new System.Drawing.Point(335, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Materials";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // MaterialListBox
            // 
            this.MaterialListBox.BackColor = System.Drawing.Color.White;
            this.MaterialListBox.DropDownHeight = 70;
            this.MaterialListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialListBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.MaterialListBox.FormattingEnabled = true;
            this.MaterialListBox.IntegralHeight = false;
            this.MaterialListBox.ItemHeight = 20;
            this.MaterialListBox.Items.AddRange(new object[] {
            "Oak",
            "Maple",
            "Pine",
            "Laminate",
            "Veneer"});
            this.MaterialListBox.Location = new System.Drawing.Point(484, 263);
            this.MaterialListBox.MaxDropDownItems = 10;
            this.MaterialListBox.Name = "MaterialListBox";
            this.MaterialListBox.Size = new System.Drawing.Size(165, 28);
            this.MaterialListBox.TabIndex = 31;
            this.MaterialListBox.SelectedIndexChanged += new System.EventHandler(this.MaterialListBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Location = new System.Drawing.Point(335, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "No. of Drawers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Depth";
            // 
            // WidthButton
            // 
            this.WidthButton.AutoSize = true;
            this.WidthButton.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.WidthButton.Location = new System.Drawing.Point(102, 224);
            this.WidthButton.Name = "WidthButton";
            this.WidthButton.Size = new System.Drawing.Size(59, 20);
            this.WidthButton.TabIndex = 28;
            this.WidthButton.Text = "Width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(102, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Customer Name";
            // 
            // CustomerNameBox
            // 
            this.CustomerNameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CustomerNameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.CustomerNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerNameBox.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.CustomerNameBox.Location = new System.Drawing.Point(263, 68);
            this.CustomerNameBox.Name = "CustomerNameBox";
            this.CustomerNameBox.Size = new System.Drawing.Size(386, 27);
            this.CustomerNameBox.TabIndex = 26;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SubmitButton.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SubmitButton.Location = new System.Drawing.Point(250, 398);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(99, 33);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // AddQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 597);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.GroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuotes";
            this.Text = "Add Quotes";
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.Button DisplayQuoteButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label CustomerAddress;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.NumericUpDown WidthBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox MaterialListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label WidthButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerNameBox;
        private System.Windows.Forms.ComboBox DrawerBox;
        private System.Windows.Forms.NumericUpDown DepthBox;
        private System.Windows.Forms.ComboBox RushBox;
        private System.Windows.Forms.Label RushOrderBox;
    }
}