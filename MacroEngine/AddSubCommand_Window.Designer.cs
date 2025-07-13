namespace MacroEngine
{
    partial class AddSubCommand_Window
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
            this.button_SUB_FOR = new System.Windows.Forms.Button();
            this.button_SUB_IF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_SUB_FOR
            // 
            this.button_SUB_FOR.Location = new System.Drawing.Point(12, 12);
            this.button_SUB_FOR.Name = "button_SUB_FOR";
            this.button_SUB_FOR.Size = new System.Drawing.Size(151, 31);
            this.button_SUB_FOR.TabIndex = 0;
            this.button_SUB_FOR.Text = "重复执行";
            this.button_SUB_FOR.UseVisualStyleBackColor = true;
            this.button_SUB_FOR.Click += new System.EventHandler(this.button_SUB_FOR_Click);
            // 
            // button_SUB_IF
            // 
            this.button_SUB_IF.Location = new System.Drawing.Point(169, 12);
            this.button_SUB_IF.Name = "button_SUB_IF";
            this.button_SUB_IF.Size = new System.Drawing.Size(151, 31);
            this.button_SUB_IF.TabIndex = 1;
            this.button_SUB_IF.Text = "判断";
            this.button_SUB_IF.UseVisualStyleBackColor = true;
            this.button_SUB_IF.Click += new System.EventHandler(this.button_SUB_IF_Click);
            // 
            // AddSubCommand_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 56);
            this.Controls.Add(this.button_SUB_IF);
            this.Controls.Add(this.button_SUB_FOR);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSubCommand_Window";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加附加指令";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_SUB_FOR;
        private System.Windows.Forms.Button button_SUB_IF;
    }
}