using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meeting_Notes
{
    public partial class Form1 : Form
    {

        

        TabControl Main_Tab_Control = new TabControl();
        public Form1()
        {
            InitializeComponent();
            Menu_Tab_Control.SelectTab(Search);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // this will make form load on current working monitor
            this.Location = Screen.AllScreens[1].WorkingArea.Location;

            // 아래 두 줄을 추가하면 SelectedTab 사용 시 Tab 전환이 안됨.
            //Menu_Tab_Control.TabPages.Remove(Configuration);
            //Menu_Tab_Control.TabPages.Remove(Search);

        }

        private void Top_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            var s = sender as Panel;
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
                return;

            s.Parent.Left = this.Left + (e.X - ((Point)s.Tag).X);
            s.Parent.Top = this.Top + (e.Y - ((Point)s.Tag).Y);
        }

        private void Top_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            var s = sender as Panel;
            s.Tag = new Point(e.X, e.Y);
        }

        private void Close_BT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Search_BT_Click(object sender, EventArgs e)
        {
            try
            {
                Menu_Tab_Control.SelectedTab = Search;
            }
            catch
            {
                Menu_Tab_Control.SelectedIndex = 0;
            }
            
        }

        private void Menu_Configuration_BT_Click(object sender, EventArgs e)
        {
            Menu_Tab_Control.SelectedTab = Configuration;
        }
    }
}
