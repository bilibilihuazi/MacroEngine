# Sub-if 判断
[主页](/wiki/Home.md) / [Macro Engine 指令百科](/wiki/Command.md) / [附加指令](/wiki/Command.md) / **Sub-if 判断**

---

如果指定条件成立那么主指令才会执行，否则跳过被附加的主指令，直接运行下一条指令

## 参数

|参数名|数据类型|默认值|用法|
|-|-|-|-|
|`SUB_IF_cond`|`int`|`0`|见下方|
|`SUB_IF_color_pos-x`|`int`|`0`|条件判断颜色的坐标X|
|`SUB_IF_color_pos-y`|`int`|`0`|条件判断颜色的坐标Y|
|`SUB_IF_color_R`|`int`|`0`|条件判断颜色的R值|
|`SUB_IF_color_G`|`int`|`0`|条件判断颜色的G值|
|`SUB_IF_color_B`|`int`|`0`|条件判断颜色的B值|

**SUB_IF_cond 参数用法**
|值|用法|
|-|-|
|0|判断一个位置的RGB值(颜色)是否为预先设置好的值，如果是，那么主指令执行，否则将跳过|

## 配置文件

```ini
[x]
type=xxx
subtype=SUB_IF
SUB_IF_cond=0
SUB_IF_color_R=0
SUB_IF_color_G=0
SUB_IF_color_B=0
```
