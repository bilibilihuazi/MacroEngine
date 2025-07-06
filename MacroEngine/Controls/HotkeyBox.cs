using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MacroEngine.Controls
{
    public partial class HotkeyTextBox : TextBox
    {
        private Keys _hotkey = Keys.None;
        private static readonly KeysConverter _keysConverter = new KeysConverter();

        [Browsable(false)]
        public Keys Hotkey
        {
            get => _hotkey;
            set
            {
                _hotkey = value;
                UpdateText();
            }
        }

        public HotkeyTextBox()
        {
            ReadOnly = true;
            BackColor = SystemColors.Window;
            Cursor = Cursors.Arrow;
            TabStop = false;
            Text = "无";
            ContextMenuStrip = new ContextMenuStrip(); // 禁用右键菜单
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            e.SuppressKeyPress = true;

            if (e.KeyCode == Keys.Escape)
            {
                ClearHotkey();
                return;
            }

            Keys pressedKey = e.KeyCode;

            // 处理功能键
            if (pressedKey >= Keys.F1 && pressedKey <= Keys.F24)
            {
                SetHotkey(pressedKey | e.Modifiers);
                return;
            }

            // 忽略单独的修饰键
            if (IsModifierKey(pressedKey))
            {
                return;
            }

            // 处理组合键
            if (e.Modifiers != Keys.None)
            {
                SetHotkey(pressedKey | e.Modifiers);
            }
            // 处理普通键
            else if (!IsSpecialKey(pressedKey))
            {
                SetHotkey(pressedKey);
            }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            e.SuppressKeyPress = true;
        }

        private void SetHotkey(Keys key)
        {
            Hotkey = key;
            UpdateText();
        }

        private void ClearHotkey()
        {
            Hotkey = Keys.None;
            Text = "无";
        }

        private void UpdateText()
        {
            Text = _hotkey == Keys.None
                ? "无"
                : _keysConverter.ConvertToString(_hotkey);
        }

        private static bool IsModifierKey(Keys key)
        {
            return key == Keys.ControlKey ||
                   key == Keys.LControlKey ||
                   key == Keys.RControlKey ||
                   key == Keys.ShiftKey ||
                   key == Keys.LShiftKey ||
                   key == Keys.RShiftKey ||
                   key == Keys.Alt ||
                   key == Keys.LMenu ||
                   key == Keys.RMenu;
        }

        private static bool IsSpecialKey(Keys key)
        {
            return key == Keys.Control ||
                   key == Keys.Shift ||
                   key == Keys.Alt ||
                   key == Keys.LWin ||
                   key == Keys.RWin;
        }
    }
}
