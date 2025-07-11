# Macro Enigne 指令百科
[主页](/wiki/Home.md) / **Macro Engine 指令百科**

---

指令，构成宏的基本单位。可作出一些操作，模拟用户鼠标点击、键盘输入...等

## 主指令

主指令，可做出指定的动作

### 鼠标操作

|指令名称|内部命名|作用|详细信息|
|-|-|-|-|
|鼠标-置坐标|`MOUSE_POS`|设置鼠标的坐标|[跳转](Command/Mouse/Mouse-pos/Mouse-pos.md)|
|鼠标-按键|`MOUSE_PRESS`|控制鼠标的三个按键(左键、中键、右键)|[跳转](Command/Mouse/Mouse-press/Mouse-press.md)|
|鼠标-滚轮|`MOUSE_WHEEL`|控制鼠标滚轮|[跳转](Command/Mouse/Mouse-wheel/Mouse-wheel.md)|

### 键盘操作

|指令名称|内部命名|作用|详细信息|
|-|-|-|-|
|键盘-按键|`KBD_PRESS`|控制键盘的按键|[跳转](Command/Keyboard/Kbd_press/Kbd_press.md)|
|键盘-打字|`KBD_TYPE`|模拟键盘的连贯打字|[跳转](Command/Keyboard/Kbd_type/Kbd_type.md)|

### 剪贴板操作

|指令名称|内部命名|作用|详细信息|
|-|-|-|-|
|剪贴板-复制文本|`CB_SETTEXT`|向剪贴板内复制一段文字|[跳转](Command/Clipboard/Cb_settext/Cb_settext.md)|
|剪贴板—复制图像|`CB_SETIMG`|向剪贴板内复制一个指定的图像|[跳转](Command/Clipboard/Cb_setimg/Cb_setimg.md)|
|剪贴板—粘贴|`CB_GETOBJ`|取出剪贴板内的信息|[跳转](Command/Clipboard/Cb_getobj/Cb_getobj.md)|

### 其他

|指令名称|内部命名|作用|详细信息|
|-|-|-|-|
|等待|`WAIT`|等待一段时间后再执行下一段指令|[跳转](Command/Misc/Wait/Wait.md)|
|弹出信息框|`MSGBOX`|弹出一个指定标题、内容的信息框|[跳转](Command/Misc/Msgbox/Msgbox.md)|


## 附加指令

附加指令，顾名思义，附加在主指令上的指令，可对主指令做出修饰

|指令名称|内部命名|作用|详细信息|
|-|-|-|-|
|重复执行|`SUB_FOR`|重复值执行被附加的主指令|[跳转](Command/SubCommand/Sub_for/Sub_for.md)|
