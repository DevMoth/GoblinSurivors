namespace Goblin_Survivors
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.score_text = new System.Windows.Forms.Label();
            this.Goblin = new System.Windows.Forms.Label();
            this.exp_text = new System.Windows.Forms.Label();
            this.Goblin_shield = new System.Windows.Forms.Label();
            this.exp_bar = new System.Windows.Forms.PictureBox();
            this.Screen = new System.Windows.Forms.PictureBox();
            this.level_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exp_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Screen)).BeginInit();
            this.SuspendLayout();
            // 
            // score_text
            // 
            this.score_text.AutoSize = true;
            this.score_text.Location = new System.Drawing.Point(12, 9);
            this.score_text.Name = "score_text";
            this.score_text.Size = new System.Drawing.Size(58, 17);
            this.score_text.TabIndex = 2;
            this.score_text.Text = "Очки: 0";
            // 
            // Goblin
            // 
            this.Goblin.AutoSize = true;
            this.Goblin.Location = new System.Drawing.Point(375, 221);
            this.Goblin.Name = "Goblin";
            this.Goblin.Size = new System.Drawing.Size(40, 17);
            this.Goblin.TabIndex = 1;
            this.Goblin.Text = "1000";
            // 
            // exp_text
            // 
            this.exp_text.AutoSize = true;
            this.exp_text.Location = new System.Drawing.Point(76, 9);
            this.exp_text.Name = "exp_text";
            this.exp_text.Size = new System.Drawing.Size(72, 17);
            this.exp_text.TabIndex = 4;
            this.exp_text.Text = "Опыт: 0/5";
            // 
            // Goblin_shield
            // 
            this.Goblin_shield.AutoSize = true;
            this.Goblin_shield.Location = new System.Drawing.Point(378, 242);
            this.Goblin_shield.Name = "Goblin_shield";
            this.Goblin_shield.Size = new System.Drawing.Size(32, 17);
            this.Goblin_shield.TabIndex = 5;
            this.Goblin_shield.Text = "100";
            // 
            // exp_bar
            // 
            this.exp_bar.BackColor = System.Drawing.Color.White;
            this.exp_bar.Location = new System.Drawing.Point(154, 9);
            this.exp_bar.Name = "exp_bar";
            this.exp_bar.Size = new System.Drawing.Size(200, 17);
            this.exp_bar.TabIndex = 3;
            this.exp_bar.TabStop = false;
            // 
            // Screen
            // 
            this.Screen.BackColor = System.Drawing.Color.White;
            this.Screen.Location = new System.Drawing.Point(12, 32);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(1158, 929);
            this.Screen.TabIndex = 0;
            this.Screen.TabStop = false;
            this.Screen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Screen_MouseDown);
            this.Screen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Screen_MouseUp);
            // 
            // level_text
            // 
            this.level_text.AutoSize = true;
            this.level_text.Location = new System.Drawing.Point(361, 9);
            this.level_text.Name = "level_text";
            this.level_text.Size = new System.Drawing.Size(73, 17);
            this.level_text.TabIndex = 6;
            this.level_text.Text = "0 уровень";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 973);
            this.Controls.Add(this.level_text);
            this.Controls.Add(this.Goblin_shield);
            this.Controls.Add(this.exp_text);
            this.Controls.Add(this.exp_bar);
            this.Controls.Add(this.score_text);
            this.Controls.Add(this.Goblin);
            this.Controls.Add(this.Screen);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Goblin Survivors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.exp_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Screen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label score_text;
        private System.Windows.Forms.Label Goblin;
        private System.Windows.Forms.PictureBox Screen;
        private System.Windows.Forms.PictureBox exp_bar;
        private System.Windows.Forms.Label exp_text;
        private System.Windows.Forms.Label Goblin_shield;
        private System.Windows.Forms.Label level_text;
    }
}

