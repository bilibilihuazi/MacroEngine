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
    public partial class AddSubCommand_Window : Form
    {
        public AddSubCommand_Window()
        {
            InitializeComponent();
        }

        private void button_SUB_FOR_Click(object sender, EventArgs e)
        {
            MacroEditor_Window.AddSubW_TYPE = "SUB_FOR";
            this.Close();
        }
    }
}
