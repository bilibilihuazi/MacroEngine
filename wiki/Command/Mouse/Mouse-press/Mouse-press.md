# Mouse-press 鼠标-按键
[主页](/wiki/Home.md) / [Macro Engine 指令百科](/wiki/Command.md) / [主指令](/wiki/Command.md) / **Mouse-press 鼠标-按键**

---

![示例](001.gif)

模拟鼠标`单击、按下、抬起` `左键、中键、右键`

## 参数

|参数名|数据类型|默认值|用法|
|-|-|-|-|
|`key`|`int`|`0`|按键  0左键  1中键  2右键|
|`keytype`|`int`|`0`|类型  0单击  1按下  2抬起|

## 配置文件

```ini
[x]
type=MOUSE_PRESS
key=0
keytype=0
```

## 示例

![示例](001.gif)

  1. `鼠标-置坐标`将鼠标移至标签栏的Bilibili按钮上
  2. `等待`命令使下一条命令100毫秒后再执行，防止操作过快
  3. `鼠标-按键`操控鼠标左键单击，按下按钮