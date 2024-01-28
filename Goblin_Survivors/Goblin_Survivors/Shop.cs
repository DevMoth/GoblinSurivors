using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Goblin_Survivors.Properties;

namespace Goblin_Survivors
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
            //adding all of the upgrade buttons and pictures to their lists
            upgrade.Add(upgrade1);
            upgrade.Add(upgrade2);
            upgrade.Add(upgrade3);
            upgrade_button.Add(upgrade1_button);
            upgrade_button.Add(upgrade2_button);
            upgrade_button.Add(upgrade3_button);
            upgrade_picture.Add(upgrade1_picture);
            upgrade_picture.Add(upgrade2_picture);
            upgrade_picture.Add(upgrade3_picture);
        }

        Random rng = new Random();
        List<GroupBox> upgrade = new List<GroupBox>();
        List<Button> upgrade_button = new List<Button>();
        List<PictureBox> upgrade_picture = new List<PictureBox>();
        int[] upgrade_choice = new int[3];
        int current_upgrade = 0;

        //filling in the stats and choosing 3 random upgrades
        private void Shop_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; ++i)//setting all of the upgrades to a non-reachable value
            {
                upgrade_choice[i] = 99;
            }
            for (int i = 0; i < 3; ++i)
            {
                bool duplicate = false;
                do//randomising one upgrade until it's unique from the others
                {
                    duplicate = false;
                    upgrade_choice[i] = rng.Next(9);
                    for (int j = 0; j < 3; ++j)
                    {
                        if (upgrade_choice[i] == upgrade_choice[j] && i != j)
                        {
                            duplicate = true;
                        }
                    }
                } while (duplicate);
                switch (upgrade_choice[i])//setting an upgrade choice
                {
                    case 0:
                        upgrade[i].Text = "Заточка наконечников болтов";
                        upgrade_button[i].Text = "+урон арбалета";
                        upgrade_picture[i].Image = Resources.arrow_upgrade;
                        break;
                    case 1:
                        upgrade[i].Text = "Полировка ботинок";
                        upgrade_button[i].Text = "+скорость";
                        upgrade_picture[i].Image = Resources.boots_upgrade;
                        break;
                    case 2:
                        upgrade[i].Text = "Улучшенная сыворотка тумана";
                        upgrade_button[i].Text = "+сила яда";
                        upgrade_picture[i].Image = Resources.fog_damage_upgrade;
                        break;
                    case 3:
                        upgrade[i].Text = "Укрепление щита";
                        upgrade_button[i].Text = "+100 к щиту";
                        upgrade_picture[i].Image = Resources.shield_upgrade;
                        break;
                    case 4:
                        upgrade[i].Text = "Заточка клинка";
                        upgrade_button[i].Text = "+урон вблизи";
                        upgrade_picture[i].Image = Resources.sword_damage_upgrade;
                        break;
                    case 5:
                        upgrade[i].Text = "Удлиненный клинок";
                        upgrade_button[i].Text = "+дальность атаки мечом";
                        upgrade_picture[i].Image = Resources.sword_distance_upgrade;
                        break;
                    case 6:
                        upgrade[i].Text = "Улучшенный баланс меча";
                        upgrade_button[i].Text = "+скорость атаки мечом";
                        upgrade_picture[i].Image = Resources.sword_speed_upgrade;
                        break;
                    case 7:
                        upgrade[i].Text = "Сгущение тумана";
                        upgrade_button[i].Text = "+скорость отравления врагов";
                        upgrade_picture[i].Image = Resources.fog_speed_upgrade;
                        break;
                    case 8:
                        upgrade[i].Text = "Оптимизированный механизм зарядки";
                        upgrade_button[i].Text = "+скорость автоатаки арбалетом";
                        upgrade_picture[i].Image = Resources.заманчиво;
                        break;
                }
            }//filling in the stats
            stats_sheet.Items.Add("Здоровье гоблина: " + MainForm.hero_health.ToString());
            stats_sheet.Items.Add("Прочность щита: " + MainForm.hero_defshield.ToString());
            stats_sheet.Items.Add("Сила болтов: " + MainForm.hero_dmg.ToString());
            stats_sheet.Items.Add("Частота выстрелов арбалета: " + (Convert.ToDouble(MainForm.hero_cooldown * 40) / 1000).ToString());
            stats_sheet.Items.Add("Сила меча: " + MainForm.dagger_dmg.ToString());
            stats_sheet.Items.Add("Длина клинка: " + MainForm.dagger_range.ToString());
            stats_sheet.Items.Add("Частота ударов клинка: " + (Convert.ToDouble(MainForm.dagger_defcooldown * 40) / 1000).ToString());
            stats_sheet.Items.Add("Сила ядовитого тумана: " + MainForm.fog_dmg.ToString());
            stats_sheet.Items.Add("Густота ядовитого тумана: " + (Convert.ToDouble(MainForm.fog_cooldown * 40) / 1000).ToString());
            stats_sheet.Items.Add("Скорость гоблина: " + MainForm.hero_speed.ToString());
        }

        //showing a certain description
        private void stats_sheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (stats_sheet.SelectedIndex)
            {
                case 0:
                    stat_description.Text = "Здоровье вашего персонажа. Вы проиграете, если оно достигнет нуля.";
                    break;
                case 1:
                    stat_description.Text = "Здоровье вашего крепкого щита. Оно тратиться вместо здоровья персонажа и обновляется с каждым уровнем.";
                    break;
                case 3:
                    stat_description.Text = "Промежуток между каждым авто выстрелом из арбалета(в секундах). Отдельные нажатия не имею задержки. Выстрел по голове не активирует автоатаку!";
                    break;
                case 2:
                    stat_description.Text = "Сила попаданий из вашего самодельного арбалета. Нажмите по врагу, чтобы атаковать его луком. Нажатие по полоске здоровья увеличить урон в 4 раза!";
                    break;
                case 4:
                    stat_description.Text = "Сила ударов вашим верным мечом. Враг будет автоматически получать повреждения, если подойдет к вам.";
                    break;
                case 5:
                    stat_description.Text = "Длина лезвия вашего верного клинка. Зона атаки мечом определяеться серой линией вокруг вас.";
                    break;
                case 6:
                    stat_description.Text = "Промежуток между каждой атакой мечом(в секундах). Меньше период = больше ударов = больше урона, все просто!";
                    break;
                case 7:
                    stat_description.Text = "Сила ядовитого тумана, рассеяного над полем битвы. Благодаря вашим гоблинским корням вы устойчивы к ядовитому туману. А враги нет, вот удача!";
                    break;
                case 8:
                    stat_description.Text = "Промежуток времени между повреждением врагов туманом(в секундах). капец, я не знаю че сюда писать... ну типа... ну... вейперы... типа... ахахахах...";
                    break;
                case 9:
                    stat_description.Text = "Скорость передвижения вашего персонажа. Враги будут постепенно становиться все быстрее и быстрее, что следует делать и вам тоже.";
                    break;

            }
        }

        //setting which upgrade to give
        private void upgrade1_button_Click(object sender, EventArgs e)
        {
            current_upgrade = upgrade_choice[0];
            Give_Upgrade();
        }
        private void upgrade2_button_Click(object sender, EventArgs e)
        {
            current_upgrade = upgrade_choice[1];
            Give_Upgrade();
        }
        private void upgrade3_button_Click(object sender, EventArgs e)
        {
            current_upgrade = upgrade_choice[2];
            Give_Upgrade();
        }
        //giving the upgrade
        private void Give_Upgrade()
        {
            switch (current_upgrade)
            {
                case 0:
                    MainForm.hero_dmg += 2;
                    this.Close();
                    break;
                case 1:
                    MainForm.hero_actual_speed += 5 / Convert.ToDouble(MainForm.hero_speed);
                    MainForm.hero_speed = Convert.ToInt32(MainForm.hero_actual_speed);
                    this.Close();
                    break;
                case 2:
                    MainForm.fog_dmg += 2;
                    this.Close();
                    break;
                case 3:
                    MainForm.hero_defshield += 100;
                    this.Close();
                    break;
                case 4:
                    MainForm.dagger_dmg += 5;
                    if (MainForm.dagger_range <= 0)
                    {
                        MainForm.dagger_range = 10;
                    }
                    this.Close();
                    break;
                case 5:
                    MainForm.dagger_range += 10;
                    if (MainForm.dagger_dmg <= 0)
                    {
                        MainForm.dagger_dmg = 2;
                    }
                    this.Close();
                    break;
                case 6:
                    MainForm.dagger_defcooldown = Convert.ToInt32(Convert.ToDouble(MainForm.dagger_defcooldown) * 0.9);
                    if (MainForm.dagger_dmg <= 0)
                    {
                        MainForm.dagger_range = 10;
                        MainForm.dagger_dmg = 2;
                    }
                    this.Close();
                    break;
                case 7:
                    MainForm.fog_cooldown = Convert.ToInt32(Convert.ToDouble(MainForm.fog_cooldown) * 0.9);
                    if (MainForm.fog_dmg <= 0)
                    {
                        MainForm.fog_dmg = 1;
                    }
                    this.Close();
                    break;
                case 8:
                    MainForm.hero_cooldown = Convert.ToInt32(Convert.ToDouble(MainForm.hero_cooldown) * 0.8);
                    this.Close();
                    break;
            }
        }
        //healing the player without upgrading
        private void close_button_Click(object sender, EventArgs e)
        {
            MainForm.hero_health += 300;
            if(MainForm.hero_health > 1000)
            {
                MainForm.hero_health = 1000;
            }
            this.Close();
        }
    }
}
