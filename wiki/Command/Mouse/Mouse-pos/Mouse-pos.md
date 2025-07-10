# Mouse-pos 鼠标-置坐标
[主页](/wiki/Home.md) / [Macro Engine 指令百科](/wiki/Command.md) / [主指令](/wiki/Command.md) / **Mouse-pos 鼠标-置坐标**

---

![演示](001.gif)

设置鼠标的坐标，坐标可以通过宏编辑器中的`坐标选择器`来快速选择；移动是一瞬间的，**没有任何过渡动作**

## 参数

|参数名|数据类型|默认值|用法|
|-|-|-|-|
|`pos-x`|`int`|`0`|目标位置的x坐标|
|`pos-y`|`int`|`0`|目标位置的y坐标|

## 配置文件

```ini
[x]
type=MOUSE_POS
pos-x=0
pos-y=0
```