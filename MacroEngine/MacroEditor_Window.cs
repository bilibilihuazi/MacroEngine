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
using Funcitons;
using System.IO;
using static MacroEngine.Controls.HotkeyTextBox;

namespace MacroEngine
{
    public partial class MacroEditor_Window : Form
    {
        public void LoadCommandList()
        {

            Path = $"{Main_Window.RunPath}\\Macros\\{Main_Window.Editor_NOWMACRO}.ini";
            

            if (Main_Window.Editor_TYPE == "Create")
            {
                if (File.Exists(tempPath))
                {
                    File.Delete(tempPath);
                }

                WriteConfig(tempPath, "info", "Title", "新建宏");
                WriteConfig(tempPath, "info", "Text", "新建宏，作用只是将鼠标从屏幕左上角移至右下角...");
                WriteConfig(tempPath, "info", "Enabled", "false");
                WriteConfig(tempPath, "info", "Key", "F1");
                WriteConfig(tempPath, "info", "Step", "3");

                WriteConfig(tempPath, "1", "type", "MOUSE_POS");
                WriteConfig(tempPath, "1", "pos-x", "0");
                WriteConfig(tempPath, "1", "pos-y", "0");

                WriteConfig(tempPath, "2", "type", "WAIT");
                WriteConfig(tempPath, "2", "time", "2000");

                WriteConfig(tempPath, "3", "type", "MOUSE_POS");
                WriteConfig(tempPath, "3", "pos-x", $"{Screen.PrimaryScreen.Bounds.Width}");
                WriteConfig(tempPath, "3", "pos-y", $"{Screen.PrimaryScreen.Bounds.Height}");

                textBox_Path.Enabled = true;
                textBox_Path.Text = $"{Main_Window.MacroDir}\\NewMacro.ini";

            }
            else if (Main_Window.Editor_TYPE == "Edit") 
            {
                try
                {
                    if(File.Exists(tempPath))
                    {
                        
                        File.Delete(tempPath);
                    }
                    File.WriteAllText(tempPath, File.ReadAllText(Path));


                    textBox_Path.Enabled = false;
                    textBox_Path.Text = Path;



                }
                catch (Exception ex)
                {
                    MessageBox.Show($"在读取脚本信息时发生错误！\n\n错误原因：{ex.Message}", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            try
            {
                textBox_title.Text = ReadConfig(tempPath, "info", "Title");
                textBox_text.Text = ReadConfig(tempPath, "info", "Text");

                hotkeyTextBox.Hotkey = (Keys)Enum.Parse(typeof(Keys), ReadConfig(tempPath, "info", "Key"));



                listBox_MacroList.Items.Clear();
                for (int i = 0; i < int.Parse(ReadConfig(tempPath, "info", "Step")); i++)
                {
                    string StepType = ReadConfig(tempPath, $"{i + 1}", "type");

                    //===============================================================================================================

                    if (StepType == "MOUSE_POS")            //             <========此处修改
                    {
                        listBox_MacroList.Items.Add("鼠标_置坐标");
                    }
                    else if (StepType == "WAIT")
                    {
                        listBox_MacroList.Items.Add("等待");
                    }
                    else if (StepType == "MOUSE_PRESS")
                    {
                        listBox_MacroList.Items.Add("鼠标_按键");
                    }
                    else if (StepType == "MOUSE_WHEEL")
                    {
                        listBox_MacroList.Items.Add("鼠标_滚轮");
                    }
                    else if (StepType == "KBD_PRESS") 
                    {
                        listBox_MacroList.Items.Add("键盘_按键");
                    }

                    else
                    {
                        listBox_MacroList.Items.Add("未知的指令");
                    }


                    //===============================================================================================================

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"在读取脚本信息时发生错误！\n\n错误原因：{ex.Message}", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }



        public static string Path = $"{Main_Window.MacroDir}\\{Main_Window.Editor_NOWMACRO}.ini";
        public static string tempPath = $"C:\\Users\\Administrator\\AppData\\Local\\Temp\\tempConfig.ini";

        public static string AddW_TYPE = "UNKNOWN";

        public static Point QuickSelectPos;
        


        public MacroEditor_Window()
        {
            InitializeComponent();
            tabControl_Edit.ItemSize = new Size(0, 1);

            Path = $"{Main_Window.RunPath}\\Macros\\{Main_Window.Editor_NOWMACRO}.ini";
            LoadCommandList();




        }

        private void listBox_MacroList_SelectedIndexChanged(object sender, EventArgs e)
        {

            //===============================================================================================================




            if (listBox_MacroList.Text == "鼠标_置坐标")         //             <========此处修改
            {
                tabControl_Edit.SelectedIndex = 1;
                numericUpDown_MOUSE_POS_x.Value = int.Parse(ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "pos-x"));
                numericUpDown_MOUSE_POS_y.Value = int.Parse(ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "pos-y"));
            }
            else if (listBox_MacroList.Text == "等待")
            {
                tabControl_Edit.SelectedIndex = 2;
                numericUpDown_WAIT_time.Value = int.Parse(ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "time"));
            }
            else if (listBox_MacroList.Text == "鼠标_按键")
            {
                tabControl_Edit.SelectedIndex = 3;

                comboBox_MOUSE_PRESS_key.SelectedIndex = int.Parse(ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "key"));
                comboBox_MOUSE_PRESS_keytype.SelectedIndex = int.Parse(ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "keytype"));
            }
            else if (listBox_MacroList.Text == "鼠标_滚轮")
            {
                tabControl_Edit.SelectedIndex = 4;

                comboBox_MOUSE_WHELL_dire.SelectedIndex = int.Parse(ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "dire"));
                numericUpDown_MOUSE_WHELL_dis.Value = int.Parse(ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "dis"));
            }
            else if (listBox_MacroList.Text == "键盘_按键")
            {
                tabControl_Edit.SelectedIndex = 5;

                comboBox_KBD_PRESS_keytype.SelectedIndex = int.Parse(ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "keytype"));
                hotkeyTextBox_KBD_PRESS_key.Hotkey = (Keys)Enum.Parse(typeof(Keys), ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "key"));
            }



            //===============================================================================================================





            else
            {
                tabControl_Edit.SelectedIndex = 0;
            }


            if (listBox_MacroList.SelectedIndex != -1)
            {
                if (listBox_MacroList.SelectedIndex == 0)
                {
                    button_Up.Enabled = false;
                }
                else
                {
                    button_Up.Enabled = true;
                }

                if (listBox_MacroList.SelectedIndex == listBox_MacroList.Items.Count - 1)
                {
                    button_Down.Enabled = false;
                }
                else
                {
                    button_Down.Enabled = true;
                }
                button_Remove.Enabled = true;
            }
            else
            {
                button_Down.Enabled = false;
                button_Up.Enabled = false;
                button_Remove.Enabled = false;
            }
        }

        private void MacroEditor_Window_Load(object sender, EventArgs e)
        {
            Path = $"{Main_Window.RunPath}\\Macros\\{Main_Window.Editor_NOWMACRO}.ini";

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Main_Window.Editor_TYPE == "Create")
                {
                    File.Copy(tempPath, textBox_Path.Text);

                }
                else if(Main_Window.Editor_TYPE=="Edit")
                {
                    File.WriteAllText(Path, File.ReadAllText(tempPath));
                    
                }

                WriteConfig(Path, "info", "Key", hotkeyTextBox.Hotkey.ToString());
                WriteConfig(Path, "info", "Step", $"{listBox_MacroList.Items.Count}");

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"在更新配置文件时发生错误！\n\n错误原因：{ex.Message}", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void numericUpDown_MOUSE_POS_x_ValueChanged(object sender, EventArgs e)
        {
            WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "pos-x", $"{numericUpDown_MOUSE_POS_x.Value}");
        }

        private void numericUpDown_MOUSE_POS_y_ValueChanged(object sender, EventArgs e)
        {
            WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "pos-y", $"{numericUpDown_MOUSE_POS_y.Value}");
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown_WAIT_time_ValueChanged(object sender, EventArgs e)
        {
            WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "time", $"{numericUpDown_WAIT_time.Value}");
        }

        private void textBox_title_TextChanged(object sender, EventArgs e)
        {
            WriteConfig(tempPath, "info", "Title", $"{textBox_title.Text}");
        }

        private void textBox_text_TextChanged(object sender, EventArgs e)
        {
            WriteConfig(tempPath, "info", "Text", $"{textBox_text.Text}");
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            using(AddCommand_Window addCommand_Window =new AddCommand_Window())
            {
                addCommand_Window.ShowDialog();
            }

            //===============================================================================================================



            if (AddW_TYPE == "MOUSE_POS")                  //             <========此处修改==========================================================
            {
                WriteConfig(tempPath, $"{listBox_MacroList.Items.Count + 1}", "type", "MOUSE_POS");
                WriteConfig(tempPath, $"{listBox_MacroList.Items.Count + 1}", "pos-x", "0");
                WriteConfig(tempPath, $"{listBox_MacroList.Items.Count + 1}", "pos-y", "0");
                listBox_MacroList.Items.Add("鼠标_置坐标");

            }
            else if (AddW_TYPE == "WAIT")
            {
                WriteConfig(tempPath, $"{listBox_MacroList.Items.Count + 1}", "type", "WAIT");
                WriteConfig(tempPath, $"{listBox_MacroList.Items.Count + 1}", "time", "100");
                listBox_MacroList.Items.Add("等待");
            }
            else if (AddW_TYPE == "MOUSE_PRESS")
            {
                WriteConfig(tempPath, $"{listBox_MacroList.Items.Count + 1}", "type", "MOUSE_PRESS");
                WriteConfig(tempPath, $"{listBox_MacroList.Items.Count + 1}", "key", "0");
                WriteConfig(tempPath, $"{listBox_MacroList.Items.Count + 1}", "keytype", "0");
                listBox_MacroList.Items.Add("鼠标_按键");
            }
            else if (AddW_TYPE == "MOUSE_WHEEL")
            {
                WriteConfig(tempPath, $"{listBox_MacroList.Items.Count + 1}", "type", "MOUSE_WHEEL");
                WriteConfig(tempPath, $"{listBox_MacroList.Items.Count + 1}", "dire", "0");
                WriteConfig(tempPath, $"{listBox_MacroList.Items.Count + 1}", "dis", "10");
                listBox_MacroList.Items.Add("鼠标_滚轮");
            }
            else if (AddW_TYPE == "KBD_PRESS")
            {
                WriteConfig(tempPath, $"{listBox_MacroList.Items.Count + 1}", "type", "KBD_PRESS");
                WriteConfig(tempPath, $"{listBox_MacroList.Items.Count + 1}", "keytype", "0");
                WriteConfig(tempPath, $"{listBox_MacroList.Items.Count + 1}", "key", "A");
                listBox_MacroList.Items.Add("键盘_按键");
            }



            //===============================================================================================================






            if (AddW_TYPE != "UNKNOWN")
            {
                WriteConfig(tempPath, "info", "Step", $"{int.Parse(ReadConfig(tempPath, "info", "Step")) + 1}");
            }

            listBox_MacroList.SelectedIndex = listBox_MacroList.Items.Count - 1;

            AddW_TYPE = "UNKNOWN";
        }

        private void button_Up_Click(object sender, EventArgs e)
        {
            try
            {
                string tempTYPE = ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex}", "type");
                string tempNowTYPE = ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "type");

                //===============================================================================================================


                WriteConfig(tempPath, "temp", "type", $"{tempTYPE}");

                if (tempTYPE == "MOUSE_POS")              //             <========此处修改==========================================================
                {
                    WriteConfig(tempPath, "temp", "pos-x", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex}", "pos-x"));
                    WriteConfig(tempPath, "temp", "pos-y", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex}", "pos-y"));
                }
                else if (tempTYPE == "WAIT")
                {
                    WriteConfig(tempPath, "temp", "time", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex}", "time"));
                }
                else if (tempTYPE == "MOUSE_PRESS")
                {
                    WriteConfig(tempPath, "temp", "key", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex}", "key"));
                    WriteConfig(tempPath, "temp", "keytype", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex}", "keytype"));
                }
                else if (tempTYPE == "MOUSE_WHEEL")
                {
                    WriteConfig(tempPath, "temp", "dire", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex}", "dire"));
                    WriteConfig(tempPath, "temp", "dis", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex}", "dis"));
                }
                else if (tempTYPE == "KBD_PRESS")
                {
                    WriteConfig(tempPath, "temp", "keytype", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex}", "keytype"));
                    WriteConfig(tempPath, "temp", "key", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex}", "key"));
                }

                //===============================================================================================================


                WriteConfig(tempPath, "temp2", "type", $"{tempNowTYPE}");

                if (tempNowTYPE == "MOUSE_POS")   //             <========此处修改==========================================================
                {
                    WriteConfig(tempPath, "temp2", "pos-x", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "pos-x"));
                    WriteConfig(tempPath, "temp2", "pos-y", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "pos-y"));
                }
                else if (tempNowTYPE == "WAIT")
                {
                    WriteConfig(tempPath, "temp2", "time", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "time"));
                }
                else if (tempNowTYPE == "MOUSE_PRESS")
                {
                    WriteConfig(tempPath, "temp2", "key", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "key"));
                    WriteConfig(tempPath, "temp2", "keytype", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "keytype"));
                }
                else if (tempNowTYPE == "MOUSE_WHEEL")
                {
                    WriteConfig(tempPath, "temp2", "dire", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "dire"));
                    WriteConfig(tempPath, "temp2", "dis", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "dis"));
                }
                else if (tempNowTYPE == "KBD_PRESS")
                {
                    WriteConfig(tempPath, "temp2", "keytype", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "keytype"));
                    WriteConfig(tempPath, "temp2", "key", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "key"));
                }

                //===============================================================================================================

                DeleteSection(tempPath, $"{listBox_MacroList.SelectedIndex}");
                DeleteSection(tempPath, $"{listBox_MacroList.SelectedIndex + 1}");

                WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex}", "type", tempNowTYPE);

                if (tempNowTYPE == "MOUSE_POS")      //             <========此处修改==========================================================
                {
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex}", "pos-x", ReadConfig(tempPath, "temp2", "pos-x"));
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex}", "pos-y", ReadConfig(tempPath, "temp2", "pos-y"));
                }
                else if (tempNowTYPE == "WAIT")
                {
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex}", "time", ReadConfig(tempPath, "temp2", "time"));
                }
                else if (tempNowTYPE == "MOUSE_PRESS")
                {
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex}", "key", ReadConfig(tempPath, "temp2", "key"));
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex}", "keytype", ReadConfig(tempPath, "temp2", "keytype"));
                }
                else if (tempNowTYPE == "MOUSE_WHEEL")
                {
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex}", "dire", ReadConfig(tempPath, "temp2", "dire"));
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex}", "dis", ReadConfig(tempPath, "temp2", "dis"));
                }
                else if (tempNowTYPE == "KBD_PRESS")
                {
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex}", "keytype", ReadConfig(tempPath, "temp2", "keytype"));
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex}", "key", ReadConfig(tempPath, "temp2", "key"));
                }

                //===============================================================================================================

                WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "type", tempTYPE);

                if (tempTYPE == "MOUSE_POS")            //             <========此处修改==========================================================
                {
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "pos-x", ReadConfig(tempPath, "temp", "pos-x"));
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "pos-y", ReadConfig(tempPath, "temp", "pos-y"));
                }
                else if (tempTYPE == "WAIT")
                {
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "time", ReadConfig(tempPath, "temp", "time"));

                }
                else if (tempTYPE == "MOUSE_PRESS")
                {
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "key", ReadConfig(tempPath, "temp", "key"));
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "keytype", ReadConfig(tempPath, "temp", "keytype"));

                }
                else if (tempTYPE == "MOUSE_WHEEL")
                {
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "dire", ReadConfig(tempPath, "temp", "dire"));
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "dis", ReadConfig(tempPath, "temp", "dis"));

                }
                else if (tempTYPE == "KBD_PRESS")
                {
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "keytype", ReadConfig(tempPath, "temp", "keytype"));
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "key", ReadConfig(tempPath, "temp", "key"));

                }


                //===============================================================================================================



                DeleteSection(tempPath, "temp");
                DeleteSection(tempPath, "temp2");

                int currentIndex = listBox_MacroList.SelectedIndex;
                object currentItem = listBox_MacroList.SelectedItem;
                object previousItem = listBox_MacroList.Items[currentIndex - 1];

                // 交换位置
                listBox_MacroList.Items.RemoveAt(currentIndex);
                listBox_MacroList.Items.RemoveAt(currentIndex - 1);

                // 插入交换后的项
                listBox_MacroList.Items.Insert(currentIndex - 1, currentItem);
                listBox_MacroList.Items.Insert(currentIndex, previousItem);

                // 重新选中原项
                listBox_MacroList.SelectedIndex = currentIndex - 1;


                //LoadCommandList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"在移动指令顺序时发生错误！\n\n错误原因：{ex.Message}", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
        }

        private void button_Down_Click(object sender, EventArgs e)
        {
            try
            {
                string tempTYPE = ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex+2}", "type");
                string tempNowTYPE = ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "type");



                WriteConfig(tempPath, "temp", "type", $"{tempTYPE}");

                if (tempTYPE == "MOUSE_POS")      //             <========此处修改==========================================================
                {
                    WriteConfig(tempPath, "temp", "pos-x", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex+2}", "pos-x"));
                    WriteConfig(tempPath, "temp", "pos-y", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex+2}", "pos-y"));
                }
                else if (tempTYPE == "WAIT")
                {
                    WriteConfig(tempPath, "temp", "time", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex+2}", "time"));
                }
                else if (tempTYPE == "MOUSE_PRESS")
                {
                    WriteConfig(tempPath, "temp", "key", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2}", "key"));
                    WriteConfig(tempPath, "temp", "keytype", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2}", "keytype"));
                }
                else if (tempTYPE == "MOUSE_WHEEL")
                {
                    WriteConfig(tempPath, "temp", "dire", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2}", "dire"));
                    WriteConfig(tempPath, "temp", "dis", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2}", "dis"));
                }

                //===============================================================================================================

                WriteConfig(tempPath, "temp2", "type", $"{tempNowTYPE}");

                if (tempNowTYPE == "MOUSE_POS")       //             <========此处修改==========================================================
                {
                    WriteConfig(tempPath, "temp2", "pos-x", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "pos-x"));
                    WriteConfig(tempPath, "temp2", "pos-y", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "pos-y"));
                }
                else if (tempNowTYPE == "WAIT")
                {
                    WriteConfig(tempPath, "temp2", "time", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "time"));
                }
                else if (tempNowTYPE == "MOUSE_PRESS")
                {
                    WriteConfig(tempPath, "temp2", "key", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "key"));
                    WriteConfig(tempPath, "temp2", "keytype", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "keytype"));
                }
                else if (tempNowTYPE == "MOUSE_WHEEL")
                {
                    WriteConfig(tempPath, "temp2", "dire", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "dire"));
                    WriteConfig(tempPath, "temp2", "dis", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "dis"));
                }
                else if (tempNowTYPE == "KBD_PRESS")
                {
                    WriteConfig(tempPath, "temp2", "keytype", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "type"));
                    WriteConfig(tempPath, "temp2", "key", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "key"));
                }


                //===============================================================================================================

                DeleteSection(tempPath, $"{listBox_MacroList.SelectedIndex+2}");
                DeleteSection(tempPath, $"{listBox_MacroList.SelectedIndex + 1}");

                WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex+2}", "type", tempNowTYPE);

                if (tempNowTYPE == "MOUSE_POS")  //             <========此处修改==========================================================
                {
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex+2}", "pos-x", ReadConfig(tempPath, "temp2", "pos-x"));
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex+2}", "pos-y", ReadConfig(tempPath, "temp2", "pos-y"));
                }
                else if (tempNowTYPE == "WAIT")
                {
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex+2}", "time", ReadConfig(tempPath, "temp2", "time"));
                }
                else if (tempNowTYPE == "MOUSE_PRESS")
                {
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2}", "key", ReadConfig(tempPath, "temp2", "key"));
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2}", "keytype", ReadConfig(tempPath, "temp2", "keytype"));
                }
                else if (tempNowTYPE == "MOUSE_WHEEL")
                {
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2}", "dire", ReadConfig(tempPath, "temp2", "dire"));
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2}", "dis", ReadConfig(tempPath, "temp2", "dis"));
                }
                else if (tempNowTYPE == "KBD_PRESS")
                {
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2}", "keytype", ReadConfig(tempPath, "temp2", "keytype"));
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2}", "key", ReadConfig(tempPath, "temp2", "key"));
                }

                //===============================================================================================================

                WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "type", tempTYPE);

                if (tempTYPE == "MOUSE_POS")//             <========此处修改==========================================================
                {
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "pos-x", ReadConfig(tempPath, "temp", "pos-x"));
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "pos-y", ReadConfig(tempPath, "temp", "pos-y"));
                }
                else if (tempTYPE == "WAIT")
                {
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "time", ReadConfig(tempPath, "temp", "time"));

                }
                else if (tempTYPE == "MOUSE_PRESS")
                {
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "key", ReadConfig(tempPath, "temp", "key"));
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "keytype", ReadConfig(tempPath, "temp", "keytype"));

                }
                else if (tempTYPE == "MOUSE_WHEEL")
                {
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "dire", ReadConfig(tempPath, "temp", "dire"));
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "dis", ReadConfig(tempPath, "temp", "dis"));

                }
                else if (tempTYPE == "KBD_PRESS")
                {
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "keytype", ReadConfig(tempPath, "temp", "keytype"));
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "key", ReadConfig(tempPath, "temp", "key"));

                }


                DeleteSection(tempPath, "temp");
                DeleteSection(tempPath, "temp2");

                


                //LoadCommandList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"在移动指令顺序时发生错误！\n\n错误原因：{ex.Message}", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            int currentIndex = listBox_MacroList.SelectedIndex;
            object currentItem = listBox_MacroList.SelectedItem;
            object previousItem = listBox_MacroList.Items[currentIndex + 1];

            // 交换位置
            listBox_MacroList.Items.RemoveAt(currentIndex + 1);
            listBox_MacroList.Items.RemoveAt(currentIndex);
            

            // 插入交换后的项
            listBox_MacroList.Items.Insert(currentIndex, previousItem);
            listBox_MacroList.Items.Insert(currentIndex + 1, currentItem);

            // 重新选中原项
            listBox_MacroList.SelectedIndex = currentIndex + 1;
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteSection(tempPath, $"{listBox_MacroList.SelectedIndex + 1}");

                for (int i = 0; i < int.Parse(ReadConfig(tempPath, "info", "Step")) - listBox_MacroList.SelectedIndex - 1; i++)
                {


                    string temp = ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2 + i}", "type");

                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1 + i}", "type", temp);

                    //===============================================================================================================

                    if (temp == "MOUSE_POS")    //             <========此处修改==========================================================
                    {
                        WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1 + i}", "pos-x", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2 + i}", "pos-x"));
                        WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1 + i}", "pos-y", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2 + i}", "pos-y"));
                    }
                    else if (temp == "WAIT")
                    {
                        WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1 + i}", "time", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2 + i}", "time"));
                    }
                    else if (temp == "MOUSE_PRESS")
                    {
                        WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1 + i}", "key", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2 + i}", "key"));
                        WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1 + i}", "keytype", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2 + i}", "keytype"));
                    }
                    else if (temp == "MOUSE_WHEEL")
                    {
                        WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1 + i}", "dire", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2 + i}", "dire"));
                        WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1 + i}", "dis", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2 + i}", "dis"));
                    }
                    else if (temp == "KBD_PRESS")
                    {
                        WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1 + i}", "keytype", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2 + i}", "keytype"));
                        WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1 + i}", "key", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2 + i}", "key"));
                    }



                    //===============================================================================================================

                    DeleteSection(tempPath, $"{listBox_MacroList.SelectedIndex + 2 + i}");




                }
                WriteConfig(tempPath, "info", "Step", $"{int.Parse(ReadConfig(tempPath, "info", "Step")) - 1}");

                
                listBox_MacroList.Items.RemoveAt(listBox_MacroList.SelectedIndex);


                if (listBox_MacroList.Items.Count > 0)
                {
                    listBox_MacroList.SelectedIndex = 0;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"在删除指令时发生错误！\n\n错误原因：{ex.Message}", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void MacroEditor_Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();

            textBox_Path.Text = "";
            textBox_text.Text = "";
            textBox_title.Text = "";
        }

        private void MacroEditor_Window_Activated(object sender, EventArgs e)
        {
            
        }

        private void comboBox_MOUSE_PRESS_key_SelectedIndexChanged(object sender, EventArgs e)
        {
            WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "key", $"{comboBox_MOUSE_PRESS_key.SelectedIndex}");
        }

        private void comboBox_MOUSE_PRESS_keytype_SelectedIndexChanged(object sender, EventArgs e)
        {
            WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "keytype", $"{comboBox_MOUSE_PRESS_keytype.SelectedIndex}");
        }

        private void comboBox_MOUSE_WHELL_dire_SelectedIndexChanged(object sender, EventArgs e)
        {
            WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "dire", $"{comboBox_MOUSE_WHELL_dire.SelectedIndex}");
        }

        private void numericUpDown_MOUSE_WHELL_dis_ValueChanged(object sender, EventArgs e)
        {
            WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "dis", $"{numericUpDown_MOUSE_WHELL_dis.Value}");
        }

        private void button_MOUSE_POS_select_Click(object sender, EventArgs e)
        {
            button_MOUSE_POS_select.Text = "请点击要选择的位置";
            button_MOUSE_POS_select.Enabled = false;
            using(Pos_Window pos_Window=new Pos_Window())
            {
                pos_Window.ShowDialog();
            }
            numericUpDown_MOUSE_POS_x.Value = QuickSelectPos.X;
            numericUpDown_MOUSE_POS_y.Value = QuickSelectPos.Y;

            button_MOUSE_POS_select.Text = "快速选择坐标";
            button_MOUSE_POS_select.Enabled = true;
        }

        private void comboBox_KBD_PRESS_keytype_SelectedIndexChanged(object sender, EventArgs e)
        {
            WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "keytype", $"{comboBox_KBD_PRESS_keytype.SelectedIndex}");
        }

        private void hotkeyTextBox_KBD_PRESS_key_TextChanged(object sender, EventArgs e)
        {
            WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "key", $"{hotkeyTextBox_KBD_PRESS_key.Hotkey.ToString()}");
        }
    }
}
