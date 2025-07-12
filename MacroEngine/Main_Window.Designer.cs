using Funcitons;

namespace MacroEngine
{
    partial class Main_Window
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Window));
            this.listBox_Macros = new System.Windows.Forms.ListBox();
            this.groupBox_Info = new System.Windows.Forms.GroupBox();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Enabled = new System.Windows.Forms.Button();
            this.label_Info_Text = new System.Windows.Forms.Label();
            this.label_Info_Title = new System.Windows.Forms.Label();
            this.button_Create = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.宏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.label_info_Key = new System.Windows.Forms.Label();
            this.label_info_Step = new System.Windows.Forms.Label();
            this.groupBox_Info.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Macros
            // 
            this.listBox_Macros.FormattingEnabled = true;
            this.listBox_Macros.ItemHeight = 17;
            this.listBox_Macros.Location = new System.Drawing.Point(12, 27);
            this.listBox_Macros.Name = "listBox_Macros";
            this.listBox_Macros.Size = new System.Drawing.Size(222, 310);
            this.listBox_Macros.TabIndex = 0;
            this.listBox_Macros.SelectedIndexChanged += new System.EventHandler(this.listBox_Macros_SelectedIndexChanged);
            // 
            // groupBox_Info
            // 
            this.groupBox_Info.Controls.Add(this.label_info_Step);
            this.groupBox_Info.Controls.Add(this.label_info_Key);
            this.groupBox_Info.Controls.Add(this.button_Edit);
            this.groupBox_Info.Controls.Add(this.button_Enabled);
            this.groupBox_Info.Controls.Add(this.label_Info_Text);
            this.groupBox_Info.Controls.Add(this.label_Info_Title);
            this.groupBox_Info.Enabled = false;
            this.groupBox_Info.Location = new System.Drawing.Point(346, 27);
            this.groupBox_Info.Name = "groupBox_Info";
            this.groupBox_Info.Size = new System.Drawing.Size(286, 312);
            this.groupBox_Info.TabIndex = 1;
            this.groupBox_Info.TabStop = false;
            this.groupBox_Info.Text = "宏信息";
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(6, 204);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(274, 39);
            this.button_Edit.TabIndex = 3;
            this.button_Edit.Text = "编辑";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Enabled
            // 
            this.button_Enabled.Location = new System.Drawing.Point(6, 249);
            this.button_Enabled.Name = "button_Enabled";
            this.button_Enabled.Size = new System.Drawing.Size(274, 57);
            this.button_Enabled.TabIndex = 2;
            this.button_Enabled.Text = "启用";
            this.button_Enabled.UseVisualStyleBackColor = true;
            this.button_Enabled.Click += new System.EventHandler(this.button_Enabled_Click);
            // 
            // label_Info_Text
            // 
            this.label_Info_Text.Location = new System.Drawing.Point(6, 148);
            this.label_Info_Text.Name = "label_Info_Text";
            this.label_Info_Text.Size = new System.Drawing.Size(274, 53);
            this.label_Info_Text.TabIndex = 1;
            this.label_Info_Text.Text = "Unknown";
            // 
            // label_Info_Title
            // 
            this.label_Info_Title.Location = new System.Drawing.Point(6, 19);
            this.label_Info_Title.Name = "label_Info_Title";
            this.label_Info_Title.Size = new System.Drawing.Size(274, 20);
            this.label_Info_Title.TabIndex = 0;
            this.label_Info_Title.Text = "名称：Unknown";
            this.label_Info_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Create
            // 
            this.button_Create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Create.Location = new System.Drawing.Point(240, 267);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(100, 32);
            this.button_Create.TabIndex = 4;
            this.button_Create.Text = "新建";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Enabled = false;
            this.button_Remove.Location = new System.Drawing.Point(240, 305);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(100, 32);
            this.button_Remove.TabIndex = 5;
            this.button_Remove.Text = "移除";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.宏ToolStripMenuItem,
            this.程序ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(644, 25);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 宏ToolStripMenuItem
            // 
            this.宏ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入ToolStripMenuItem,
            this.导出ToolStripMenuItem});
            this.宏ToolStripMenuItem.Name = "宏ToolStripMenuItem";
            this.宏ToolStripMenuItem.Size = new System.Drawing.Size(32, 21);
            this.宏ToolStripMenuItem.Text = "宏";
            // 
            // 导入ToolStripMenuItem
            // 
            this.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem";
            this.导入ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.导入ToolStripMenuItem.Text = "导入";
            this.导入ToolStripMenuItem.Click += new System.EventHandler(this.导入ToolStripMenuItem_Click);
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.导出ToolStripMenuItem.Text = "导出";
            this.导出ToolStripMenuItem.Click += new System.EventHandler(this.导出ToolStripMenuItem_Click);
            // 
            // 程序ToolStripMenuItem
            // 
            this.程序ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem});
            this.程序ToolStripMenuItem.Name = "程序ToolStripMenuItem";
            this.程序ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.程序ToolStripMenuItem.Text = "程序";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.设置ToolStripMenuItem.Text = "应用热键";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于程序ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 关于程序ToolStripMenuItem
            // 
            this.关于程序ToolStripMenuItem.Name = "关于程序ToolStripMenuItem";
            this.关于程序ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于程序ToolStripMenuItem.Text = "关于程序";
            this.关于程序ToolStripMenuItem.Click += new System.EventHandler(this.关于程序ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "宏配置文件|*.ini";
            this.openFileDialog.Title = "请选择一个有效的宏配置文件";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "宏配置文件|*.ini";
            this.saveFileDialog.Title = "请选择保存的位置";
            // 
            // pictureBox_Icon
            // 
            this.pictureBox_Icon.Image = global::MacroEngine.Properties.Resources.icon;
            this.pictureBox_Icon.Location = new System.Drawing.Point(258, 110);
            this.pictureBox_Icon.Name = "pictureBox_Icon";
            this.pictureBox_Icon.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Icon.TabIndex = 8;
            this.pictureBox_Icon.TabStop = false;
            // 
            // label_info_Key
            // 
            this.label_info_Key.Location = new System.Drawing.Point(6, 39);
            this.label_info_Key.Name = "label_info_Key";
            this.label_info_Key.Size = new System.Drawing.Size(274, 20);
            this.label_info_Key.TabIndex = 4;
            this.label_info_Key.Text = "触发热键：Unknown";
            this.label_info_Key.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_info_Step
            // 
            this.label_info_Step.Location = new System.Drawing.Point(6, 59);
            this.label_info_Step.Name = "label_info_Step";
            this.label_info_Step.Size = new System.Drawing.Size(274, 20);
            this.label_info_Step.TabIndex = 5;
            this.label_info_Step.Text = "指令数：Unknown";
            this.label_info_Step.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 351);
            this.Controls.Add(this.pictureBox_Icon);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.groupBox_Info);
            this.Controls.Add(this.listBox_Macros);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(660, 390);
            this.MinimumSize = new System.Drawing.Size(660, 390);
            this.Name = "Main_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Window";
            this.Load += new System.EventHandler(this.Main_Window_Load);
            this.groupBox_Info.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Macros;
        private System.Windows.Forms.GroupBox groupBox_Info;
        private System.Windows.Forms.Label label_Info_Title;
        private System.Windows.Forms.Label label_Info_Text;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Enabled;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 宏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PictureBox pictureBox_Icon;
        private System.Windows.Forms.Label label_info_Key;
        private System.Windows.Forms.Label label_info_Step;
    }
}

