namespace MegaDesk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ViewAllQuotesButton = new System.Windows.Forms.Button();
            this.SearchQuotesButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddQuotesButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewAllQuotesButton
            // 
            this.ViewAllQuotesButton.AutoSize = true;
            this.ViewAllQuotesButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ViewAllQuotesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ViewAllQuotesButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllQuotesButton.ForeColor = System.Drawing.Color.White;
            this.ViewAllQuotesButton.Location = new System.Drawing.Point(86, 263);
            this.ViewAllQuotesButton.Margin = new System.Windows.Forms.Padding(0);
            this.ViewAllQuotesButton.Name = "ViewAllQuotesButton";
            this.ViewAllQuotesButton.Size = new System.Drawing.Size(177, 32);
            this.ViewAllQuotesButton.TabIndex = 2;
            this.ViewAllQuotesButton.Text = "View &Quotes";
            this.ViewAllQuotesButton.UseVisualStyleBackColor = false;
            this.ViewAllQuotesButton.Click += new System.EventHandler(this.ViewQuote_Click);
            // 
            // SearchQuotesButton
            // 
            this.SearchQuotesButton.AutoSize = true;
            this.SearchQuotesButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SearchQuotesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchQuotesButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQuotesButton.ForeColor = System.Drawing.Color.White;
            this.SearchQuotesButton.Location = new System.Drawing.Point(86, 366);
            this.SearchQuotesButton.Margin = new System.Windows.Forms.Padding(0);
            this.SearchQuotesButton.Name = "SearchQuotesButton";
            this.SearchQuotesButton.Size = new System.Drawing.Size(177, 35);
            this.SearchQuotesButton.TabIndex = 3;
            this.SearchQuotesButton.Text = "Search &Quotes";
            this.SearchQuotesButton.UseVisualStyleBackColor = false;
            this.SearchQuotesButton.Click += new System.EventHandler(this.SearchQuotesButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitButton.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(2, 570);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(31, 29);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "&<";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddQuotesButton
            // 
            this.AddQuotesButton.AutoSize = true;
            this.AddQuotesButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddQuotesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddQuotesButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuotesButton.ForeColor = System.Drawing.Color.White;
            this.AddQuotesButton.Location = new System.Drawing.Point(86, 172);
            this.AddQuotesButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddQuotesButton.Name = "AddQuotesButton";
            this.AddQuotesButton.Size = new System.Drawing.Size(177, 32);
            this.AddQuotesButton.TabIndex = 6;
            this.AddQuotesButton.Text = "Add &Quotes";
            this.AddQuotesButton.UseVisualStyleBackColor = false;
            this.AddQuotesButton.Click += new System.EventHandler(this.AddQuoteButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MegaDesk.Properties.Resources.megate;
            this.pictureBox1.Location = new System.Drawing.Point(353, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 580);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(695, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "MEGA-DESK";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 597);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddQuotesButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchQuotesButton);
            this.Controls.Add(this.ViewAllQuotesButton);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Mega Desk - Nnachi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ViewAllQuotesButton;
        private System.Windows.Forms.Button SearchQuotesButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AddQuotesButton;
        private System.Windows.Forms.Label label3;
    }
}

