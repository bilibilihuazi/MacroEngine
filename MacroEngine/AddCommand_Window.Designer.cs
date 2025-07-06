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
            this.button_MOUSE_POS = new System.Windows.Forms.Button();
            this.button_WAIT = new System.Windows.Forms.Button();
            this.button_MOUSE_PRESS = new System.Windows.Forms.Button();
            this.button_MOUSE_WHEEL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_MOUSE_POS
            // 
            this.button_MOUSE_POS.Location = new System.Drawing.Point(12, 12);
            this.button_MOUSE_POS.Name = "button_MOUSE_POS";
            this.button_MOUSE_POS.Size = new System.Drawing.Size(164, 41);
            this.button_MOUSE_POS.TabIndex = 0;
            this.button_MOUSE_POS.Text = "鼠标_置坐标";
            this.button_MOUSE_POS.UseVisualStyleBackColor = true;
            this.button_MOUSE_POS.Click += new System.EventHandler(this.button_MOUSE_POS_Click);
            // 
            // button_WAIT
            // 
            this.button_WAIT.Location = new System.Drawing.Point(522, 11);
            this.button_WAIT.Name = "button_WAIT";
            this.button_WAIT.Size = new System.Drawing.Size(164, 41);
            this.button_WAIT.TabIndex = 1;
            this.button_WAIT.Text = "等待";
            this.button_WAIT.UseVisualStyleBackColor = true;
            this.button_WAIT.Click += new System.EventHandler(this.button_WAIT_Click);
            // 
            // button_MOUSE_PRESS
            // 
            this.button_MOUSE_PRESS.Location = new System.Drawing.Point(182, 12);
            this.button_MOUSE_PRESS.Name = "button_MOUSE_PRESS";
            this.button_MOUSE_PRESS.Size = new System.Drawing.Size(164, 41);
            this.button_MOUSE_PRESS.TabIndex = 2;
            this.button_MOUSE_PRESS.Text = "鼠标_按键";
            this.button_MOUSE_PRESS.UseVisualStyleBackColor = true;
            this.button_MOUSE_PRESS.Click += new System.EventHandler(this.button_MOUSE_PRESS_Click);
            // 
            // button_MOUSE_WHEEL
            // 
            this.button_MOUSE_WHEEL.Location = new System.Drawing.Point(352, 11);
            this.button_MOUSE_WHEEL.Name = "button_MOUSE_WHEEL";
            this.button_MOUSE_WHEEL.Size = new System.Drawing.Size(164, 41);
            this.button_MOUSE_WHEEL.TabIndex = 3;
            this.button_MOUSE_WHEEL.Text = "鼠标_滚轮";
            this.button_MOUSE_WHEEL.UseVisualStyleBackColor = true;
            this.button_MOUSE_WHEEL.Click += new System.EventHandler(this.button_MOUSE_WHEEL_Click);
            // 
            // AddCommand_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 64);
            this.Controls.Add(this.button_MOUSE_WHEEL);
            this.Controls.Add(this.button_MOUSE_PRESS);
            this.Controls.Add(this.button_WAIT);
            this.Controls.Add(this.button_MOUSE_POS);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(709, 103);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(709, 103);
            this.Name = "AddCommand_Window";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加指令";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button button_MOUSE_POS;
        private System.Windows.Forms.Button button_WAIT;
        private System.Windows.Forms.Button button_MOUSE_PRESS;
        private System.Windows.Forms.Button button_MOUSE_WHEEL;
    }
}