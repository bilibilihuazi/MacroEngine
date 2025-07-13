# Macro Engine 配置文件百科
[主页](/wiki/Home.md) / **Macro Engine 配置文件百科**

---
 
宏配置文件基于[ini配置文件](https://blog.csdn.net/a123441/article/details/90668032)，其编写语法与保存格式也与ini配置文件相同。在阅读此百科之前请先了解`ini配置文件`的基本语法以及写法

宏配置文件包括两个部分：`信息`以及`指令`

## 信息部分

信息部分的节名为`info`，以下是每个配置的解释：

|键|作用|默认值|数据类型
|-|-|-|-|
|Title|用于显示宏的标题|默认宏|string|
|Text|宏的信息，主页编辑键上方的文字|软件首次使用时自动创建的宏，作用只是将鼠标从屏幕左上角移至右下角...|string|
|Enabled|此宏是否启用，只有启用才可注册热键|false|bool|
|SubKey|主键的修饰键，例如`Ctrl + A`，那么此值为CTRL|NONE|string|
|Key|触发热键|F1|Keys|
|Step|此宏的脚本数(步数)|3|int|

他们在配置文件中看起来是这样的：

```ini

[info]
Title=默认宏
Text=软件首次使用时自动创建的宏，作用只是将鼠标从屏幕左上角移至右下角...
Enabled=false
SubKey=NONE
Key=F1
Step=3

```

## 指令部分

指令部分的节名就是它们的执行顺序，配置下有一个`type`键，用于表示此指令为哪个指令，下方为指令对应的参数，详见 [Macro Enigne 指令百科](/wiki/Command.md)

在配置文件中看起来是这样的：

```ini

[x]
type=XXX_XXX
;参数...

```