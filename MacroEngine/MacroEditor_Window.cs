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
                WriteConfig(tempPath, "info", "SubKey", "NONE");
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
                if (ReadConfig(tempPath, "info", "SubKey") == "NONE")
                {
                    comboBox_SubHotkey.SelectedIndex = 0;
                }
                else if (ReadConfig(tempPath, "info", "SubKey") == "CTRL")
                {
                    comboBox_SubHotkey.SelectedIndex = 1;
                }
                else if (ReadConfig(tempPath, "info", "SubKey") == "SHIFT")
                {
                    comboBox_SubHotkey.SelectedIndex = 2;
                }
                else if (ReadConfig(tempPath, "info", "SubKey") == "ALT")
                {
                    comboBox_SubHotkey.SelectedIndex = 3;
                }



                listBox_MacroList.Items.Clear();
                for (int i = 0; i < int.Parse(ReadConfig(tempPath, "info", "Step")); i++)
                {
                    string StepType = ReadConfig(tempPath, $"{i + 1}", "type");
                    string StepSubType = ReadConfig(tempPath, $"{i + 1}", "subtype");

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
                    else if (StepType == "KBD_TYPE")
                    {
                        listBox_MacroList.Items.Add("键盘_打字");
                    }
                    else if (StepType == "CB_SETTEXT")
                    {
                        listBox_MacroList.Items.Add("剪贴板_复制文本");
                    }
                    else if (StepType == "CB_GETOBJ")
                    {
                        listBox_MacroList.Items.Add("剪贴板_粘贴");
                    }

                    else
                    {
                        listBox_MacroList.Items.Add("未知的指令");
                    }



                    if (StepSubType == "SUB_FOR")
                    {
                        listBox_MacroList.Items[listBox_MacroList.Items.Count - 1] = $"{listBox_MacroList.Items[listBox_MacroList.Items.Count - 1]} [重复执行]";
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
        public static string AddSubW_TYPE = "UNKNOWN";

        public static Point QuickSelectPos;

        public static int temp_lastSelect = 0;



        public MacroEditor_Window()
        {
            InitializeComponent();
            tabControl_Edit.ItemSize = new Size(0, 1);

            Path = $"{Main_Window.RunPath}\\Macros\\{Main_Window.Editor_NOWMACRO}.ini";
            LoadCommandList();




        }

        private void listBox_MacroList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //===============================================================================================================


                string temp_type = ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "type");

                if (temp_type == "MOUSE_POS")           //             <========此处修改
                {
                    tabControl_Edit.SelectedIndex = 1;
                    numericUpDown_MOUSE_POS_x.Value = int.Parse(ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "pos-x"));
                    numericUpDown_MOUSE_POS_y.Value = int.Parse(ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "pos-y"));
                }
                else if (temp_type == "WAIT")
                {
                    tabControl_Edit.SelectedIndex = 2;
                    numericUpDown_WAIT_time.Value = int.Parse(ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "time"));
                }
                else if (temp_type == "MOUSE_PRESS")
                {
                    tabControl_Edit.SelectedIndex = 3;

                    comboBox_MOUSE_PRESS_key.SelectedIndex = int.Parse(ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "key"));
                    comboBox_MOUSE_PRESS_keytype.SelectedIndex = int.Parse(ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "keytype"));
                }
                else if (temp_type == "MOUSE_WHEEL")
                {
                    tabControl_Edit.SelectedIndex = 4;

                    comboBox_MOUSE_WHELL_dire.SelectedIndex = int.Parse(ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "dire"));
                    numericUpDown_MOUSE_WHELL_dis.Value = int.Parse(ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "dis"));
                }
                else if (temp_type == "KBD_PRESS")
                {
                    tabControl_Edit.SelectedIndex = 5;

                    comboBox_KBD_PRESS_keytype.SelectedIndex = int.Parse(ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "keytype"));
                    comboBox_KBD_PRESS_pkey.SelectedIndex = int.Parse(ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "pkey"));
                    hotkeyTextBox_KBD_PRESS_key.Hotkey = (Keys)Enum.Parse(typeof(Keys), ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "key"));
                }
                else if (temp_type == "KBD_TYPE")
                {
                    tabControl_Edit.SelectedIndex = 6;

                    textBox_KBD_TYPE_text.Text = ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "text");
                    numericUpDown_KBD_TYPE_delay.Value = int.Parse(ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "delay"));
                }
                else if (temp_type == "CB_SETTEXT")
                {
                    tabControl_Edit.SelectedIndex = 7;

                    textBox_CB_SETTEXT.Text = ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "text");
                }
                else if (temp_type == "CB_GETOBJ") 
                {
                    tabControl_Edit.SelectedIndex = 8;
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

                    if (ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "subtype") == null || ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "subtype") == "NONE" || ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "subtype") == "") 
                    {
                        button_AddSub.Enabled = true;
                        button_ToSubtypeEdit.Enabled = false;

                    }
                    else
                    {
                        button_AddSub.Enabled = false;
                        button_ToSubtypeEdit.Enabled = true;

                    }
                }
                else
                {
                    button_Down.Enabled = false;
                    button_Up.Enabled = false;
                    button_Remove.Enabled = false;
                    button_AddSub.Enabled = false;
                    
                }
                button_ToSubtypeEdit.Text = "编辑附加指令";


            }
            catch (Exception ex)
            {
                MessageBox.Show($"在加载命令配置时发生错误！\n\n错误原因：{ex.Message}\n\n注意：此错误并不是你引起的，请详细描述错误是如何产生的并报告给开发者", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            using (AddCommand_Window addCommand_Window = new AddCommand_Window())
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
                WriteConfig(tempPath, $"{listBox_MacroList.Items.Count + 1}", "pkey", "0");
                WriteConfig(tempPath, $"{listBox_MacroList.Items.Count + 1}", "keytype", "0");
                WriteConfig(tempPath, $"{listBox_MacroList.Items.Count + 1}", "key", "A");
                listBox_MacroList.Items.Add("键盘_按键");
            }
            else if (AddW_TYPE == "KBD_TYPE")
            {
                WriteConfig(tempPath, $"{listBox_MacroList.Items.Count + 1}", "type", "KBD_TYPE");
                WriteConfig(tempPath, $"{listBox_MacroList.Items.Count + 1}", "text", "Hello world!");
                WriteConfig(tempPath, $"{listBox_MacroList.Items.Count + 1}", "delay", "100");
                listBox_MacroList.Items.Add("键盘_打字");
            }
            else if (AddW_TYPE == "CB_SETTEXT")
            {
                WriteConfig(tempPath, $"{listBox_MacroList.Items.Count + 1}", "type", "CB_SETTEXT");
                WriteConfig(tempPath, $"{listBox_MacroList.Items.Count + 1}", "text", "Hello world!");
                listBox_MacroList.Items.Add("剪贴板_复制文本");
            }
            else if (AddW_TYPE == "CB_GETOBJ")
            {
                WriteConfig(tempPath, $"{listBox_MacroList.Items.Count + 1}", "type", "CB_GETOBJ");
                listBox_MacroList.Items.Add("剪贴板_粘贴");
            }

            


            //===============================================================================================================






            if (AddW_TYPE != "UNKNOWN")
            {
                WriteConfig(tempPath, "info", "Step", $"{int.Parse(ReadConfig(tempPath, "info", "Step")) + 1}");
            }

            listBox_MacroList.SelectedIndex = listBox_MacroList.Items.Count - 1;
            WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "subtype", "NONE");
            AddW_TYPE = "UNKNOWN";
        }

        private void button_Up_Click(object sender, EventArgs e)
        {
            try
            {
                string NowConfig = $"{listBox_MacroList.SelectedIndex + 1}";
                string LastConfig = $"{listBox_MacroList.SelectedIndex}";

                /*       <======================如有新项添加到此=============================>     */
                string[] Types = { "pos-x", "pos-y", "time", "keytype", "key", "dire", "dis", "pkey", "text", "delay", "SUB_FOR_num", "SUB_FOR_delay" };


                WriteConfig(tempPath, "tempNow", "type", ReadConfig(tempPath, NowConfig, "type"));
                WriteConfig(tempPath, "tempNow", "subtype", ReadConfig(tempPath, NowConfig, "subtype"));
                WriteConfig(tempPath, "tempLast", "type", ReadConfig(tempPath, LastConfig, "type"));
                WriteConfig(tempPath, "tempLast", "subtype", ReadConfig(tempPath, LastConfig, "subtype"));


                for (int i = 0; i < Types.Length; i++)
                {
                    if (ReadConfig(tempPath, NowConfig, Types[i]) != null)
                    {
                        WriteConfig(tempPath, "tempNow", Types[i], ReadConfig(tempPath, NowConfig, Types[i]));
                    }
                    if (ReadConfig(tempPath, LastConfig, Types[i]) != null)
                    {
                        WriteConfig(tempPath, "tempLast", Types[i], ReadConfig(tempPath, LastConfig, Types[i]));
                    }
                }

                DeleteSection(tempPath, NowConfig);
                DeleteSection(tempPath, LastConfig);

                WriteConfig(tempPath, NowConfig, "type", ReadConfig(tempPath, "tempLast", "type"));
                WriteConfig(tempPath, NowConfig, "subtype", ReadConfig(tempPath, "tempLast", "subtype"));
                WriteConfig(tempPath, LastConfig, "type", ReadConfig(tempPath, "tempNow", "type"));
                WriteConfig(tempPath, LastConfig, "subtype", ReadConfig(tempPath, "tempNow", "subtype"));

                for (int i = 0; i < Types.Length; i++)
                {
                    if (ReadConfig(tempPath, "tempNow", Types[i]) != null)
                    {
                        WriteConfig(tempPath, LastConfig, Types[i], ReadConfig(tempPath, "tempNow", Types[i]));
                    }
                    if (ReadConfig(tempPath, "tempLast", Types[i]) != null)
                    {
                        WriteConfig(tempPath, NowConfig, Types[i], ReadConfig(tempPath, "tempLast", Types[i]));
                    }
                }

                DeleteSection(tempPath, "tempNow");
                DeleteSection(tempPath, "tempLast");

                //
                //
                //

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

            }
            catch (Exception ex)
            {
                MessageBox.Show($"在移动指令项时发生错误！\n\n错误原因：{ex.Message}\n\n注意：这项错误并不是你引起的，请完整描述此错误是如何产生的并报告给开发者", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button_Down_Click(object sender, EventArgs e)
        {
            try
            {
                string NowConfig = $"{listBox_MacroList.SelectedIndex + 1}";
                string LastConfig = $"{listBox_MacroList.SelectedIndex + 2}";

                /*       <======================如有新项添加到此=============================>     */
                string[] Types = { "pos-x", "pos-y", "time", "keytype", "key", "dire", "dis", "pkey", "text", "delay", "SUB_FOR_num", "SUB_FOR_delay" };


                WriteConfig(tempPath, "tempNow", "type", ReadConfig(tempPath, NowConfig, "type"));
                WriteConfig(tempPath, "tempNow", "subtype", ReadConfig(tempPath, NowConfig, "subtype"));
                WriteConfig(tempPath, "tempLast", "type", ReadConfig(tempPath, LastConfig, "type"));
                WriteConfig(tempPath, "tempLast", "subtype", ReadConfig(tempPath, LastConfig, "subtype"));


                for (int i = 0; i < Types.Length; i++)
                {
                    if (ReadConfig(tempPath, NowConfig, Types[i]) != null)
                    {
                        WriteConfig(tempPath, "tempNow", Types[i], ReadConfig(tempPath, NowConfig, Types[i]));
                    }
                    if (ReadConfig(tempPath, LastConfig, Types[i]) != null)
                    {
                        WriteConfig(tempPath, "tempLast", Types[i], ReadConfig(tempPath, LastConfig, Types[i]));
                    }
                }

                DeleteSection(tempPath, NowConfig);
                DeleteSection(tempPath, LastConfig);

                WriteConfig(tempPath, NowConfig, "type", ReadConfig(tempPath, "tempLast", "type"));
                WriteConfig(tempPath, NowConfig, "subtype", ReadConfig(tempPath, "tempLast", "subtype"));
                WriteConfig(tempPath, LastConfig, "type", ReadConfig(tempPath, "tempNow", "type"));
                WriteConfig(tempPath, LastConfig, "subtype", ReadConfig(tempPath, "tempNow", "subtype"));

                for (int i = 0; i < Types.Length; i++)
                {
                    if (ReadConfig(tempPath, "tempNow", Types[i]) != null)
                    {
                        WriteConfig(tempPath, LastConfig, Types[i], ReadConfig(tempPath, "tempNow", Types[i]));
                    }
                    if (ReadConfig(tempPath, "tempLast", Types[i]) != null)
                    {
                        WriteConfig(tempPath, NowConfig, Types[i], ReadConfig(tempPath, "tempLast", Types[i]));
                    }
                }

                DeleteSection(tempPath, "tempNow");
                DeleteSection(tempPath, "tempLast");

                //
                //
                //

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
            catch (Exception ex)
            {
                MessageBox.Show($"在移动指令顺序时发生错误！\n\n错误原因：{ex.Message}", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteSection(tempPath, $"{listBox_MacroList.SelectedIndex + 1}");

                for (int i = 0; i < int.Parse(ReadConfig(tempPath, "info", "Step")) - listBox_MacroList.SelectedIndex - 1; i++)
                {


                    string temp = ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2 + i}", "type");
                    string temp_sub = ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2 + i}", "subtype");
                    
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1 + i}", "type", temp);
                    WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1 + i}", "subtype", temp_sub);

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
                        WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1 + i}", "pkey", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2 + i}", "pkey"));
                        WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1 + i}", "key", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2 + i}", "key"));
                    }
                    else if (temp == "KBD_TYPE")
                    {
                        WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1 + i}", "text", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2 + i}", "text"));
                        WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1 + i}", "delay", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2 + i}", "delay"));
                    }
                    else if (temp == "CB_SETTEXT")
                    {
                        WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1 + i}", "text", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2 + i}", "text"));
                    }
                    else if (temp == "CB_GETOBJ")
                    {
                        //None
                    }
                    else if (temp_sub == "SUB_FOR")
                    {
                        WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1 + i}", "SUB_FOR_num", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2 + i}", "SUB_FOR_num"));
                        WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1 + i}", "SUB_FOR_delay", ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 2 + i}", "SUB_FOR_delay"));
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

        private void button_AddSub_Click(object sender, EventArgs e)
        {
            using (AddSubCommand_Window addSubCommand_Window = new AddSubCommand_Window())
            {
                addSubCommand_Window.ShowDialog();
            }

            //    <===============================修改此处=========================================>
            if (AddSubW_TYPE == "SUB_FOR")
            {
                WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "subtype", "SUB_FOR");
                WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "SUB_FOR_num", "5");
                WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "SUB_FOR_delay", "100");
                listBox_MacroList.Items[listBox_MacroList.SelectedIndex] = $"{listBox_MacroList.Items[listBox_MacroList.SelectedIndex]} [重复执行]";
            }




        }

        private void button_ToSubtypeEdit_Click(object sender, EventArgs e)
        {

            try
            {
                if (button_ToSubtypeEdit.Text == "编辑附加指令")
                {
                    button_ToSubtypeEdit.Text = "编辑主指令";
                    temp_lastSelect = tabControl_Edit.SelectedIndex;

                    if (ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "subtype") == "SUB_FOR")
                    {
                        numericUpDown_SUB_FOR_num.Value = int.Parse(ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "SUB_FOR_num"));
                        numericUpDown_SUB_FOR_delay.Value = int.Parse(ReadConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "SUB_FOR_delay"));
                    }







                    tabControl_Edit.SelectedIndex = 9;
                }
                else if (button_ToSubtypeEdit.Text == "编辑主指令")
                {
                    button_ToSubtypeEdit.Text = "编辑附加指令";
                    tabControl_Edit.SelectedIndex = temp_lastSelect;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"在读取附加指令属性时发生错误！\n\n错误原因：{ex.Message}", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                    File.WriteAllText(textBox_Path.Text, File.ReadAllText(tempPath));

                }
                else if(Main_Window.Editor_TYPE=="Edit")
                {
                    File.WriteAllText(Path, File.ReadAllText(tempPath));

                }

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

        private void MacroEditor_Window_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (Main_Window.Editor_TYPE == "Edit") 
            {
                if (StringToSHA256(File.ReadAllText(Path)) != StringToSHA256(File.ReadAllText(tempPath)))
                {
                    if (MessageBox.Show($"检测到文件更改，是否保存该宏？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        button_Save_Click(null, null);
                    }
                }
            }
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

        private void comboBox_KBD_PRESS_pkey_SelectedIndexChanged(object sender, EventArgs e)
        {
            WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "pkey", $"{comboBox_KBD_PRESS_pkey.SelectedIndex}");
        }

        private void textBox_KBD_TYPE_text_TextChanged(object sender, EventArgs e)
        {
            WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "text", textBox_KBD_TYPE_text.Text);
        }

        private void numericUpDown_KBD_TYPE_delay_ValueChanged(object sender, EventArgs e)
        {
            WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "delay", $"{numericUpDown_KBD_TYPE_delay.Value}");
        }

        private void textBox_CB_SETTEXT_TextChanged(object sender, EventArgs e)
        {
            WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "text", $"{textBox_CB_SETTEXT.Text}");
        }

        private void numericUpDown_SUB_FOR_num_ValueChanged(object sender, EventArgs e)
        {
            WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "SUB_FOR_num", $"{numericUpDown_SUB_FOR_num.Value}");
        }

        private void numericUpDown_SUB_FOR_delay_ValueChanged(object sender, EventArgs e)
        {
            WriteConfig(tempPath, $"{listBox_MacroList.SelectedIndex + 1}", "SUB_FOR_delay", $"{numericUpDown_SUB_FOR_delay.Value}");
        }

        private void comboBox_SubHotkey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_SubHotkey.SelectedIndex == 0)
            {
                WriteConfig(tempPath, "info", "SubKey", "NONE");
            }
            else if (comboBox_SubHotkey.SelectedIndex == 1)
            {
                WriteConfig(tempPath, "info", "SubKey", "CTRL");
            }
            else if (comboBox_SubHotkey.SelectedIndex == 2)
            {
                WriteConfig(tempPath, "info", "SubKey", "SHIFT");
            }
            else if (comboBox_SubHotkey.SelectedIndex == 3)
            {
                WriteConfig(tempPath, "info", "SubKey", "ALT");
            }
        }
    }
}
