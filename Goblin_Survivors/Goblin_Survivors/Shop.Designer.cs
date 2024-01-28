namespace Goblin_Survivors
{
    partial class Shop
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
            this.close_button = new System.Windows.Forms.Button();
            this.upgrade1 = new System.Windows.Forms.GroupBox();
            this.upgrade1_picture = new System.Windows.Forms.PictureBox();
            this.upgrade1_button = new System.Windows.Forms.Button();
            this.upgrade2 = new System.Windows.Forms.GroupBox();
            this.upgrade2_picture = new System.Windows.Forms.PictureBox();
            this.upgrade2_button = new System.Windows.Forms.Button();
            this.upgrade3 = new System.Windows.Forms.GroupBox();
            this.upgrade3_picture = new System.Windows.Forms.PictureBox();
            this.upgrade3_button = new System.Windows.Forms.Button();
            this.stats_sheet = new System.Windows.Forms.ListBox();
            this.stat_description = new System.Windows.Forms.Label();
            this.upgrade1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upgrade1_picture)).BeginInit();
            this.upgrade2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upgrade2_picture)).BeginInit();
            this.upgrade3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upgrade3_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(111, 432);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(115, 45);
            this.close_button.TabIndex = 0;
            this.close_button.Text = "+300 здоровья";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // upgrade1
            // 
            this.upgrade1.Controls.Add(this.upgrade1_picture);
            this.upgrade1.Controls.Add(this.upgrade1_button);
            this.upgrade1.Location = new System.Drawing.Point(12, 12);
            this.upgrade1.Name = "upgrade1";
            this.upgrade1.Size = new System.Drawing.Size(326, 134);
            this.upgrade1.TabIndex = 1;
            this.upgrade1.TabStop = false;
            this.upgrade1.Text = "Лук и стрелы";
            // 
            // upgrade1_picture
            // 
            this.upgrade1_picture.Image = global::Goblin_Survivors.Properties.Resources.заманчиво;
            this.upgrade1_picture.Location = new System.Drawing.Point(6, 21);
            this.upgrade1_picture.Name = "upgrade1_picture";
            this.upgrade1_picture.Size = new System.Drawing.Size(100, 100);
            this.upgrade1_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upgrade1_picture.TabIndex = 1;
            this.upgrade1_picture.TabStop = false;
            // 
            // upgrade1_button
            // 
            this.upgrade1_button.Location = new System.Drawing.Point(120, 21);
            this.upgrade1_button.Name = "upgrade1_button";
            this.upgrade1_button.Size = new System.Drawing.Size(200, 100);
            this.upgrade1_button.TabIndex = 0;
            this.upgrade1_button.Text = "+урон";
            this.upgrade1_button.UseVisualStyleBackColor = true;
            this.upgrade1_button.Click += new System.EventHandler(this.upgrade1_button_Click);
            // 
            // upgrade2
            // 
            this.upgrade2.Controls.Add(this.upgrade2_picture);
            this.upgrade2.Controls.Add(this.upgrade2_button);
            this.upgrade2.Location = new System.Drawing.Point(12, 152);
            this.upgrade2.Name = "upgrade2";
            this.upgrade2.Size = new System.Drawing.Size(326, 134);
            this.upgrade2.TabIndex = 2;
            this.upgrade2.TabStop = false;
            this.upgrade2.Text = "Бархатные тяги";
            // 
            // upgrade2_picture
            // 
            this.upgrade2_picture.Location = new System.Drawing.Point(6, 21);
            this.upgrade2_picture.Name = "upgrade2_picture";
            this.upgrade2_picture.Size = new System.Drawing.Size(100, 100);
            this.upgrade2_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upgrade2_picture.TabIndex = 1;
            this.upgrade2_picture.TabStop = false;
            // 
            // upgrade2_button
            // 
            this.upgrade2_button.Location = new System.Drawing.Point(120, 21);
            this.upgrade2_button.Name = "upgrade2_button";
            this.upgrade2_button.Size = new System.Drawing.Size(200, 100);
            this.upgrade2_button.TabIndex = 0;
            this.upgrade2_button.Text = "+скорость";
            this.upgrade2_button.UseVisualStyleBackColor = true;
            this.upgrade2_button.Click += new System.EventHandler(this.upgrade2_button_Click);
            // 
            // upgrade3
            // 
            this.upgrade3.Controls.Add(this.upgrade3_picture);
            this.upgrade3.Controls.Add(this.upgrade3_button);
            this.upgrade3.Location = new System.Drawing.Point(12, 292);
            this.upgrade3.Name = "upgrade3";
            this.upgrade3.Size = new System.Drawing.Size(326, 134);
            this.upgrade3.TabIndex = 3;
            this.upgrade3.TabStop = false;
            this.upgrade3.Text = "Ядовитый туман";
            // 
            // upgrade3_picture
            // 
            this.upgrade3_picture.Location = new System.Drawing.Point(6, 21);
            this.upgrade3_picture.Name = "upgrade3_picture";
            this.upgrade3_picture.Size = new System.Drawing.Size(100, 100);
            this.upgrade3_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upgrade3_picture.TabIndex = 1;
            this.upgrade3_picture.TabStop = false;
            // 
            // upgrade3_button
            // 
            this.upgrade3_button.Location = new System.Drawing.Point(120, 21);
            this.upgrade3_button.Name = "upgrade3_button";
            this.upgrade3_button.Size = new System.Drawing.Size(200, 100);
            this.upgrade3_button.TabIndex = 0;
            this.upgrade3_button.Text = "+глобальный урон";
            this.upgrade3_button.UseVisualStyleBackColor = true;
            this.upgrade3_button.Click += new System.EventHandler(this.upgrade3_button_Click);
            // 
            // stats_sheet
            // 
            this.stats_sheet.FormattingEnabled = true;
            this.stats_sheet.ItemHeight = 16;
            this.stats_sheet.Location = new System.Drawing.Point(344, 12);
            this.stats_sheet.Name = "stats_sheet";
            this.stats_sheet.Size = new System.Drawing.Size(324, 356);
            this.stats_sheet.TabIndex = 4;
            this.stats_sheet.SelectedIndexChanged += new System.EventHandler(this.stats_sheet_SelectedIndexChanged);
            // 
            // stat_description
            // 
            this.stat_description.Location = new System.Drawing.Point(345, 375);
            this.stat_description.Name = "stat_description";
            this.stat_description.Size = new System.Drawing.Size(323, 102);
            this.stat_description.TabIndex = 5;
            this.stat_description.Text = "Выбери характеристику, чтобы узнать про нее поподробнее!";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 488);
            this.Controls.Add(this.stat_description);
            this.Controls.Add(this.stats_sheet);
            this.Controls.Add(this.upgrade3);
            this.Controls.Add(this.upgrade2);
            this.Controls.Add(this.upgrade1);
            this.Controls.Add(this.close_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Shop";
            this.Text = "Магазин";
            this.Load += new System.EventHandler(this.Shop_Load);
            this.upgrade1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upgrade1_picture)).EndInit();
            this.upgrade2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upgrade2_picture)).EndInit();
            this.upgrade3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upgrade3_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.GroupBox upgrade1;
        private System.Windows.Forms.Button upgrade1_button;
        private System.Windows.Forms.PictureBox upgrade1_picture;
        private System.Windows.Forms.GroupBox upgrade2;
        private System.Windows.Forms.PictureBox upgrade2_picture;
        private System.Windows.Forms.Button upgrade2_button;
        private System.Windows.Forms.GroupBox upgrade3;
        private System.Windows.Forms.PictureBox upgrade3_picture;
        private System.Windows.Forms.Button upgrade3_button;
        private System.Windows.Forms.ListBox stats_sheet;
        private System.Windows.Forms.Label stat_description;
    }
}