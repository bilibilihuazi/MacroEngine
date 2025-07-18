﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Funcitons;
using static Funcitons.NormalFunc;

namespace MacroEngine
{
    public partial class Main_Window : Form
    {
        //函数========================================================================================
        public void LoadMacroList()
        {
            try
            {
                string[] temp = Directory.GetFiles(MacroDir);

                listBox_Macros.Items.Clear();
                for (int i = 0; i < temp.Length; i++)
                {
                    listBox_Macros.Items.Add(Path.GetFileNameWithoutExtension(temp[i]));

                }


                listBox_Macros.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"在获得宏列表时发生错误！\n\n错误原因：{ex.Message}", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
        }

        public void RegHotkey()
        {
            uint temp_MOD = GlobalHotkey.MOD_NONE;


            for (int i = 0; i < _Hotkeys?.Length; i++)
            {
                _Hotkeys[i].Unregister();
                _Hotkeys[i].Dispose();
            }

            globalHotkeys.Clear();

            for (int i = 0; i < Macros.Length; i++)
            {
                if (ReadConfig($"{Macros[i]}", "info", "SubKey") == "NONE")
                {
                    temp_MOD = GlobalHotkey.MOD_NONE;
                }
                else if (ReadConfig($"{Macros[i]}", "info", "SubKey") == "CTRL")
                {
                    temp_MOD = GlobalHotkey.MOD_CONTROL;
                }
                else if (ReadConfig($"{Macros[i]}", "info", "SubKey") == "SHIFT")
                {
                    temp_MOD = GlobalHotkey.MOD_SHIFT;
                }
                else if (ReadConfig($"{Macros[i]}", "info", "SubKey") == "ALT")
                {
                    temp_MOD = GlobalHotkey.MOD_ALT;
                }


                
                globalHotkeys.Add(new GlobalHotkey(this.Handle, temp_MOD, (Keys)Enum.Parse(typeof(Keys), ReadConfig(Macros[i], "info", "Key")), $"{i}"));

                _WarnHotkey = new GlobalHotkey(this.Handle, GlobalHotkey.MOD_CONTROL, Keys.F4);
            }
            _Hotkeys = globalHotkeys.ToArray();

            for (int i = 0; i < _Hotkeys.Length; i++)
            {
                _Hotkeys[i].Register();
                _Hotkeys[i].HotkeyPressed += _HotKey_Press;
            }
            _WarnHotkey.Register();
            _WarnHotkey.HotkeyPressed += _WarnHotkey_Press;
        }
        //变量========================================================================================
        public static string RunPath = Directory.GetCurrentDirectory();
        public static string Version = "Release 1.1.1.10";
        public static string MacroDir = $"{RunPath}\\Macros";
        public static string ConfigPath = $"{RunPath}\\Config\\Global_Config.ini";
        string[] Macros;

        public GlobalHotkey[] _Hotkeys;
        public GlobalHotkey _WarnHotkey;
        public List<GlobalHotkey> globalHotkeys = new List<GlobalHotkey>();

        public static string Editor_TYPE = "NONE";
        public static string Editor_NOWMACRO;

        public static string NowPress;
        //声明========================================================================================
        
        //事件========================================================================================

        //窗口构造
        public Main_Window()
        {

            InitializeComponent();

            #region 资源检测 & 配置项初始化

            if (!Directory.Exists(MacroDir))
            {
                Directory.CreateDirectory(MacroDir);
            }
            if (Directory.GetFiles(MacroDir).Length == 0) 
            {
                WriteConfig($"{MacroDir}\\Default.ini", "info", "Title", "默认宏");
                WriteConfig($"{MacroDir}\\Default.ini", "info", "Text", "软件首次使用时自动创建的宏，作用只是将鼠标从屏幕左上角移至右下角...");
                WriteConfig($"{MacroDir}\\Default.ini", "info", "Enabled", "false");
                WriteConfig($"{MacroDir}\\Default.ini", "info", "SubKey", "NONE");
                WriteConfig($"{MacroDir}\\Default.ini", "info", "Key", "F1");
                WriteConfig($"{MacroDir}\\Default.ini", "info", "Step", "3");
                WriteConfig($"{MacroDir}\\Default.ini", "info", "LoopCount", "1");

                WriteConfig($"{MacroDir}\\Default.ini", "1", "type", "MOUSE_POS");
                WriteConfig($"{MacroDir}\\Default.ini", "1", "pos-x", "0");
                WriteConfig($"{MacroDir}\\Default.ini", "1", "pos-y", "0");

                WriteConfig($"{MacroDir}\\Default.ini", "2", "type", "WAIT");
                WriteConfig($"{MacroDir}\\Default.ini", "2", "time", "2000");

                WriteConfig($"{MacroDir}\\Default.ini", "3", "type", "MOUSE_POS");
                WriteConfig($"{MacroDir}\\Default.ini", "3", "pos-x", $"{Screen.PrimaryScreen.Bounds.Width}");
                WriteConfig($"{MacroDir}\\Default.ini", "3", "pos-y", $"{Screen.PrimaryScreen.Bounds.Height}");

            }
            
            


            #endregion

            #region 初始化

            this.Text = $"宏引擎 {Version}";

            LoadMacroList();

            Macros = Directory.GetFiles($"{MacroDir}");

            #endregion

            #region 热键注册

            RegHotkey();

            #endregion


        }

        // 应急热键触发
        public void _WarnHotkey_Press(GlobalHotkey name)
        {
            Process.Start($"{Application.ExecutablePath}");
            Environment.Exit(0);
        }

        //热键触发
        public async void _HotKey_Press(GlobalHotkey name)
        {
            //===============================================================================================================

            try
            {

                string CommandPath = Macros[int.Parse(name.Name)];
                int temp_LoopCount = int.Parse(ReadConfig(CommandPath, "info", "LoopCount"));

                pictureBox_Icon.Image = Properties.Resources._icon;

                if (ReadConfig(CommandPath, "info", "Enabled") == "true")
                {
                    for (int k = 0; k < temp_LoopCount; k++)
                    {
                        for (int i = 0; i < int.Parse(ReadConfig(CommandPath, "info", "Step")); i++)
                        {
                            string NowCmdType = ReadConfig(CommandPath, $"{i + 1}", "type");
                            string NowCmdSubType = ReadConfig(CommandPath, $"{i + 1}", "subtype");
                            int temp_fornum = 1;
                            int temp_fordelay = 0;
                            Color temp_ifcolor = Color.FromArgb(0, 0, 0);
                            Point temp_ifpos = new Point(0, 0);


                            if (NowCmdSubType == "SUB_FOR")
                            {
                                temp_fornum = int.Parse(ReadConfig(CommandPath, $"{i + 1}", "SUB_FOR_num"));
                                temp_fordelay = int.Parse(ReadConfig(CommandPath, $"{i + 1}", "SUB_FOR_delay"));
                            }
                            else if (NowCmdSubType == "SUB_IF")
                            {
                                temp_ifcolor = Color.FromArgb(int.Parse(ReadConfig(CommandPath, $"{i + 1}", "SUB_IF_color_R")), int.Parse(ReadConfig(CommandPath, $"{i + 1}", "SUB_IF_color_G")), int.Parse(ReadConfig(CommandPath, $"{i + 1}", "SUB_IF_color_B")));
                                temp_ifpos = new Point(int.Parse(ReadConfig(CommandPath, $"{i + 1}", "SUB_IF_color_pos-x")), int.Parse(ReadConfig(CommandPath, $"{i + 1}", "SUB_IF_color_pos-y")));
                            }

                            if (GetPixelRgb(temp_ifpos) == temp_ifcolor || NowCmdSubType != "SUB_IF")
                            {
                                for (int n = 0; n < temp_fornum; n++)
                                {
                                    if (NowCmdType == "MOUSE_POS")         //<====================================此处修改================
                                    {
                                        m_SetPositionPoint(new Point(int.Parse(ReadConfig(CommandPath, $"{i + 1}", "pos-x")), int.Parse(ReadConfig(CommandPath, $"{i + 1}", "pos-y"))));
                                    }
                                    else if (NowCmdType == "WAIT")
                                    {
                                        await Task.Delay(int.Parse(ReadConfig(CommandPath, $"{i + 1}", "time")));
                                    }
                                    else if (NowCmdType == "MOUSE_PRESS")
                                    {
                                        string temp_key = ReadConfig(CommandPath, $"{i + 1}", "key");
                                        string temp_keytype = ReadConfig(CommandPath, $"{i + 1}", "keytype");

                                        if (temp_key == "0")
                                        {
                                            if (temp_keytype == "0")
                                            {
                                                m_LeftClick();
                                            }
                                            else if (temp_keytype == "1")
                                            {
                                                m_LeftDown();
                                            }
                                            else if (temp_keytype == "2")
                                            {
                                                m_LeftUp();
                                            }
                                        }
                                        else if (temp_key == "1")
                                        {
                                            if (temp_keytype == "0")
                                            {
                                                m_MiddleClick();
                                            }
                                            else if (temp_keytype == "1")
                                            {
                                                m_MiddleDown();
                                            }
                                            else if (temp_keytype == "2")
                                            {
                                                m_MiddleUp();
                                            }
                                        }
                                        else if (temp_key == "2")
                                        {
                                            if (temp_keytype == "0")
                                            {
                                                m_RightClick();
                                            }
                                            else if (temp_keytype == "1")
                                            {
                                                m_RightDown();
                                            }
                                            else if (temp_keytype == "2")
                                            {
                                                m_RightUp();
                                            }
                                        }
                                    }
                                    else if (NowCmdType == "MOUSE_WHEEL")
                                    {
                                        string temp_dire = ReadConfig(CommandPath, $"{i + 1}", "dire");
                                        string temp_dis = ReadConfig(CommandPath, $"{i + 1}", "dis");

                                        if (temp_dire == "0")
                                        {
                                            m_WheelUp(int.Parse(temp_dis));
                                        }
                                        else if (temp_dire == "1")
                                        {
                                            m_WheelDown(int.Parse(temp_dis));
                                        }

                                    }
                                    else if (NowCmdType == "KBD_PRESS")
                                    {
                                        string temp_keytype = ReadConfig(CommandPath, $"{i + 1}", "keytype");
                                        string temp_pkey = ReadConfig(CommandPath, $"{i + 1}", "pkey");
                                        string temp_key = ReadConfig(CommandPath, $"{i + 1}", "key");

                                        if (temp_pkey == "1")
                                        {
                                            kbd_KeyDown(Keys.ControlKey);
                                        }
                                        else if (temp_pkey == "2")
                                        {
                                            kbd_KeyDown(Keys.ShiftKey);
                                        }
                                        else if (temp_pkey == "3")
                                        {
                                            kbd_KeyDown(Keys.Alt);
                                        }





                                        if (temp_keytype == "0")
                                        {
                                            kbd_KeyPress((Keys)Enum.Parse(typeof(Keys), temp_key));
                                        }
                                        else if (temp_keytype == "1")
                                        {
                                            kbd_KeyDown((Keys)Enum.Parse(typeof(Keys), temp_key));
                                        }
                                        else if (temp_keytype == "2")
                                        {
                                            kbd_KeyUp((Keys)Enum.Parse(typeof(Keys), temp_key));
                                        }



                                        kbd_KeyUp(Keys.ControlKey);
                                        kbd_KeyUp(Keys.ShiftKey);
                                        kbd_KeyUp(Keys.Alt);
                                    }
                                    else if (NowCmdType == "KBD_TYPE")
                                    {
                                        string temp_text = ReadConfig(CommandPath, $"{i + 1}", "text");
                                        string temp_delay = ReadConfig(CommandPath, $"{i + 1}", "delay");

                                        for (int j = 0; j < temp_text.Length; j++)
                                        {
                                            Clipboard.SetText(temp_text.Substring(j, 1));
                                            kbd_KeyDown(Keys.ControlKey);
                                            kbd_KeyPress(Keys.V);
                                            kbd_KeyUp(Keys.ControlKey);

                                            await Task.Delay(int.Parse(temp_delay));
                                        }


                                    }
                                    else if (NowCmdType == "CB_SETTEXT")
                                    {
                                        string temp_text = ReadConfig(CommandPath, $"{i + 1}", "text");

                                        Clipboard.SetText(temp_text);
                                    }
                                    else if (NowCmdType == "CB_GETOBJ")
                                    {
                                        kbd_KeyDown(Keys.ControlKey);
                                        kbd_KeyPress(Keys.V);
                                        kbd_KeyUp(Keys.ControlKey);
                                    }
                                    else if (NowCmdType == "CB_SETIMG")
                                    {
                                        string temp_image = ReadConfig(CommandPath, $"{i + 1}", "image");

                                        Clipboard.SetImage(Image.FromFile(temp_image));

                                    }
                                    else if (NowCmdType == "MSGBOX")
                                    {
                                        string temp_title = ReadConfig(CommandPath, $"{i + 1}", "title");
                                        string temp_text = ReadConfig(CommandPath, $"{i + 1}", "text");

                                        MessageBox.Show(temp_text, temp_title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }
                                    else if (NowCmdType == "MOUSE_RELAPOS")
                                    {
                                        string temp_dis_x = ReadConfig(CommandPath, $"{i + 1}", "dis-x");
                                        string temp_dis_y = ReadConfig(CommandPath, $"{i + 1}", "dis-y");

                                        m_SetPositionPoint(new Point(m_GetPosition().X + int.Parse(temp_dis_x), m_GetPosition().Y + int.Parse(temp_dis_y)));
                                    }


                                    await Task.Delay(temp_fordelay);
                                }
                            }




                        }
                    }

                }


                pictureBox_Icon.Image = Properties.Resources.icon;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"在执行脚本时发生错误！\n\n错误原因：{ex.Message}", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pictureBox_Icon.Image = Properties.Resources.icon;
            }
            //===============================================================================================================

        }

        //热键事件处理
        protected override void WndProc(ref Message m)
        {
            for (int i = 0; i < _Hotkeys?.Length; i++) 
            {
                _Hotkeys?[i].ProcessMessage(m);
            }
            _WarnHotkey?.ProcessMessage(m);
            base.WndProc(ref m);
        }

        //注销热键
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            for (int i = 0; i < _Hotkeys?.Length; i++) 
            {
                _Hotkeys?[i].Dispose();
            }
            _WarnHotkey?.Dispose();
            base.OnFormClosing(e);
        }

        //选择宏
        private void listBox_Macros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Macros.SelectedIndex != -1)
            {
                try
                {
                    
                    groupBox_Info.Enabled = true;
                    button_Remove.Enabled = true;

                    if (ReadConfig($"{MacroDir}\\{listBox_Macros.Text}.ini", "info", "Enabled") == "true")
                    {
                        label_Info_Title.Text = $"名称：{ReadConfig($"{MacroDir}\\{listBox_Macros.Text}.ini", "info", "Title")} [已启用]";

                    }
                    else
                    {
                        label_Info_Title.Text = $"名称：{ReadConfig($"{MacroDir}\\{listBox_Macros.Text}.ini", "info", "Title")} [已禁用]";
                    }

                    label_Info_Text.Text = ReadConfig($"{MacroDir}\\{listBox_Macros.Text}.ini", "info", "Text");
                    

                    if (ReadConfig($"{MacroDir}\\{listBox_Macros.Text}.ini", "info", "SubKey") != "NONE")
                    {
                        label_info_Key.Text = $"触发热键：{ReadConfig($"{MacroDir}\\{listBox_Macros.Text}.ini", "info", "SubKey")} + {ReadConfig($"{MacroDir}\\{listBox_Macros.Text}.ini", "info", "Key")}";

                    }
                    else
                    {
                        label_info_Key.Text = $"触发热键：{ReadConfig($"{MacroDir}\\{listBox_Macros.Text}.ini", "info", "Key")}";

                    }

                    label_info_Step.Text = $"指令数：{ReadConfig($"{MacroDir}\\{listBox_Macros.Text}.ini", "info", "Step")}";
                    label_info_LoopCount.Text = $"循环次数：{ReadConfig($"{MacroDir}\\{listBox_Macros.Text}.ini", "info", "LoopCount")}";


                    if (ReadConfig($"{MacroDir}\\{listBox_Macros.Text}.ini", "info", "Enabled") == "true")
                    {
                        button_Enabled.Text = "禁用";
                    }
                    else
                    {
                        button_Enabled.Text = "启用";
                    }

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"在读取宏信息时发生错误！\n\n错误原因: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
                
            }
            else
            {
                groupBox_Info.Enabled = false;
                button_Remove.Enabled = false;
            }
        }

