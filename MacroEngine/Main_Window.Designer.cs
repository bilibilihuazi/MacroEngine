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
            this.button_Refresh = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Info.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Macros
            // 
            this.listBox_Macros.FormattingEnabled = true;
            this.listBox_Macros.ItemHeight = 17;
            this.listBox_Macros.Location = new System.Drawing.Point(12, 27);
            this.listBox_Macros.Name = "listBox_Macros";
            this.listBox_Macros.Size = new System.Drawing.Size(222, 276);
            this.listBox_Macros.TabIndex = 0;
            this.listBox_Macros.SelectedIndexChanged += new System.EventHandler(this.listBox_Macros_SelectedIndexChanged);
            // 
            // groupBox_Info
            // 
            this.groupBox_Info.Controls.Add(this.button_Edit);
            this.groupBox_Info.Controls.Add(this.button_Enabled);
            this.groupBox_Info.Controls.Add(this.label_Info_Text);
            this.groupBox_Info.Controls.Add(this.label_Info_Title);
            this.groupBox_Info.Enabled = false;
            this.groupBox_Info.Location = new System.Drawing.Point(342, 27);
            this.groupBox_Info.Name = "groupBox_Info";
            this.groupBox_Info.Size = new System.Drawing.Size(265, 276);
            this.groupBox_Info.TabIndex = 1;
            this.groupBox_Info.TabStop = false;
            this.groupBox_Info.Text = "宏信息";
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(6, 177);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(253, 30);
            this.button_Edit.TabIndex = 3;
            this.button_Edit.Text = "编辑";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Enabled
            // 
            this.button_Enabled.Location = new System.Drawing.Point(6, 213);
            this.button_Enabled.Name = "button_Enabled";
            this.button_Enabled.Size = new System.Drawing.Size(253, 57);
            this.button_Enabled.TabIndex = 2;
            this.button_Enabled.Text = "启用";
            this.button_Enabled.UseVisualStyleBackColor = true;
            this.button_Enabled.Click += new System.EventHandler(this.button_Enabled_Click);
            // 
            // label_Info_Text
            // 
            this.label_Info_Text.Location = new System.Drawing.Point(6, 42);
            this.label_Info_Text.Name = "label_Info_Text";
            this.label_Info_Text.Size = new System.Drawing.Size(253, 132);
            this.label_Info_Text.TabIndex = 1;
            this.label_Info_Text.Text = "UNKNOWN";
            // 
            // label_Info_Title
            // 
            this.label_Info_Title.Location = new System.Drawing.Point(6, 19);
            this.label_Info_Title.Name = "label_Info_Title";
            this.label_Info_Title.Size = new System.Drawing.Size(253, 20);
            this.label_Info_Title.TabIndex = 0;
            this.label_Info_Title.Text = "名称：UNKNOWN";
            this.label_Info_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Create
            // 
            this.button_Create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Create.Location = new System.Drawing.Point(240, 267);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(96, 37);
            this.button_Create.TabIndex = 4;
            this.button_Create.Text = "新建";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Enabled = false;
            this.button_Remove.Location = new System.Drawing.Point(240, 224);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(96, 37);
            this.button_Remove.TabIndex = 5;
            this.button_Remove.Text = "移除";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(240, 27);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(96, 37);
            this.button_Refresh.TabIndex = 6;
            this.button_Refresh.Text = "刷新列表";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.程序ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(619, 25);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip1";
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
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.关于程序ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.关于程序ToolStripMenuItem.Text = "关于程序";
            this.关于程序ToolStripMenuItem.Click += new System.EventHandler(this.关于程序ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 311);
            this.Controls.Add(this.button_Refresh);
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
            this.MaximumSize = new System.Drawing.Size(635, 350);
            this.MinimumSize = new System.Drawing.Size(635, 350);
            this.Name = "Main_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Window";
            this.Load += new System.EventHandler(this.Main_Window_Load);
            this.groupBox_Info.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
    }
}

