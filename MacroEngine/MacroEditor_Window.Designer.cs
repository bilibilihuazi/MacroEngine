namespace MacroEngine
{
    partial class MacroEditor_Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox_info = new System.Windows.Forms.GroupBox();
            this.textBox_text = new System.Windows.Forms.TextBox();
            this.label_Text = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.label_Path = new System.Windows.Forms.Label();
            this.groupBox_edit = new System.Windows.Forms.GroupBox();
            this.button_Down = new System.Windows.Forms.Button();
            this.button_Up = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.hotkeyTextBox = new MacroEngine.Controls.HotkeyTextBox();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.tabControl_Edit = new System.Windows.Forms.TabControl();
            this.tabPage_NONE = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage_MOUSE_POS = new System.Windows.Forms.TabPage();
            this.button_MOUSE_POS_select = new System.Windows.Forms.Button();
            this.numericUpDown_MOUSE_POS_y = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_MOUSE_POS_x = new System.Windows.Forms.NumericUpDown();
            this.label_MOUSE_POS_y = new System.Windows.Forms.Label();
            this.label_MOUSE_POS_x = new System.Windows.Forms.Label();
            this.label_MOUSE_POS_info = new System.Windows.Forms.Label();
            this.tabPage_WAIT = new System.Windows.Forms.TabPage();
            this.numericUpDown_WAIT_time = new System.Windows.Forms.NumericUpDown();
            this.label_WAIT_time = new System.Windows.Forms.Label();
            this.label_WAIT_info = new System.Windows.Forms.Label();
            this.tabPage_MOUSE_PRESS = new System.Windows.Forms.TabPage();
            this.comboBox_MOUSE_PRESS_keytype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_MOUSE_PRESS_key = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage_MOUSE_WHEEL = new System.Windows.Forms.TabPage();
            this.numericUpDown_MOUSE_WHELL_dis = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_MOUSE_WHELL_dire = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox_MacroList = new System.Windows.Forms.ListBox();
            this.label_HotKey = new System.Windows.Forms.Label();
            this.tabPage_KBD_PRESS = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_KBD_PRESS_keytype = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.hotkeyTextBox_KBD_PRESS_key = new MacroEngine.Controls.HotkeyTextBox();
            this.groupBox_info.SuspendLayout();
            this.groupBox_edit.SuspendLayout();
            this.tabControl_Edit.SuspendLayout();
            this.tabPage_NONE.SuspendLayout();
            this.tabPage_MOUSE_POS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MOUSE_POS_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MOUSE_POS_x)).BeginInit();
            this.tabPage_WAIT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_WAIT_time)).BeginInit();
            this.tabPage_MOUSE_PRESS.SuspendLayout();
            this.tabPage_MOUSE_WHEEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MOUSE_WHELL_dis)).BeginInit();
            this.tabPage_KBD_PRESS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_info
            // 
            this.groupBox_info.Controls.Add(this.textBox_text);
            this.groupBox_info.Controls.Add(this.label_Text);
            this.groupBox_info.Controls.Add(this.textBox_title);
            this.groupBox_info.Controls.Add(this.label_Title);
            this.groupBox_info.Controls.Add(this.textBox_Path);
            this.groupBox_info.Controls.Add(this.label_Path);
            this.groupBox_info.Location = new System.Drawing.Point(12, 12);
            this.groupBox_info.Name = "groupBox_info";
            this.groupBox_info.Size = new System.Drawing.Size(716, 79);
            this.groupBox_info.TabIndex = 7;
            this.groupBox_info.TabStop = false;
            this.groupBox_info.Text = "基本信息";
            // 
            // textBox_text
            // 
            this.textBox_text.Location = new System.Drawing.Point(328, 48);
            this.textBox_text.Name = "textBox_text";
            this.textBox_text.Size = new System.Drawing.Size(382, 23);
            this.textBox_text.TabIndex = 12;
            this.textBox_text.TextChanged += new System.EventHandler(this.textBox_text_TextChanged);
            // 
            // label_Text
            // 
            this.label_Text.Location = new System.Drawing.Point(277, 48);
            this.label_Text.Name = "label_Text";
            this.label_Text.Size = new System.Drawing.Size(45, 23);
            this.label_Text.TabIndex = 11;
            this.label_Text.Text = "信息：";
            this.label_Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(57, 48);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(214, 23);
            this.textBox_title.TabIndex = 10;
            this.textBox_title.TextChanged += new System.EventHandler(this.textBox_title_TextChanged);
            // 
            // label_Title
            // 
            this.label_Title.Location = new System.Drawing.Point(6, 48);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(45, 23);
            this.label_Title.TabIndex = 9;
            this.label_Title.Text = "名称：";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(81, 19);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(629, 23);
            this.textBox_Path.TabIndex = 8;
            // 
            // label_Path
            // 
            this.label_Path.Location = new System.Drawing.Point(6, 19);
            this.label_Path.Name = "label_Path";
            this.label_Path.Size = new System.Drawing.Size(69, 23);
            this.label_Path.TabIndex = 7;
            this.label_Path.Text = "保存路径：";
            this.label_Path.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox_edit
            // 
            this.groupBox_edit.Controls.Add(this.button_Down);
            this.groupBox_edit.Controls.Add(this.button_Up);
            this.groupBox_edit.Controls.Add(this.button_Cancel);
            this.groupBox_edit.Controls.Add(this.hotkeyTextBox);
            this.groupBox_edit.Controls.Add(this.button_Remove);
            this.groupBox_edit.Controls.Add(this.button_Add);
            this.groupBox_edit.Controls.Add(this.button_Save);
            this.groupBox_edit.Controls.Add(this.tabControl_Edit);
            this.groupBox_edit.Controls.Add(this.listBox_MacroList);
            this.groupBox_edit.Controls.Add(this.label_HotKey);
            this.groupBox_edit.Location = new System.Drawing.Point(12, 97);
            this.groupBox_edit.Name = "groupBox_edit";
            this.groupBox_edit.Size = new System.Drawing.Size(716, 276);
            this.groupBox_edit.TabIndex = 8;
            this.groupBox_edit.TabStop = false;
            this.groupBox_edit.Text = "脚本编辑";
            // 
            // button_Down
            // 
            this.button_Down.Enabled = false;
            this.button_Down.Location = new System.Drawing.Point(159, 140);
            this.button_Down.Name = "button_Down";
            this.button_Down.Size = new System.Drawing.Size(41, 33);
            this.button_Down.TabIndex = 12;
            this.button_Down.Text = "↓";
            this.button_Down.UseVisualStyleBackColor = true;
            this.button_Down.Click += new System.EventHandler(this.button_Down_Click);
            // 
            // button_Up
            // 
            this.button_Up.Enabled = false;
            this.button_Up.Location = new System.Drawing.Point(159, 47);
            this.button_Up.Name = "button_Up";
            this.button_Up.Size = new System.Drawing.Size(41, 33);
            this.button_Up.TabIndex = 11;
            this.button_Up.Text = "↑";
            this.button_Up.UseVisualStyleBackColor = true;
            this.button_Up.Click += new System.EventHandler(this.button_Up_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(517, 234);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(67, 30);
            this.button_Cancel.TabIndex = 10;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // hotkeyTextBox
            // 
            this.hotkeyTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.hotkeyTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hotkeyTextBox.Hotkey = System.Windows.Forms.Keys.None;
            this.hotkeyTextBox.Location = new System.Drawing.Point(423, 238);
            this.hotkeyTextBox.Name = "hotkeyTextBox";
            this.hotkeyTextBox.ReadOnly = true;
            this.hotkeyTextBox.Size = new System.Drawing.Size(88, 23);
            this.hotkeyTextBox.TabIndex = 8;
            this.hotkeyTextBox.TabStop = false;
            this.hotkeyTextBox.Text = "无";
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(254, 234);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(89, 30);
            this.button_Remove.TabIndex = 7;
            this.button_Remove.Text = "移除指令";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(159, 234);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(89, 30);
            this.button_Add.TabIndex = 6;
            this.button_Add.Text = "添加指令";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(590, 234);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(116, 30);
            this.button_Save.TabIndex = 5;
            this.button_Save.Text = "保存并关闭";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // tabControl_Edit
            // 
            this.tabControl_Edit.Controls.Add(this.tabPage_NONE);
            this.tabControl_Edit.Controls.Add(this.tabPage_MOUSE_POS);
            this.tabControl_Edit.Controls.Add(this.tabPage_WAIT);
            this.tabControl_Edit.Controls.Add(this.tabPage_MOUSE_PRESS);
            this.tabControl_Edit.Controls.Add(this.tabPage_MOUSE_WHEEL);
            this.tabControl_Edit.Controls.Add(this.tabPage_KBD_PRESS);
            this.tabControl_Edit.ItemSize = new System.Drawing.Size(20, 15);
            this.tabControl_Edit.Location = new System.Drawing.Point(206, 22);
            this.tabControl_Edit.Name = "tabControl_Edit";
            this.tabControl_Edit.SelectedIndex = 0;
            this.tabControl_Edit.Size = new System.Drawing.Size(504, 206);
            this.tabControl_Edit.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_Edit.TabIndex = 4;
            // 
            // tabPage_NONE
            // 
            this.tabPage_NONE.Controls.Add(this.label7);
            this.tabPage_NONE.Location = new System.Drawing.Point(4, 19);
            this.tabPage_NONE.Name = "tabPage_NONE";
            this.tabPage_NONE.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_NONE.Size = new System.Drawing.Size(496, 183);
            this.tabPage_NONE.TabIndex = 1;
            this.tabPage_NONE.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(484, 177);
            this.label7.TabIndex = 0;
            this.label7.Text = "请在左侧列表中选择一条指令编辑";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage_MOUSE_POS
            // 
            this.tabPage_MOUSE_POS.Controls.Add(this.button_MOUSE_POS_select);
            this.tabPage_MOUSE_POS.Controls.Add(this.numericUpDown_MOUSE_POS_y);
            this.tabPage_MOUSE_POS.Controls.Add(this.numericUpDown_MOUSE_POS_x);
            this.tabPage_MOUSE_POS.Controls.Add(this.label_MOUSE_POS_y);
            this.tabPage_MOUSE_POS.Controls.Add(this.label_MOUSE_POS_x);
            this.tabPage_MOUSE_POS.Controls.Add(this.label_MOUSE_POS_info);
            this.tabPage_MOUSE_POS.Location = new System.Drawing.Point(4, 19);
            this.tabPage_MOUSE_POS.Name = "tabPage_MOUSE_POS";
            this.tabPage_MOUSE_POS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_MOUSE_POS.Size = new System.Drawing.Size(496, 183);
            this.tabPage_MOUSE_POS.TabIndex = 0;
            this.tabPage_MOUSE_POS.UseVisualStyleBackColor = true;
            // 
            // button_MOUSE_POS_select
            // 
            this.button_MOUSE_POS_select.Location = new System.Drawing.Point(9, 84);
            this.button_MOUSE_POS_select.Name = "button_MOUSE_POS_select";
            this.button_MOUSE_POS_select.Size = new System.Drawing.Size(124, 28);
            this.button_MOUSE_POS_select.TabIndex = 22;
            this.button_MOUSE_POS_select.Text = "快速选择坐标";
            this.button_MOUSE_POS_select.UseVisualStyleBackColor = true;
            this.button_MOUSE_POS_select.Click += new System.EventHandler(this.button_MOUSE_POS_select_Click);
            // 
            // numericUpDown_MOUSE_POS_y
            // 
            this.numericUpDown_MOUSE_POS_y.Location = new System.Drawing.Point(68, 55);
            this.numericUpDown_MOUSE_POS_y.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown_MOUSE_POS_y.Name = "numericUpDown_MOUSE_POS_y";
            this.numericUpDown_MOUSE_POS_y.Size = new System.Drawing.Size(422, 23);
            this.numericUpDown_MOUSE_POS_y.TabIndex = 21;
            this.numericUpDown_MOUSE_POS_y.ValueChanged += new System.EventHandler(this.numericUpDown_MOUSE_POS_y_ValueChanged);
            // 
            // numericUpDown_MOUSE_POS_x
            // 
            this.numericUpDown_MOUSE_POS_x.Location = new System.Drawing.Point(68, 26);
            this.numericUpDown_MOUSE_POS_x.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown_MOUSE_POS_x.Name = "numericUpDown_MOUSE_POS_x";
            this.numericUpDown_MOUSE_POS_x.Size = new System.Drawing.Size(422, 23);
            this.numericUpDown_MOUSE_POS_x.TabIndex = 20;
            this.numericUpDown_MOUSE_POS_x.ValueChanged += new System.EventHandler(this.numericUpDown_MOUSE_POS_x_ValueChanged);
            // 
            // label_MOUSE_POS_y
            // 
            this.label_MOUSE_POS_y.Location = new System.Drawing.Point(6, 55);
            this.label_MOUSE_POS_y.Name = "label_MOUSE_POS_y";
            this.label_MOUSE_POS_y.Size = new System.Drawing.Size(56, 23);
            this.label_MOUSE_POS_y.TabIndex = 19;
            this.label_MOUSE_POS_y.Text = "Y坐标：";
            this.label_MOUSE_POS_y.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_MOUSE_POS_x
            // 
            this.label_MOUSE_POS_x.Location = new System.Drawing.Point(6, 26);
            this.label_MOUSE_POS_x.Name = "label_MOUSE_POS_x";
            this.label_MOUSE_POS_x.Size = new System.Drawing.Size(56, 23);
            this.label_MOUSE_POS_x.TabIndex = 17;
            this.label_MOUSE_POS_x.Text = "X坐标：";
            this.label_MOUSE_POS_x.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_MOUSE_POS_info
            // 
            this.label_MOUSE_POS_info.Location = new System.Drawing.Point(6, 3);
            this.label_MOUSE_POS_info.Name = "label_MOUSE_POS_info";
            this.label_MOUSE_POS_info.Size = new System.Drawing.Size(484, 20);
            this.label_MOUSE_POS_info.TabIndex = 16;
            this.label_MOUSE_POS_info.Text = "设置鼠标的坐标";
            this.label_MOUSE_POS_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage_WAIT
            // 
            this.tabPage_WAIT.Controls.Add(this.numericUpDown_WAIT_time);
            this.tabPage_WAIT.Controls.Add(this.label_WAIT_time);
            this.tabPage_WAIT.Controls.Add(this.label_WAIT_info);
            this.tabPage_WAIT.Location = new System.Drawing.Point(4, 19);
            this.tabPage_WAIT.Name = "tabPage_WAIT";
            this.tabPage_WAIT.Size = new System.Drawing.Size(496, 183);
            this.tabPage_WAIT.TabIndex = 2;
            this.tabPage_WAIT.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_WAIT_time
            // 
            this.numericUpDown_WAIT_time.Location = new System.Drawing.Point(68, 26);
            this.numericUpDown_WAIT_time.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown_WAIT_time.Name = "numericUpDown_WAIT_time";
            this.numericUpDown_WAIT_time.Size = new System.Drawing.Size(422, 23);
            this.numericUpDown_WAIT_time.TabIndex = 23;
            this.numericUpDown_WAIT_time.ValueChanged += new System.EventHandler(this.numericUpDown_WAIT_time_ValueChanged);
            // 
            // label_WAIT_time
            // 
            this.label_WAIT_time.Location = new System.Drawing.Point(6, 26);
            this.label_WAIT_time.Name = "label_WAIT_time";
            this.label_WAIT_time.Size = new System.Drawing.Size(56, 23);
            this.label_WAIT_time.TabIndex = 22;
            this.label_WAIT_time.Text = "时间：";
            this.label_WAIT_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_WAIT_info
            // 
            this.label_WAIT_info.Location = new System.Drawing.Point(6, 3);
            this.label_WAIT_info.Name = "label_WAIT_info";
            this.label_WAIT_info.Size = new System.Drawing.Size(487, 20);
            this.label_WAIT_info.TabIndex = 21;
            this.label_WAIT_info.Text = "等待指定的时间再执行下一段命令(单位：ms)";
            this.label_WAIT_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage_MOUSE_PRESS
            // 
            this.tabPage_MOUSE_PRESS.Controls.Add(this.comboBox_MOUSE_PRESS_keytype);
            this.tabPage_MOUSE_PRESS.Controls.Add(this.label3);
            this.tabPage_MOUSE_PRESS.Controls.Add(this.comboBox_MOUSE_PRESS_key);
            this.tabPage_MOUSE_PRESS.Controls.Add(this.label1);
            this.tabPage_MOUSE_PRESS.Controls.Add(this.label2);
            this.tabPage_MOUSE_PRESS.Location = new System.Drawing.Point(4, 19);
            this.tabPage_MOUSE_PRESS.Name = "tabPage_MOUSE_PRESS";
            this.tabPage_MOUSE_PRESS.Size = new System.Drawing.Size(496, 183);
            this.tabPage_MOUSE_PRESS.TabIndex = 3;
            this.tabPage_MOUSE_PRESS.UseVisualStyleBackColor = true;
            // 
            // comboBox_MOUSE_PRESS_keytype
            // 
            this.comboBox_MOUSE_PRESS_keytype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MOUSE_PRESS_keytype.FormattingEnabled = true;
            this.comboBox_MOUSE_PRESS_keytype.Items.AddRange(new object[] {
            "单击",
            "按下",
            "抬起"});
            this.comboBox_MOUSE_PRESS_keytype.Location = new System.Drawing.Point(68, 57);
            this.comboBox_MOUSE_PRESS_keytype.Name = "comboBox_MOUSE_PRESS_keytype";
            this.comboBox_MOUSE_PRESS_keytype.Size = new System.Drawing.Size(425, 25);
            this.comboBox_MOUSE_PRESS_keytype.TabIndex = 28;
            this.comboBox_MOUSE_PRESS_keytype.SelectedIndexChanged += new System.EventHandler(this.comboBox_MOUSE_PRESS_keytype_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "操作：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_MOUSE_PRESS_key
            // 
            this.comboBox_MOUSE_PRESS_key.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MOUSE_PRESS_key.FormattingEnabled = true;
            this.comboBox_MOUSE_PRESS_key.Items.AddRange(new object[] {
            "左键",
            "中键",
            "右键"});
            this.comboBox_MOUSE_PRESS_key.Location = new System.Drawing.Point(68, 26);
            this.comboBox_MOUSE_PRESS_key.Name = "comboBox_MOUSE_PRESS_key";
            this.comboBox_MOUSE_PRESS_key.Size = new System.Drawing.Size(425, 25);
            this.comboBox_MOUSE_PRESS_key.TabIndex = 26;
            this.comboBox_MOUSE_PRESS_key.SelectedIndexChanged += new System.EventHandler(this.comboBox_MOUSE_PRESS_key_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "按键：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(487, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "鼠标按键操作，包括左键、中键、右键的单击、按下、抬起操作";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage_MOUSE_WHEEL
            // 
            this.tabPage_MOUSE_WHEEL.Controls.Add(this.numericUpDown_MOUSE_WHELL_dis);
            this.tabPage_MOUSE_WHEEL.Controls.Add(this.label4);
            this.tabPage_MOUSE_WHEEL.Controls.Add(this.comboBox_MOUSE_WHELL_dire);
            this.tabPage_MOUSE_WHEEL.Controls.Add(this.label5);
            this.tabPage_MOUSE_WHEEL.Controls.Add(this.label6);
            this.tabPage_MOUSE_WHEEL.Location = new System.Drawing.Point(4, 19);
            this.tabPage_MOUSE_WHEEL.Name = "tabPage_MOUSE_WHEEL";
            this.tabPage_MOUSE_WHEEL.Size = new System.Drawing.Size(496, 183);
            this.tabPage_MOUSE_WHEEL.TabIndex = 4;
            this.tabPage_MOUSE_WHEEL.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_MOUSE_WHELL_dis
            // 
            this.numericUpDown_MOUSE_WHELL_dis.Location = new System.Drawing.Point(81, 57);
            this.numericUpDown_MOUSE_WHELL_dis.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown_MOUSE_WHELL_dis.Name = "numericUpDown_MOUSE_WHELL_dis";
            this.numericUpDown_MOUSE_WHELL_dis.Size = new System.Drawing.Size(412, 23);
            this.numericUpDown_MOUSE_WHELL_dis.TabIndex = 33;
            this.numericUpDown_MOUSE_WHELL_dis.ValueChanged += new System.EventHandler(this.numericUpDown_MOUSE_WHELL_dis_ValueChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "滚动距离：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_MOUSE_WHELL_dire
            // 
            this.comboBox_MOUSE_WHELL_dire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MOUSE_WHELL_dire.FormattingEnabled = true;
            this.comboBox_MOUSE_WHELL_dire.Items.AddRange(new object[] {
            "向上",
            "向下"});
            this.comboBox_MOUSE_WHELL_dire.Location = new System.Drawing.Point(68, 26);
            this.comboBox_MOUSE_WHELL_dire.Name = "comboBox_MOUSE_WHELL_dire";
            this.comboBox_MOUSE_WHELL_dire.Size = new System.Drawing.Size(425, 25);
            this.comboBox_MOUSE_WHELL_dire.TabIndex = 31;
            this.comboBox_MOUSE_WHELL_dire.SelectedIndexChanged += new System.EventHandler(this.comboBox_MOUSE_WHELL_dire_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "方向";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(487, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "操作鼠标滚轮";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox_MacroList
            // 
            this.listBox_MacroList.FormattingEnabled = true;
            this.listBox_MacroList.ItemHeight = 17;
            this.listBox_MacroList.Location = new System.Drawing.Point(6, 22);
            this.listBox_MacroList.Name = "listBox_MacroList";
            this.listBox_MacroList.Size = new System.Drawing.Size(147, 242);
            this.listBox_MacroList.TabIndex = 3;
            this.listBox_MacroList.SelectedIndexChanged += new System.EventHandler(this.listBox_MacroList_SelectedIndexChanged);
            // 
            // label_HotKey
            // 
            this.label_HotKey.AutoSize = true;
            this.label_HotKey.Location = new System.Drawing.Point(349, 241);
            this.label_HotKey.Name = "label_HotKey";
            this.label_HotKey.Size = new System.Drawing.Size(68, 17);
            this.label_HotKey.TabIndex = 9;
            this.label_HotKey.Text = "触发热键：";
            // 
            // tabPage_KBD_PRESS
            // 
            this.tabPage_KBD_PRESS.Controls.Add(this.hotkeyTextBox_KBD_PRESS_key);
            this.tabPage_KBD_PRESS.Controls.Add(this.label8);
            this.tabPage_KBD_PRESS.Controls.Add(this.comboBox_KBD_PRESS_keytype);
            this.tabPage_KBD_PRESS.Controls.Add(this.label9);
            this.tabPage_KBD_PRESS.Controls.Add(this.label10);
            this.tabPage_KBD_PRESS.Location = new System.Drawing.Point(4, 19);
            this.tabPage_KBD_PRESS.Name = "tabPage_KBD_PRESS";
            this.tabPage_KBD_PRESS.Size = new System.Drawing.Size(496, 183);
            this.tabPage_KBD_PRESS.TabIndex = 5;
            this.tabPage_KBD_PRESS.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 23);
            this.label8.TabIndex = 37;
            this.label8.Text = "按键：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_KBD_PRESS_keytype
            // 
            this.comboBox_KBD_PRESS_keytype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_KBD_PRESS_keytype.FormattingEnabled = true;
            this.comboBox_KBD_PRESS_keytype.Items.AddRange(new object[] {
            "单击",
            "按下",
            "抬起"});
            this.comboBox_KBD_PRESS_keytype.Location = new System.Drawing.Point(68, 26);
            this.comboBox_KBD_PRESS_keytype.Name = "comboBox_KBD_PRESS_keytype";
            this.comboBox_KBD_PRESS_keytype.Size = new System.Drawing.Size(425, 25);
            this.comboBox_KBD_PRESS_keytype.TabIndex = 36;
            this.comboBox_KBD_PRESS_keytype.SelectedIndexChanged += new System.EventHandler(this.comboBox_KBD_PRESS_keytype_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 23);
            this.label9.TabIndex = 35;
            this.label9.Text = "类型：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(487, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "操作键盘按键";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hotkeyTextBox_KBD_PRESS_key
            // 
            this.hotkeyTextBox_KBD_PRESS_key.BackColor = System.Drawing.SystemColors.Window;
            this.hotkeyTextBox_KBD_PRESS_key.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hotkeyTextBox_KBD_PRESS_key.Hotkey = System.Windows.Forms.Keys.None;
            this.hotkeyTextBox_KBD_PRESS_key.Location = new System.Drawing.Point(68, 57);
            this.hotkeyTextBox_KBD_PRESS_key.Name = "hotkeyTextBox_KBD_PRESS_key";
            this.hotkeyTextBox_KBD_PRESS_key.ReadOnly = true;
            this.hotkeyTextBox_KBD_PRESS_key.Size = new System.Drawing.Size(425, 23);
            this.hotkeyTextBox_KBD_PRESS_key.TabIndex = 38;
            this.hotkeyTextBox_KBD_PRESS_key.TabStop = false;
            this.hotkeyTextBox_KBD_PRESS_key.TextChanged += new System.EventHandler(this.hotkeyTextBox_KBD_PRESS_key_TextChanged);
            // 
            // MacroEditor_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 385);
            this.Controls.Add(this.groupBox_edit);
            this.Controls.Add(this.groupBox_info);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(756, 424);
            this.MinimumSize = new System.Drawing.Size(756, 424);
            this.Name = "MacroEditor_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "宏编辑器";
            this.Activated += new System.EventHandler(this.MacroEditor_Window_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MacroEditor_Window_FormClosing);
            this.Load += new System.EventHandler(this.MacroEditor_Window_Load);
            this.groupBox_info.ResumeLayout(false);
            this.groupBox_info.PerformLayout();
            this.groupBox_edit.ResumeLayout(false);
            this.groupBox_edit.PerformLayout();
            this.tabControl_Edit.ResumeLayout(false);
            this.tabPage_NONE.ResumeLayout(false);
            this.tabPage_MOUSE_POS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MOUSE_POS_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MOUSE_POS_x)).EndInit();
            this.tabPage_WAIT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_WAIT_time)).EndInit();
            this.tabPage_MOUSE_PRESS.ResumeLayout(false);
            this.tabPage_MOUSE_WHEEL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MOUSE_WHELL_dis)).EndInit();
            this.tabPage_KBD_PRESS.ResumeLayout(false);
            this.tabPage_KBD_PRESS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_info;
        private System.Windows.Forms.TextBox textBox_text;
        private System.Windows.Forms.Label label_Text;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Label label_Path;
        private System.Windows.Forms.GroupBox groupBox_edit;
        private System.Windows.Forms.ListBox listBox_MacroList;
        private System.Windows.Forms.TabControl tabControl_Edit;
        private System.Windows.Forms.TabPage tabPage_MOUSE_POS;
        private System.Windows.Forms.Label label_MOUSE_POS_y;
        private System.Windows.Forms.Label label_MOUSE_POS_x;
        private System.Windows.Forms.Label label_MOUSE_POS_info;
        private System.Windows.Forms.TabPage tabPage_NONE;
        private System.Windows.Forms.TabPage tabPage_WAIT;
        private System.Windows.Forms.Label label_WAIT_time;
        private System.Windows.Forms.Label label_WAIT_info;
        private System.Windows.Forms.NumericUpDown numericUpDown_WAIT_time;
        private System.Windows.Forms.NumericUpDown numericUpDown_MOUSE_POS_y;
        private System.Windows.Forms.NumericUpDown numericUpDown_MOUSE_POS_x;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Remove;
        private Controls.HotkeyTextBox hotkeyTextBox;
        private System.Windows.Forms.Label label_HotKey;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Up;
        private System.Windows.Forms.Button button_Down;
        private System.Windows.Forms.TabPage tabPage_MOUSE_PRESS;
        private System.Windows.Forms.ComboBox comboBox_MOUSE_PRESS_key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_MOUSE_PRESS_keytype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage_MOUSE_WHEEL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_MOUSE_WHELL_dire;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_MOUSE_WHELL_dis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_MOUSE_POS_select;
        private System.Windows.Forms.TabPage tabPage_KBD_PRESS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_KBD_PRESS_keytype;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Controls.HotkeyTextBox hotkeyTextBox_KBD_PRESS_key;
    }
}