        //菜单=>关于程序
        private void 关于程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"宏引擎 Macro Engine  {Version}\n\nHuaZi-华子 版权所有 © 2024~2025  作者QQ：2825338723\n\n此软件完全免费，如有收费行为请立即退款并举报", "关于程序", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //菜单=>应用热键
        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start($"{Application.ExecutablePath}");
            Environment.Exit(0);
        }

        //菜单=>项目主页
        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult temp = MessageBox.Show($"前往哪个平台的代码仓库？\n\n [点击\"是\" 前往Github仓库]  [点击\"否\" 前往Gitee仓库]", "请选择仓库", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (temp == DialogResult.Yes)
            {
                Process.Start("https://github.com/bilibilihuazi/MacroEngine");

            }
            else if (temp == DialogResult.No)
            {
                Process.Start($"https://gitee.com/huamouren110/MacroEngine");
            }


        }

        //菜单=>宏=>导入
        private void 导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (ReadConfig(openFileDialog.FileName, "info", "Title") != null && ReadConfig(openFileDialog.FileName, "info", "Step") != null && ReadConfig(openFileDialog.FileName, "info", "Key") != null && ReadConfig(openFileDialog.FileName, "info", "Text") != null)
                {
                    try
                    {
                        File.WriteAllText($"{MacroDir}\\{Path.GetFileName(openFileDialog.FileName)}", File.ReadAllText(openFileDialog.FileName));
                        LoadMacroList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"在写入配置文件时发生错误！\n\n错误原因：{ex.Message}", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show($"目标文件不是一个有效的宏配置文件！", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //菜单=>宏=>导出
        private void 导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_Macros.SelectedIndex != -1)
            {
                if (MessageBox.Show($"是否导出\"{listBox_Macros.Text}\"?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            File.WriteAllText(saveFileDialog.FileName, File.ReadAllText($"{MacroDir}\\{listBox_Macros.Text}.ini"));
                            MessageBox.Show($"配置文件已导出至\"{saveFileDialog.FileName}\"", "成功导出", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"在写入文件时发生错误！\n\n错误原因：{ex.Message}", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show($"请先在下方列表中选中一个宏！", "无法导出", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //宏菜单刷新
        private void button_Refresh_Click(object sender, EventArgs e)
        {
            listBox_Macros.SelectedIndex = -1;
            LoadMacroList();
        }

        //宏菜单移除
        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"确定移除宏\"{listBox_Macros.Text}\"?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                File.Delete($"{MacroDir}\\{listBox_Macros.Text}.ini");
            }
            LoadMacroList();
            groupBox_Info.Enabled = false;
            button_Remove.Enabled = false;
        }

        //宏创建
        private void button_Create_Click(object sender, EventArgs e)
        {
            Editor_TYPE = "Create";
            using (MacroEditor_Window macroEditor_Window = new MacroEditor_Window())
            {
                
                macroEditor_Window.ShowDialog();
            }
            listBox_Macros.SelectedIndex = -1;
            LoadMacroList();
        }

        //宏编辑
        private void button_Edit_Click(object sender, EventArgs e)
        {
            Editor_TYPE = "Edit";
            Editor_NOWMACRO = listBox_Macros.Text;
            using (MacroEditor_Window macroEditor_Window=new MacroEditor_Window())
            {
                
                macroEditor_Window.ShowDialog();
            }
            listBox_Macros.SelectedIndex = -1;
            LoadMacroList();
        }

        //宏启用
        private void button_Enabled_Click(object sender, EventArgs e)
        {
            if (ReadConfig($"{MacroDir}\\{listBox_Macros.Text}.ini", "info", "Enabled") == "true")
            {
                WriteConfig($"{MacroDir}\\{listBox_Macros.Text}.ini", "info", "Enabled", "false");
                label_Info_Title.Text = $"名称：{ReadConfig($"{MacroDir}\\{listBox_Macros.Text}.ini", "info", "Title")} [已禁用]";

                button_Enabled.Text = "启用";
            }
            else
            {
                WriteConfig($"{MacroDir}\\{listBox_Macros.Text}.ini", "info", "Enabled", "true");
                label_Info_Title.Text = $"名称：{ReadConfig($"{MacroDir}\\{listBox_Macros.Text}.ini", "info", "Title")} [已启用]";

                button_Enabled.Text = "禁用";
            }

            RegHotkey();
        }
    }
}
