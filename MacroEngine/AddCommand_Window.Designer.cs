namespace MacroEngine
{
    partial class AddCommand_Window
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_MOUSE = new System.Windows.Forms.GroupBox();
            this.button_MOUSE_WHEEL = new System.Windows.Forms.Button();
            this.button_MOUSE_PRESS = new System.Windows.Forms.Button();
            this.button_MOUSE_POS = new System.Windows.Forms.Button();
            this.groupBox_Mics = new System.Windows.Forms.GroupBox();
            this.button_WAIT = new System.Windows.Forms.Button();
            this.groupBox_Kbd = new System.Windows.Forms.GroupBox();
            this.button_KBD_PRESS = new System.Windows.Forms.Button();
            this.button_KBD_TYPE = new System.Windows.Forms.Button();
            this.groupBox_CB = new System.Windows.Forms.GroupBox();
            this.button_CB_SETTEXT = new System.Windows.Forms.Button();
            this.button_CB_GETOBJ = new System.Windows.Forms.Button();
            this.groupBox_MOUSE.SuspendLayout();
            this.groupBox_Mics.SuspendLayout();
            this.groupBox_Kbd.SuspendLayout();
            this.groupBox_CB.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_MOUSE
            // 
            this.groupBox_MOUSE.Controls.Add(this.button_MOUSE_WHEEL);
            this.groupBox_MOUSE.Controls.Add(this.button_MOUSE_PRESS);
            this.groupBox_MOUSE.Controls.Add(this.button_MOUSE_POS);
            this.groupBox_MOUSE.Location = new System.Drawing.Point(12, 12);
            this.groupBox_MOUSE.Name = "groupBox_MOUSE";
            this.groupBox_MOUSE.Size = new System.Drawing.Size(501, 67);
            this.groupBox_MOUSE.TabIndex = 4;
            this.groupBox_MOUSE.TabStop = false;
            this.groupBox_MOUSE.Text = "鼠标操作";
            // 
            // button_MOUSE_WHEEL
            // 
            this.button_MOUSE_WHEEL.Location = new System.Drawing.Point(320, 22);
            this.button_MOUSE_WHEEL.Name = "button_MOUSE_WHEEL";
            this.button_MOUSE_WHEEL.Size = new System.Drawing.Size(151, 31);
            this.button_MOUSE_WHEEL.TabIndex = 6;
            this.button_MOUSE_WHEEL.Text = "鼠标_滚轮";
            this.button_MOUSE_WHEEL.UseVisualStyleBackColor = true;
            this.button_MOUSE_WHEEL.Click += new System.EventHandler(this.button_MOUSE_WHEEL_Click);
            // 
            // button_MOUSE_PRESS
            // 
            this.button_MOUSE_PRESS.Location = new System.Drawing.Point(163, 22);
            this.button_MOUSE_PRESS.Name = "button_MOUSE_PRESS";
            this.button_MOUSE_PRESS.Size = new System.Drawing.Size(151, 31);
            this.button_MOUSE_PRESS.TabIndex = 5;
            this.button_MOUSE_PRESS.Text = "鼠标_按键";
            this.button_MOUSE_PRESS.UseVisualStyleBackColor = true;
            this.button_MOUSE_PRESS.Click += new System.EventHandler(this.button_MOUSE_PRESS_Click);
            // 
            // button_MOUSE_POS
            // 
            this.button_MOUSE_POS.Location = new System.Drawing.Point(6, 22);
            this.button_MOUSE_POS.Name = "button_MOUSE_POS";
            this.button_MOUSE_POS.Size = new System.Drawing.Size(151, 31);
            this.button_MOUSE_POS.TabIndex = 4;
            this.button_MOUSE_POS.Text = "鼠标_置坐标";
            this.button_MOUSE_POS.UseVisualStyleBackColor = true;
            this.button_MOUSE_POS.Click += new System.EventHandler(this.button_MOUSE_POS_Click);
            // 
            // groupBox_Mics
            // 
            this.groupBox_Mics.Controls.Add(this.button_WAIT);
            this.groupBox_Mics.Location = new System.Drawing.Point(12, 85);
            this.groupBox_Mics.Name = "groupBox_Mics";
            this.groupBox_Mics.Size = new System.Drawing.Size(171, 65);
            this.groupBox_Mics.TabIndex = 5;
            this.groupBox_Mics.TabStop = false;
            this.groupBox_Mics.Text = "杂项";
            // 
            // button_WAIT
            // 
            this.button_WAIT.Location = new System.Drawing.Point(6, 22);
            this.button_WAIT.Name = "button_WAIT";
            this.button_WAIT.Size = new System.Drawing.Size(151, 31);
            this.button_WAIT.TabIndex = 2;
            this.button_WAIT.Text = "等待";
            this.button_WAIT.UseVisualStyleBackColor = true;
            this.button_WAIT.Click += new System.EventHandler(this.button_WAIT_Click);
            // 
            // groupBox_Kbd
            // 
            this.groupBox_Kbd.Controls.Add(this.button_KBD_TYPE);
            this.groupBox_Kbd.Controls.Add(this.button_KBD_PRESS);
            this.groupBox_Kbd.Location = new System.Drawing.Point(189, 85);
            this.groupBox_Kbd.Name = "groupBox_Kbd";
            this.groupBox_Kbd.Size = new System.Drawing.Size(324, 65);
            this.groupBox_Kbd.TabIndex = 6;
            this.groupBox_Kbd.TabStop = false;
            this.groupBox_Kbd.Text = "键盘操作";
            // 
            // button_KBD_PRESS
            // 
            this.button_KBD_PRESS.Location = new System.Drawing.Point(6, 22);
            this.button_KBD_PRESS.Name = "button_KBD_PRESS";
            this.button_KBD_PRESS.Size = new System.Drawing.Size(151, 31);
            this.button_KBD_PRESS.TabIndex = 2;
            this.button_KBD_PRESS.Text = "键盘_按键";
            this.button_KBD_PRESS.UseVisualStyleBackColor = true;
            this.button_KBD_PRESS.Click += new System.EventHandler(this.button_KBD_PRESS_Click);
            // 
            // button_KBD_TYPE
            // 
            this.button_KBD_TYPE.Location = new System.Drawing.Point(163, 22);
            this.button_KBD_TYPE.Name = "button_KBD_TYPE";
            this.button_KBD_TYPE.Size = new System.Drawing.Size(151, 31);
            this.button_KBD_TYPE.TabIndex = 3;
            this.button_KBD_TYPE.Text = "键盘_打字";
            this.button_KBD_TYPE.UseVisualStyleBackColor = true;
            this.button_KBD_TYPE.Click += new System.EventHandler(this.button_KBD_TYPE_Click);
            // 
            // groupBox_CB
            // 
            this.groupBox_CB.Controls.Add(this.button_CB_GETOBJ);
            this.groupBox_CB.Controls.Add(this.button_CB_SETTEXT);
            this.groupBox_CB.Location = new System.Drawing.Point(12, 156);
            this.groupBox_CB.Name = "groupBox_CB";
            this.groupBox_CB.Size = new System.Drawing.Size(501, 57);
            this.groupBox_CB.TabIndex = 7;
            this.groupBox_CB.TabStop = false;
            this.groupBox_CB.Text = "剪贴板操作";
            // 
            // button_CB_SETTEXT
            // 
            this.button_CB_SETTEXT.Location = new System.Drawing.Point(6, 22);
            this.button_CB_SETTEXT.Name = "button_CB_SETTEXT";
            this.button_CB_SETTEXT.Size = new System.Drawing.Size(151, 31);
            this.button_CB_SETTEXT.TabIndex = 3;
            this.button_CB_SETTEXT.Text = "剪贴板_复制文本";
            this.button_CB_SETTEXT.UseVisualStyleBackColor = true;
            this.button_CB_SETTEXT.Click += new System.EventHandler(this.button_CB_SETTEXT_Click);
            // 
            // button_CB_GETOBJ
            // 
            this.button_CB_GETOBJ.Location = new System.Drawing.Point(163, 22);
            this.button_CB_GETOBJ.Name = "button_CB_GETOBJ";
            this.button_CB_GETOBJ.Size = new System.Drawing.Size(151, 31);
            this.button_CB_GETOBJ.TabIndex = 4;
            this.button_CB_GETOBJ.Text = "剪贴板_粘贴";
            this.button_CB_GETOBJ.UseVisualStyleBackColor = true;
            this.button_CB_GETOBJ.Click += new System.EventHandler(this.button_CB_GETOBJ_Click);
            // 
            // AddCommand_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 225);
            this.Controls.Add(this.groupBox_CB);
            this.Controls.Add(this.groupBox_Kbd);
            this.Controls.Add(this.groupBox_Mics);
            this.Controls.Add(this.groupBox_MOUSE);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(541, 264);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(541, 264);
            this.Name = "AddCommand_Window";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加指令";
            this.groupBox_MOUSE.ResumeLayout(false);
            this.groupBox_Mics.ResumeLayout(false);
            this.groupBox_Kbd.ResumeLayout(false);
            this.groupBox_CB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox_MOUSE;
        private System.Windows.Forms.Button button_MOUSE_WHEEL;
        private System.Windows.Forms.Button button_MOUSE_PRESS;
        private System.Windows.Forms.Button button_MOUSE_POS;
        private System.Windows.Forms.GroupBox groupBox_Mics;
        private System.Windows.Forms.Button button_WAIT;
        private System.Windows.Forms.GroupBox groupBox_Kbd;
        private System.Windows.Forms.Button button_KBD_PRESS;
        private System.Windows.Forms.Button button_KBD_TYPE;
        private System.Windows.Forms.GroupBox groupBox_CB;
        private System.Windows.Forms.Button button_CB_SETTEXT;
        private System.Windows.Forms.Button button_CB_GETOBJ;
    }
}