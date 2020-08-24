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
    public partial class Menu : Form
    {
        public class Info
        {
            public string HeroType;
            public string BackgroungMap;
        }
        public Menu()
        {
            InitializeComponent();
        }
        private void start_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            btnExit.Visible = false;
            btnBack.Visible = true;
            btnBegin.Visible = true;
            gMaps.Visible = true;
            gHeroes.Visible = true;
            rBoy.Visible = true;
            rMap1.Visible = true;
            rMap2.Visible = true;
            rMap3.Visible = true;
            rMap4.Visible = true;
            rMap5.Visible = true;
            rGrandmother.Visible = true;
            rBoy.Visible = true;
            rHomeless.Visible = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnStart.Visible = true;
            btnExit.Visible = true;
            gMaps.Visible = false;
            gHeroes.Visible = false;
            rBoy.Visible = false;
            rMap1.Visible = false;
            rMap2.Visible = false;
            rMap3.Visible = false;
            rMap4.Visible = false;
            rMap5.Visible = false;
            rGrandmother.Visible = false;
            rBoy.Visible = false;
            rHomeless.Visible = false;
            btnBack.Visible = false;
            btnBegin.Visible = false;
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            Info Data = new Info();
            if (rGrandmother.Checked == true)
                Data.HeroType = "Grandmother";
            else if (rBoy.Checked == true)
                Data.HeroType = "Boy";
            else
                Data.HeroType = "Homeless";
            if (rMap1.Checked == true)
                Data.BackgroungMap = "airport";
            else if (rMap2.Checked == true)
                Data.BackgroungMap = "library";
            else if (rMap3.Checked == true)
                Data.BackgroungMap = "BSTU";
            else if (rMap4.Checked == true)
                Data.BackgroungMap = "Park";
            else
                Data.BackgroungMap = "Sport";
            
            btnStart.Visible = true;
            btnExit.Visible = true;
            gMaps.Visible = false;
            gHeroes.Visible = false;
            rBoy.Visible = false;
            rMap1.Visible = false;
            rMap2.Visible = false;
            rMap3.Visible = false;
            rMap4.Visible = false;
            rMap5.Visible = false;
            rGrandmother.Visible = false;
            rBoy.Visible = false;
            rHomeless.Visible = false;
            btnBack.Visible = false;
            btnBegin.Visible = false;
            //TitleMenu.Text = Data.BackgroungMap;
            map1 frm = new map1(Data.HeroType, Data.BackgroungMap);
            frm.Show();
        }

       
    }
}
