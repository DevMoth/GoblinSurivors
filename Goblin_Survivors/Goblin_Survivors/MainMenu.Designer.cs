namespace Goblin_Survivors
{
    partial class MainMenu
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
            this.GameStart_button = new System.Windows.Forms.Button();
            this.TitleText = new System.Windows.Forms.Label();
            this.Score_button = new System.Windows.Forms.Button();
            this.ScoreBoard = new System.Windows.Forms.ListBox();
            this.ScoreGoblin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreGoblin)).BeginInit();
            this.SuspendLayout();
            // 
            // GameStart_button
            // 
            this.GameStart_button.Location = new System.Drawing.Point(245, 104);
            this.GameStart_button.Name = "GameStart_button";
            this.GameStart_button.Size = new System.Drawing.Size(300, 100);
            this.GameStart_button.TabIndex = 0;
            this.GameStart_button.Text = "Новая игра";
            this.GameStart_button.UseVisualStyleBackColor = true;
            this.GameStart_button.Click += new System.EventHandler(this.GameStart_button_Click);
            // 
            // TitleText
            // 
            this.TitleText.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.TitleText.Location = new System.Drawing.Point(0, 0);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(802, 68);
            this.TitleText.TabIndex = 1;
            this.TitleText.Text = "Goblin Survivors";
            this.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Score_button
            // 
            this.Score_button.Location = new System.Drawing.Point(245, 210);
            this.Score_button.Name = "Score_button";
            this.Score_button.Size = new System.Drawing.Size(300, 100);
            this.Score_button.TabIndex = 2;
            this.Score_button.Text = "Показать таблицу лидеров";
            this.Score_button.UseVisualStyleBackColor = true;
            this.Score_button.Click += new System.EventHandler(this.Score_button_Click);
            // 
            // ScoreBoard
            // 
            this.ScoreBoard.FormattingEnabled = true;
            this.ScoreBoard.ItemHeight = 16;
            this.ScoreBoard.Location = new System.Drawing.Point(12, 470);
            this.ScoreBoard.Name = "ScoreBoard";
            this.ScoreBoard.Size = new System.Drawing.Size(258, 164);
            this.ScoreBoard.TabIndex = 3;
            // 
            // ScoreGoblin
            // 
            this.ScoreGoblin.Image = global::Goblin_Survivors.Properties.Resources.dude_laying;
            this.ScoreGoblin.Location = new System.Drawing.Point(277, 470);
            this.ScoreGoblin.Name = "ScoreGoblin";
            this.ScoreGoblin.Size = new System.Drawing.Size(513, 164);
            this.ScoreGoblin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ScoreGoblin.TabIndex = 4;
            this.ScoreGoblin.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.ScoreGoblin);
            this.Controls.Add(this.ScoreBoard);
            this.Controls.Add(this.Score_button);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.GameStart_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScoreGoblin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GameStart_button;
        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.Button Score_button;
        private System.Windows.Forms.ListBox ScoreBoard;
        private System.Windows.Forms.PictureBox ScoreGoblin;
    }
}