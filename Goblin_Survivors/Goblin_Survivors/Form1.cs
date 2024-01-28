using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goblin_Survivors
{
    public partial class MainForm : Form 
    {
        Timer time = new Timer();//WARNING: I'm too lazy to give descriptions to eveything, good luck understanding what the hell is going in here
        public MainForm()
        {
            InitializeComponent();
            //creating the TIME
            time.Interval = 40;
            time.Enabled = false;
            time.Tick += Hero_update;
            time.Tick += Enemy_update;
            time.Tick += Enemy_spawn;
            time.Tick += Graphics_update;
            //creating the first enemy
            Label enemy_grunt = new Label();
            enemy_grunt.Size = new Size(25, 13);
            enemy_grunt.Location = new Point(500, 500);
            enemy_grunt.Text = endefaulthp.ToString();
            enemy_grunt.MouseDown += Enemy_click;
            enemy_grunt.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(enemy_grunt);
            enemy_grunt.BringToFront();
            enemy_list.Add(enemy_grunt);
        }

        //Misc variables
        Random rng = new Random();
        Pen exp_bar_pen = new Pen(Color.Blue);
        Pen melee_range_color = new Pen(Color.Gray, 2);
        int fog_counter = 1, dagger_cooldown = 0, spawn_counter = 1, boss_spawn_counter = 0, hero_counter = 0;
        //hero stats
        int hero_size = 100, hero_x, hero_y, hero_x2, hero_y2, hero_dx = 0, hero_dy = 0;
        Pen Hero_outline = new Pen(Color.Black);
        static public int hero_speed = 5, hero_health = 1000, hero_defshield = 100, hero_dmg = 2, hero_cooldown = 5, dagger_dmg = 0, dagger_range = 0, dagger_defcooldown = 10, fog_dmg = 0, fog_cooldown = 25, score = 0, level = 0;
        static public double hero_actual_speed = 5;
        int exp = 0, exp_goal = 5, hero_shield = 100;
        bool mouse_down = false;
        //enemy stats
        int endefaulthp = 5, enspeed = 1, difficulty = 1, en_amount = 1;
        List<Label> enemy_list = new List<Label>();
        int enx, eny, enx2, eny2, en_size = 80;

        //Form actions
        private void MainForm_Resize(object sender, EventArgs e)
        {
            Screen.Size = new Size(this.Width - 42, this.Height - 91); //Resizing the Screen
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //resetting the stats
            Screen.Size = new Size(this.Width - 42, this.Height - 91);
            Goblin.Location = new Point(375, 221);
            hero_speed = 5;
            hero_health = 1000;
            hero_defshield = 100;
            hero_dmg = 2;
            hero_cooldown = 5;
            dagger_dmg = 0;
            dagger_range = 0;
            dagger_defcooldown = 10;
            fog_dmg = 0;
            fog_cooldown = 25;
            score = 0;
            level = 0;
            hero_actual_speed = 5;
            exp = 0;
            exp_goal = 5;
            hero_shield = 100;
            endefaulthp = 5;
            enspeed = 1;
            difficulty = 0;
            en_amount = 0;
            for (int i = 0; i < enemy_list.Count; ++i)
            {
                enemy_list[i].Text = endefaulthp.ToString();
                enemy_list[i].Visible = false;
            }           enemy_list[0].Visible = true;
            //starting the timer
            time.Enabled = true;
            time.Start();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            time.Enabled = false;//stops the timer to not break stuff
        }

        //movement input
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                hero_dy = -hero_speed;
            }
            if (e.KeyCode == Keys.S)
            {
                hero_dy = hero_speed;
            }
            if (e.KeyCode == Keys.A)
            {
                hero_dx = -hero_speed;
            }
            if (e.KeyCode == Keys.D)
            {
                hero_dx = hero_speed;
            }
        }
        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                hero_dy = 0;
            }
            if (e.KeyCode == Keys.S)
            {
                hero_dy = 0;
            }
            if (e.KeyCode == Keys.A)
            {
                hero_dx = 0;
            }
            if (e.KeyCode == Keys.D)
            {
                hero_dx = 0;
            }
        }

        //Drawing everything on to the screen
        private void Graphics_update(object sender, EventArgs e)
        {
            Pen Hero_color = new Pen(Color.FromArgb(0, Math.Abs(Convert.ToInt32((Convert.ToDouble(hero_health) / 1000) * 160)), 0));
            Screen.CreateGraphics().Clear(Color.White);
            if (dagger_dmg != 0)//drawing the sword range
            {
                Screen.CreateGraphics().DrawRectangle(melee_range_color, hero_x - dagger_range, hero_y - dagger_range, hero_size + 2 * dagger_range, hero_size + 2 * dagger_range);
            }
            Screen.CreateGraphics().FillRectangle(Hero_color.Brush, hero_x, hero_y, hero_size, hero_size);//drawing the goblin
            Screen.CreateGraphics().DrawRectangle(Hero_outline, hero_x, hero_y, hero_size, hero_size);
            for (int i = 0; i <= en_amount; ++i)//drawing each enemy present
            {
                Pen Enemy_color = new Pen(Color.FromArgb(Math.Abs(Convert.ToInt32((Convert.ToDouble(enemy_list[i].Text) / endefaulthp) * 255)), 0, 0));
                enx = enemy_list[i].Location.X - en_size / 2;
                eny = enemy_list[i].Location.Y - 15 - en_size / 2;
                Screen.CreateGraphics().FillRectangle(Enemy_color.Brush, enx, eny, en_size, en_size);
                Screen.CreateGraphics().DrawRectangle(Hero_outline, enx, eny, en_size, en_size);
            }
        }

        //hero time update
        private void Hero_update(object sender, EventArgs e)
        {
            if(hero_health <= 0)//Goblin dying
            {
                this.Close();
            }
            //setting the corners of the hero
            hero_x = Goblin.Location.X + 5 - hero_size / 2;
            hero_y = Goblin.Location.Y - 15 - hero_size / 2;
            hero_x2 = hero_x + hero_size;
            hero_y2 = hero_y + hero_size;
            //setting the worldborder
            int x_border = Screen.Location.X + Screen.Width, y_border = Screen.Location.Y + Screen.Height;
            Goblin.Location = new Point(Goblin.Location.X + hero_dx, Goblin.Location.Y + hero_dy);
            //kicking the player back into the arena
            if (!((0 < hero_x && 0 < hero_x2) && (x_border > hero_x && x_border > hero_x2)))
            {
                int temp_hero_dx;
                if (hero_x > 100)
                {
                    temp_hero_dx = -hero_speed;
                }
                else
                {
                    temp_hero_dx = hero_speed;
                }
                Goblin.Location = new Point(Goblin.Location.X + temp_hero_dx, Goblin.Location.Y);

            }
            if (!((0 < hero_y && 0 < hero_y2) && (y_border > hero_y && y_border > hero_y2)))
            {
                int temp_hero_dy;
                if (hero_y > 100)
                {
                    temp_hero_dy = -hero_speed;
                }
                else
                {
                    temp_hero_dy = hero_speed;
                }
                Goblin.Location = new Point(Goblin.Location.X, Goblin.Location.Y + temp_hero_dy);
            }
            //updating hp and shield
            Goblin.Text = hero_health.ToString();
            Goblin_shield.Text = hero_shield.ToString();
            Goblin_shield.Location = new Point(Goblin.Location.X, Goblin.Location.Y + 20);
            //updating score
            ++score;
            score_text.Text = "Очки: " + score.ToString();
            exp_text.Location = new Point(score_text.Location.X + score_text.Width + 6, score_text.Location.Y);
            exp_bar.Location = new Point(exp_text.Location.X + exp_text.Width + 6, exp_text.Location.Y);
            level_text.Location = new Point(exp_bar.Location.X + exp_bar.Width + 6, exp_bar.Location.Y);
        }

        //checking if an enemy is hit
        private void Screen_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_down = true;
            if (hero_counter > 0)
            {
                int cur_x = e.X;
                int cur_y = e.Y;
                for (int i = 0; i <= en_amount; ++i)
                {
                    if ((cur_x >= enemy_list[i].Location.X - en_size / 2 && cur_x <= enemy_list[i].Location.X - en_size / 2 + en_size) && (cur_y >= enemy_list[i].Location.Y - 15 - en_size / 2 && cur_y <= enemy_list[i].Location.Y - 15 - en_size / 2 + en_size))
                    {
                        enemy_list[i].Text = (Convert.ToInt32(enemy_list[i].Text) - hero_dmg).ToString();
                    }
                }

            }
        }
        private void Enemy_click(object sender, MouseEventArgs e)
        {
            int cur_x = Cursor.Position.X - this.Location.X - 32;
            int cur_y = Cursor.Position.Y - this.Location.Y - 30;
            for (int i = 0; i < enemy_list.Count; ++i)
            {
                if ((cur_x >= enemy_list[i].Location.X - en_size / 2 && cur_x <= enemy_list[i].Location.X - en_size / 2 + en_size) && (cur_y >= enemy_list[i].Location.Y - 15 - en_size / 2 && cur_y <= enemy_list[i].Location.Y - 15 - en_size / 2 + en_size))
                {
                    enemy_list[i].Text = (Convert.ToInt32(enemy_list[i].Text) - hero_dmg * 4).ToString();
                }
            }

        }
        private void Screen_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_down = false;
        }
        //shop summon
        private void Shop_time()
        {
            time.Enabled = false;
            Shop newShop = new Shop();
            newShop.ShowDialog();
            mouse_down = false;
            hero_shield = hero_defshield;
            time.Enabled = true;
            exp_text.Text = "Опыт: " + exp + "/" + exp_goal;
            exp_bar.Location = new Point(exp_text.Location.X + exp_text.Width + 6, exp_bar.Location.Y);
            exp_bar.CreateGraphics().Clear(Color.White);
            exp_bar.CreateGraphics().FillRectangle(exp_bar_pen.Brush, 0, 0, Convert.ToInt32(150 * Convert.ToDouble(exp) / exp_goal), 17);
        }

        //enemy spawning
        private void Enemy_spawn(object sender, EventArgs e)
        {
            ++spawn_counter;
            if (spawn_counter >= 125)//waiting until 125 iterations of a time tick pass(5 seconds)
            {
                spawn_counter = 0;
                //making the enemies harder
                ++difficulty;
                endefaulthp = 10 * (1 + (difficulty / 3));
                enspeed = (1 + (difficulty / 15));
                //summoning an enemy if needed
                if (difficulty >= enemy_list.Count && difficulty <= 35)
                {
                    Label enemy_grunt = new Label();
                    enemy_grunt.Size = new Size(25, 13);
                    enemy_grunt.MouseDown += Enemy_click;
                    enemy_grunt.TextAlign = ContentAlignment.MiddleCenter;
                    this.Controls.Add(enemy_grunt);
                    enemy_list.Add(enemy_grunt);
                }
                if (difficulty <= 35)
                {
                    en_amount = difficulty;
                }
                //randomising the spawn location
                int rnd1, rnd2;
                do
                {
                    rnd1 = rng.Next(-1, 2);
                    rnd2 = rng.Next(-1, 2);
                } while (rnd1 == rnd2 && rnd1 == 0);
                enemy_list[en_amount].Location = new Point(Goblin.Location.X + rng.Next(200, 401) * rnd1, Goblin.Location.Y + rng.Next(300, 371) * rnd2);
                enemy_list[en_amount].Text = endefaulthp.ToString();
                enemy_list[en_amount].BringToFront();
                enemy_list[en_amount].Visible = true;
            }
        }
        //enemy time update
        private void Enemy_update(object sender, EventArgs e)
        {
            ++fog_counter;
            for (int i = 0; i <= en_amount; ++i)
            {
                //getting the enemy position
                enx = enemy_list[i].Location.X - en_size / 2;
                eny = enemy_list[i].Location.Y - 15 - en_size / 2;
                //"moving" the enemy closer to the player
                if (Convert.ToInt32(enemy_list[i].Text) > 0)
                {
                    if (enx > hero_x)
                    {
                        enx -= enspeed;
                    }
                    else if (enx < hero_x)
                    {
                        enx += enspeed;
                    }
                    if (eny > hero_y)
                    {
                        eny -= enspeed;
                    }
                    else if (eny < hero_y)
                    {
                        eny += enspeed;
                    }
                    //actually moving the enemy
                    enx2 = enx + en_size;
                    eny2 = eny + en_size;
                    enemy_list[i].Location = new Point(
                    enx + en_size / 2,
                    eny + 15 + en_size / 2
                    );
                    //checking for collision with the player
                    if (((eny > hero_y && eny < hero_y2) || (eny2 > hero_y && eny2 < hero_y2)) && ((enx > hero_x && enx < hero_x2) || (enx2 > hero_x && enx2 < hero_x2)))
                    {
                        if (hero_shield > 0)
                        {
                            hero_shield -= 1;
                        }
                        else
                        {
                            hero_health -= 1;
                        }
                    }
                    if (mouse_down && hero_counter <= 0)
                    {
                        int cur_x = Cursor.Position.X - 8 - this.Location.X;
                        int cur_y = Cursor.Position.Y - 32 - this.Location.Y;
                        if ((cur_x >= enx + 8 && cur_x <= enx2 + 8) && (cur_y >= eny + 27 && cur_y <= eny2 + 27))
                        {
                            enemy_list[i].Text = (Convert.ToInt32(enemy_list[i].Text) - hero_dmg).ToString();
                        }
                    }
                    //checking for collision with the dagger(if it's ready)
                    if (dagger_cooldown <= 0)
                    {
                        if (((eny > hero_y - dagger_range && eny < hero_y2 + dagger_range) || (eny2 > hero_y - dagger_range && eny2 < hero_y2 + dagger_range)) && ((enx > hero_x - dagger_range && enx < hero_x2 + dagger_range) || (enx2 > hero_x - dagger_range && enx2 < hero_x2 + dagger_range)))
                        {
                            enemy_list[i].Text = (Convert.ToInt32(enemy_list[i].Text) - dagger_dmg).ToString();
                            dagger_cooldown = dagger_defcooldown;
                        }
                    }
                    else
                    {
                        --dagger_cooldown;
                    }
                    //getting hit by the fog
                    if (fog_counter >= fog_cooldown)
                    {
                        enemy_list[i].Text = (Convert.ToInt32(enemy_list[i].Text) - fog_dmg).ToString();
                    }

                }
                else
                {

                    //dying
                    score += (difficulty + 1) * 100;
                    ++exp;
                    exp_text.Text = "Опыт: " + exp + "/" + exp_goal;
                    exp_bar.CreateGraphics().Clear(Color.White);
                    exp_bar.CreateGraphics().FillRectangle(exp_bar_pen.Brush, 0, 0, Convert.ToInt32(150 * Convert.ToDouble(exp) / exp_goal), 17);
                    if (exp == exp_goal)
                    {
                        exp = 0;
                        exp_goal += 5;
                        ++level;
                        level_text.Text = level.ToString() + " уровень";
                        Shop_time();
                    }
                    int rnd1, rnd2;
                    do
                    {
                        rnd1 = rng.Next(-1, 2);
                        rnd2 = rng.Next(-1, 2);
                    } while (rnd1 == rnd2 && rnd1 == 0);
                    enemy_list[i].Location = new Point(Goblin.Location.X + rng.Next(200, 401) * rnd1, Goblin.Location.Y + rng.Next(200, 401) * rnd2);
                    enemy_list[i].Text = endefaulthp.ToString();

                }
            }         
            if(fog_counter >= fog_cooldown)
            {
                fog_counter = 0;
            }
            if (mouse_down && mouse_down && hero_counter <= 0)
            {
                hero_counter = hero_cooldown;
            }
            else
            {
                --hero_counter;
            }
        }
    }
}
