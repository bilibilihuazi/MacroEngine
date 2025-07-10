# Macro Engine 维基百科

**Macro Engine**是一款可以**自定义宏**、并**快捷运行宏**的一款工具

## 指令

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
|剪贴板-复制文本|`CB_SETTEXT`|向剪贴板内复制一段文字|正在制作中...|
|剪贴板—粘贴|`CB_GETOBJ`|取出剪贴板内的信息|正在制作中...|

### 其他

|指令名称|内部命名|作用|详细信息|
|-|-|-|-|
|等待|`WAIT`|等待一段时间后再执行下一段指令|正在制作中...|

## 附加指令

|指令名称|内部命名|作用|详细信息|
|-|-|-|-|
|重复执行|`SUB_FOR`|重复值执行被附加的主指令|正在制作中...|