using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Funcitons.NormalFunc;

namespace MacroEngine
{
    public partial class Pos_Window : Form
    {
        public Point pos;
        public Pos_Window()
        {
            InitializeComponent();
            this.Left = 0;
            this.Top = 0;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            panel_X.Width = this.Width;
            panel_X.Left = 0;
            panel_Y.Height = this.Height;
            panel_Y.Top = 0;
        }

        private void Pos_Window_MouseUp(object sender, MouseEventArgs e)
        {
            MacroEditor_Window.QuickSelectPos = m_GetPosition();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MacroEditor_Window.QuickSelectPos = m_GetPosition();
            this.Close();
        }

        private void Pos_Window_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel_X.Top = m_GetPosition().Y;
            panel_Y.Left = m_GetPosition().X;


            label2.Text = $"坐标：{m_GetPosition().X},{m_GetPosition().Y}";
            label2.Left = m_GetPosition().X + 10;
            label2.Top = m_GetPosition().Y + 10;
        }

        private void panel_X_MouseUp(object sender, MouseEventArgs e)
        {
            MacroEditor_Window.QuickSelectPos = m_GetPosition();
            this.Close();
        }

        private void panel_Y_MouseUp(object sender, MouseEventArgs e)
        {
            MacroEditor_Window.QuickSelectPos = m_GetPosition();
            this.Close();
        }
    }
}
