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
        public static string TYPE;

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

            pictureBox.Left = this.Width / 2 - pictureBox.Width / 2;
            pictureBox.Top = this.Height / 2 - pictureBox.Height / 2;


            
        }

        private void Pos_Window_MouseUp(object sender, MouseEventArgs e)
        {
            if (TYPE == "ABS")
            {
                MacroEditor_Window.QuickSelectPos = m_GetPosition();
                this.Close();
            }
            else if (TYPE == "RELA")
            {
                MacroEditor_Window.QuickSelectPos = new Point(m_GetPosition().X - pictureBox.Left, m_GetPosition().Y - pictureBox.Top);
                this.Close();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (TYPE == "ABS")
            {
                MacroEditor_Window.QuickSelectPos = m_GetPosition();
                this.Close();
            }
            else if (TYPE == "RELA")
            {
                MacroEditor_Window.QuickSelectPos = new Point(m_GetPosition().X - pictureBox.Left, m_GetPosition().Y - pictureBox.Top);
                this.Close();
            }
        }

        private void Pos_Window_Load(object sender, EventArgs e)
        {
            if (TYPE == "ABS")
            {
                this.Opacity = 0.25;
                pictureBox.Visible = false;
            }
            else if (TYPE == "RELA")
            {
                this.Opacity = 1;
                pictureBox.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel_X.Top = m_GetPosition().Y;
            panel_Y.Left = m_GetPosition().X;

            if (TYPE == "ABS")
            {
                label2.Text = $"坐标：{m_GetPosition().X},{m_GetPosition().Y}";

            }
            else if (TYPE == "RELA")
            {
                label2.Text = $"相对坐标：{m_GetPosition().X - pictureBox.Left},{m_GetPosition().Y - pictureBox.Top}";
            }


            label2.Left = m_GetPosition().X + 10;
            label2.Top = m_GetPosition().Y + 10;

        }

        private void panel_X_MouseUp(object sender, MouseEventArgs e)
        {
            if (TYPE == "ABS")
            {
                MacroEditor_Window.QuickSelectPos = m_GetPosition();
                this.Close();
            }
            else if (TYPE == "RELA")
            {
                MacroEditor_Window.QuickSelectPos = new Point(m_GetPosition().X - pictureBox.Left, m_GetPosition().Y - pictureBox.Top);
                this.Close();
            }
        }

        private void panel_Y_MouseUp(object sender, MouseEventArgs e)
        {
            if (TYPE == "ABS")
            {
                MacroEditor_Window.QuickSelectPos = m_GetPosition();
                this.Close();
            }
            else if (TYPE == "RELA")
            {
                MacroEditor_Window.QuickSelectPos = new Point(m_GetPosition().X - pictureBox.Left, m_GetPosition().Y - pictureBox.Top);
                this.Close();
            }
        }
    }
}
