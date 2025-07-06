using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroEngine.Controls
{
    public class ImageButtonClickEventArgs : EventArgs
    {
        public Point MousePosition { get; }

        public ImageButtonClickEventArgs(Point position)
        {
            MousePosition = position;
        }
    }

    // 自定义图片框控件
    public class ImageButton : PictureBox
    {
        // 属性：正常状态图片
        public Image NormalImage { get; set; }

        // 属性：按下状态图片
        public Image PressedImage { get; set; }

        // 自定义事件：鼠标松开时触发并返回坐标
        public event EventHandler<ImageButtonClickEventArgs> ImageButtonClick;

        public ImageButton()
        {
            // 设置初始样式
            this.BackColor = Color.Transparent;
            this.SizeMode = PictureBoxSizeMode.StretchImage;

            // 绑定事件处理程序
            this.MouseDown += ImageButton_MouseDown;
            this.MouseUp += ImageButton_MouseUp;
            this.MouseLeave += ImageButton_MouseLeave;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            // 初始化时显示正常图片
            if (NormalImage != null && this.Image == null)
            {
                this.Image = NormalImage;
            }
        }

        private void ImageButton_MouseDown(object sender, MouseEventArgs e)
        {
            // 切换到按下状态图片
            if (PressedImage != null)
            {
                this.Image = PressedImage;
            }
        }

        private void ImageButton_MouseUp(object sender, MouseEventArgs e)
        {
            // 恢复到正常图片
            if (NormalImage != null)
            {
                this.Image = NormalImage;
            }

            // 获取鼠标相对控件的坐标
            Point relativePos = this.PointToClient(Cursor.Position);

            // 触发自定义事件
            ImageButtonClick?.Invoke(this, new ImageButtonClickEventArgs(relativePos));
        }

        private void ImageButton_MouseLeave(object sender, EventArgs e)
        {
            // 鼠标移出控件时恢复正常图片
            if (NormalImage != null)
            {
                this.Image = NormalImage;
            }
        }
    }
}
