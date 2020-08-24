using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CakeFuiry1
{
    public partial class map1 : Form
    {
        
        public map1(String Herotype, String BackgroundMap)
        {
            InitializeComponent();

            OHero.Text = "Hero: " + Herotype;
            OMap.Text = "Map: " + BackgroundMap;

            switch (BackgroundMap)
            {
                case "airport":
                    this.BackgroundImage = new Bitmap(Properties.Resources.airport);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "library":
                    this.BackgroundImage = new Bitmap(Properties.Resources.library);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "BSTU":
                    this.BackgroundImage = new Bitmap(Properties.Resources.BGTU);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "Park":
                    this.BackgroundImage = new Bitmap(Properties.Resources.park);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "Sport":
                    this.BackgroundImage = new Bitmap(Properties.Resources.sport);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
            }
            switch (Herotype)
            {
                case "Grandmother":
                    hero.Image = Properties.Resources.babka2;
                    Size sizegran1 = new Size(137, 185);
                    hero.Size = sizegran1;
                    Size sizeenemygran = new Size(137, 176);
                    enemy3.Size = sizeenemygran;
                    hero.Tag = 0;
                    
                    break;
                case "Boy":
                    hero.Image = Properties.Resources.shkolnik_23;
                    Size sizeboy = new Size(100, 222);
                    hero.Size = sizeboy;
                    Size sizeenemyboy = new Size(100, 222);
                    enemy3.Size = sizeenemyboy;
                    hero.Tag = 1;

                    break;
                case "Homeless":
                    hero.Image = Properties.Resources.bomj;
                    Size sizehomeless = new Size(70, 207);
                    hero.Size = sizehomeless;
                    Size sizeenemyhomeless = new Size(70, 207);
                    enemy3.Size = sizeenemyhomeless;
                    hero.Tag = 2;
                    break;
            }
        }
        int speed = 25;
        int margin = 5;
        bool game = true;
        int[] mass = new int[3];
        int score = 0;
        int enemyspeed = 20;
        private void track_Tick(object sender, EventArgs e)
        {
            if (game)
            {
                move();
                check();
            }
            else
            {
                hero.Visible = false;
                enemy1.Visible = false;
                enemy2.Visible = false;
                enemy3.Visible = false;
                OMap.Visible = false;
                Result.Visible = true;
                OHero.Visible = false;
                Result.Location = new Point(446, 270);
                track.Enabled = false;
                btnMenu.Visible = true;
                btnMenu.Enabled = true;
                this.BackgroundImage = new Bitmap(Properties.Resources.KONETs);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
        public void check()
        {
            String a, b,b1,b2;

            a = hero.Tag.ToString();
            if ((((hero.Top <= enemy1.Top) && (enemy1.Top + enemy1.Height <= hero.Top + hero.Height))|| ((hero.Top <= enemy1.Top + enemy1.Height) && (enemy1.Top + enemy1.Height <= hero.Top + hero.Height)) || ((enemy1.Top <= hero.Top + hero.Height) && ((enemy1.Top >= hero.Top))) || ((enemy1.Top <= hero.Top) && (hero.Top + hero.Height <= enemy1.Top + enemy1.Height))) && ((hero.Left <= enemy1.Width) && (hero.Left + hero.Width >= enemy1.Left)))
            {
                b = enemy1.Tag.ToString();
                game = comparison(a, b);
                if (!game)
                    return;

            }
            if ((((hero.Top <= enemy2.Top) && (enemy2.Top + enemy2.Height <= hero.Top + hero.Height))|| ((enemy2.Top + enemy2.Height >= hero.Top) && (hero.Top + hero.Height >= enemy2.Top + enemy2.Height)) || ((hero.Top <= enemy2.Top + enemy2.Height) && (enemy2.Top + enemy2.Height <= hero.Top + hero.Height)) || ((enemy2.Top <= hero.Top + hero.Height) && ((enemy2.Top >= hero.Top))) || ((enemy2.Top <= hero.Top) && (hero.Top + hero.Height <= enemy2.Top + enemy2.Height))) && ((hero.Left <= enemy2.Width) && (hero.Left + hero.Width >= enemy2.Left)))
            {   b1 = enemy2.Tag.ToString();
                game = comparison(a, b1);
                if (!game)
                    return;
            }
            if ((((hero.Top <= enemy3.Top) && (enemy3.Top + enemy3.Height <= hero.Top + hero.Height))|| ((enemy3.Top + enemy3.Height >= hero.Top) && (hero.Top + hero.Height >= enemy3.Top + enemy3.Height)) || ((hero.Top <= enemy3.Top + enemy3.Height) && (enemy3.Top + enemy3.Height <= hero.Top + hero.Height)) || ((enemy3.Top <= hero.Top + hero.Height) && ((enemy3.Top >= hero.Top))) || ((enemy3.Top <= hero.Top) && (hero.Top + hero.Height <= enemy3.Top + enemy3.Height))) && ((hero.Left <= enemy3.Width) && (hero.Left + hero.Width >= enemy3.Left)))
            {
                b2 = enemy3.Tag.ToString();
                game = comparison(a, b2);
                if (!game)
                    return;
            }

        }
        public bool comparison(String a, String b)
        {
            if (a == b)
                return true;
            if ((a == "0") && (b == "1"))
            {
                score++;
                Result.Text = "Score: " + score;
                return true;
            }
            if ((a == "0") && (b == "0"))
            {
                return true;
            }
            if ((a == "0") && (b == "2"))
                return false;
            if ((a == "1") && (b == "0"))
                return false;
            if ((a == "1") && (b == "2"))
            {
                score++;
                Result.Text = "Score: " + score;
                return true;
            }
            if ((a == "2") && (b == "0"))
            {
                score++;
                Result.Text = "Score: " + score;
                return true;
            }
            if ((a == "2") && (b == "1"))
                return false;
            if ((a == "2") && (b == "2"))
            {
                return true;
            }
            return true;
        }
       
        public void move()
        {
            enemy1.Left -=enemyspeed;
            enemy2.Left -=enemyspeed;
            enemy3.Left -=enemyspeed;
            if (enemy1.Left < -200)
            {
                enter();
                SizeWH();
                enemy1.Location = new Point(1366, margin);
                margin += enemy1.Height + 40;
                enemy2.Location = new Point(1366, margin);
                margin += enemy2.Height + 20;
                enemy3.Location = new Point(1366, margin);
                margin = 5;
                
            }
        }

        public void enter()
        {
            
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                mass[i] = rnd.Next(0, 4);
            }
        }
        public void SizeWH()
        {
            for (int j = 0; j < 1; j++) // enemy123 
            {
                if (mass[j] == 0)
                {
                    enemy1.Image = Properties.Resources.babka;
                    Size sizeenemygran = new Size(137, 176);
                    enemy1.Size = sizeenemygran;
                    enemy1.Tag = 0;
                }
                if (mass[j] == 1)
                {
                    enemy1.Image = Properties.Resources.shkola;
                    Size sizeenemyboy = new Size(100, 222);
                    enemy1.Size = sizeenemyboy;
                    enemy1.Tag = 1;
                }
                if (mass[j] == 2)
                {
                    enemy1.Image = Properties.Resources.bomj;
                    Size sizeenemyhomeless = new Size(70, 207);
                    enemy1.Size = sizeenemyhomeless;
                    enemy1.Tag = 2;
                }
                if (mass[j] == 3)
                {
                    enemy1.Image = null;
                    Size sizeenemygran = new Size(0, 207);
                    enemy1.Size = sizeenemygran;
                    enemy1.Tag = 3;
                }
            }
            for (int j = 1; j < 2; j++) //enemy12 
            {
                if (mass[j] == 0)
                {
                    enemy2.Image = Properties.Resources.babka;
                    Size sizeenemygran = new Size(137, 176);
                    enemy2.Size = sizeenemygran;
                    enemy2.Tag = 0;
                }
                if (mass[j] == 1)
                {
                    enemy2.Image = Properties.Resources.shkola;
                    Size sizeenemyboy = new Size(100, 222);
                    enemy2.Size = sizeenemyboy;
                    enemy2.Tag = 1;
                }
                if (mass[j] == 2)
                {
                    enemy2.Image = Properties.Resources.bomj;
                    Size sizeenemyhomeless = new Size(70, 207);
                    enemy2.Size = sizeenemyhomeless;
                    enemy2.Tag = 2;
                }
                if (mass[j] == 3)
                {
                    enemy2.Image = null;
                    Size sizeenemygran = new Size(0, 207);
                    enemy2.Size = sizeenemygran;
                    enemy2.Tag = 3;
                }
            }
            for (int j = 2; j < 3; j++)
            {
                if (mass[j] == 0)
                {
                    enemy3.Image = Properties.Resources.babka;
                    Size sizeenemygran = new Size(137, 176);
                    enemy3.Size = sizeenemygran;
                    enemy3.Tag = 0;
                }
                if (mass[j] == 1)
                {
                    enemy3.Image = Properties.Resources.shkola;
                    Size sizeenemyboy = new Size(100, 222);
                    enemy3.Size = sizeenemyboy;
                    enemy3.Tag = 1;
                }
                if (mass[j] == 2)
                {
                    enemy3.Image = Properties.Resources.bomj;
                    Size sizeenemyhomeless = new Size(70, 207);
                    enemy3.Size = sizeenemyhomeless;
                    enemy3.Tag = 2;
                }
                if (mass[j] == 3)
                {
                    enemy3.Image = null;
                   Size sizeenemygran = new Size(0, 207);
                    enemy3.Size = sizeenemygran;
                    enemy3.Tag = 3;
                }
            }
        }
        private void map1_Load(object sender, EventArgs e)
        {
            enter();
            SizeWH();
            enemy1.Location = new Point(1366, margin);
            margin += enemy1.Height + 20;
            enemy2.Location = new Point(1366, margin);
            margin += enemy2.Height + 20;
            enemy3.Location = new Point(1366, margin);
            margin = 5;
            Result.Text = "Score: " + score;
        }

        private void map1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (game)
            switch (e.KeyChar)
            {
                case 's':
                    hero.Top += speed;
                    break;
                case 'w':
                        hero.Top -= speed;
                    break;
                
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTryAgain_Click(object sender, EventArgs e)
        {

            enter();
            SizeWH();
            enemy1.Location = new Point(1366, margin);
            margin += enemy1.Height + 20;
            enemy2.Location = new Point(1366, margin);
            margin += enemy2.Height + 20;
            enemy3.Location = new Point(1366, margin);
            margin = 5;
            Result.Text = "Score: " + score;
        }

    }
}

