# Mouse-relapos 鼠标-置相对坐标
[主页](/wiki/Home.md) / [Macro Engine 指令百科](/wiki/Command.md) / [主指令](/wiki/Command.md) / **Mouse-relapos 鼠标-置相对坐标**

---

在鼠标当前坐标的基础上，移动指定距离

## 参数

|参数名|数据类型|默认值|用法|
|-|-|-|-|
|`dis-x`|`int`|`10`|x坐标的移动距离，负数为相反移动|
|`dis-y`|`int`|`10`|y坐标的移动距离，负数为相反移动|

## 配置文件

```ini
[x]
type=MOUSE_POS
dis-x=10
dis-y=10
```