namespace MacroEngine
{
    partial class Pos_Window
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
            this.panel_Y = new System.Windows.Forms.Panel();
            this.panel_X = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel_Y
            // 
            this.panel_Y.BackColor = System.Drawing.Color.Red;
            this.panel_Y.Location = new System.Drawing.Point(112, 42);
            this.panel_Y.Name = "panel_Y";
            this.panel_Y.Size = new System.Drawing.Size(1, 100);
            this.panel_Y.TabIndex = 1;
            this.panel_Y.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Y_MouseUp);
            // 
            // panel_X
            // 
            this.panel_X.BackColor = System.Drawing.Color.Red;
            this.panel_X.Location = new System.Drawing.Point(135, 42);
            this.panel_X.Name = "panel_X";
            this.panel_X.Size = new System.Drawing.Size(100, 1);
            this.panel_X.TabIndex = 2;
            this.panel_X.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_X_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(516, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pos";
            // 
            // Pos_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(700, 371);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_X);
            this.Controls.Add(this.panel_Y);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pos_Window";
            this.Opacity = 0.25D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Pos_Window";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Pos_Window_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pos_Window_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_Y;
        private System.Windows.Forms.Panel panel_X;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}