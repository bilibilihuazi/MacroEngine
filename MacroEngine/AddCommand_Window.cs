using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroEngine
{
    public partial class AddCommand_Window : Form
    {
        public AddCommand_Window()
        {
            InitializeComponent();

            toolTip.SetToolTip(button_MOUSE_POS, "设置鼠标坐标\n参数:  pos-x:X坐标  pos-y:Y坐标");
            toolTip.SetToolTip(button_WAIT, "等待指定时间后再执行下一条命令(单位:ms)\n参数:  time:等待的时间");
            toolTip.SetToolTip(button_MOUSE_PRESS, "操作鼠标的按键\n参数:  key:按键，0左键 1中键 2右键  keytype: 0点击 1按下 2放开");
            toolTip.SetToolTip(button_MOUSE_WHEEL, "操作鼠标的滚轮\n参数:  dire:方向,0向上1向下  dis:滚动距离");
            toolTip.SetToolTip(button_KBD_PRESS, "操作键盘\n参数:  keytype:类型，0单击1按下2抬起  pkey:特殊按键,0无1.Shift 2.Ctrl 3.Alt  key:键");
        }

        private void button_MOUSE_POS_Click(object sender, EventArgs e)
        {
            MacroEditor_Window.AddW_TYPE = "MOUSE_POS";
            this.Close();
        }

        private void button_WAIT_Click(object sender, EventArgs e)
        {
            MacroEditor_Window.AddW_TYPE = "WAIT";
            this.Close();
        }

        private void button_MOUSE_PRESS_Click(object sender, EventArgs e)
        {
            MacroEditor_Window.AddW_TYPE = "MOUSE_PRESS";
            this.Close();
        }

        private void button_MOUSE_WHEEL_Click(object sender, EventArgs e)
        {
            MacroEditor_Window.AddW_TYPE = "MOUSE_WHEEL";
            this.Close();
        }

        private void button_KBD_PRESS_Click(object sender, EventArgs e)
        {
            MacroEditor_Window.AddW_TYPE = "KBD_PRESS";
            this.Close();
        }
    }
}
