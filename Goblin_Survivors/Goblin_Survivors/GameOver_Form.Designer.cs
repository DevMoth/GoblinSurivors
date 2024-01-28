namespace Goblin_Survivors
{
    partial class GameOver_Form
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
            this.GameOver_text = new System.Windows.Forms.Label();
            this.encouragement_text = new System.Windows.Forms.Label();
            this.Score_text = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameOver_text
            // 
            this.GameOver_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.GameOver_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.GameOver_text.Location = new System.Drawing.Point(0, 0);
            this.GameOver_text.Name = "GameOver_text";
            this.GameOver_text.Size = new System.Drawing.Size(800, 63);
            this.GameOver_text.TabIndex = 0;
            this.GameOver_text.Text = "GAME OVER";
            this.GameOver_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // encouragement_text
            // 
            this.encouragement_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.encouragement_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.encouragement_text.Location = new System.Drawing.Point(0, 63);
            this.encouragement_text.Name = "encouragement_text";
            this.encouragement_text.Size = new System.Drawing.Size(800, 71);
            this.encouragement_text.TabIndex = 1;
            this.encouragement_text.Text = "Похоже ты не смог выдержать натиск врагов. Ну ничего, всегда можно попробовать сн" +
    "ова!";
            this.encouragement_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Score_text
            // 
            this.Score_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.Score_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Score_text.Location = new System.Drawing.Point(0, 134);
            this.Score_text.Name = "Score_text";
            this.Score_text.Size = new System.Drawing.Size(800, 32);
            this.Score_text.TabIndex = 2;
            this.Score_text.Text = "Твой счет: 99999";
            this.Score_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(290, 190);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(215, 85);
            this.close_button.TabIndex = 3;
            this.close_button.Text = "Вернуться в меню";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // GameOver_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.Score_text);
            this.Controls.Add(this.encouragement_text);
            this.Controls.Add(this.GameOver_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GameOver_Form";
            this.Text = "GameOver_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label GameOver_text;
        private System.Windows.Forms.Label encouragement_text;
        private System.Windows.Forms.Label Score_text;
        private System.Windows.Forms.Button close_button;
    }
}