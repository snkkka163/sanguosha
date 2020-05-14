# 三国杀游戏基于Winform,.NET框架

#### 1.项目介绍

此项目为三国杀游戏，模拟QQ注册，QQ登录，QQ加好友，QQ聊天，基于C#语言，SQL Server数据库开发， 游戏功能目前已经实现玩家VS人机，已支持英雄:刘备，曹操，孙权，支持穿着装备，武器，战马，杀死对方获得积分，开发工具：Visual Studio 2019，游戏基于手游游卡网络三国杀应用宝版本 2019年春季版本模拟，本项目持续更新!

本项目采用.NET Framework4.5框架，没有使用第三方框架，配置好数据库信息直接就能跑起来运行 !

#### 2.项目设计

1.实现最基本的C#连接数据库访问数据，来实现窗体的数据渲染

2.实现一个简单的人机对打功能，让Winform不再局限于简单的窗体！

#### 3.数据设计

本项目目前数据库只存储了QQ登录的用户信息，游戏对打的记录均为临时数据。

#### 4.游戏功能

- 模拟QQ登录
- 模拟QQ注册
- 模拟QQ信息设置
- 模拟QQ添加好友
- 模拟QQ聊天窗体(可以互发消息)
- 三国杀游戏UI
- 三国杀人机对打

#### 5.项目结构

> ├─三国杀
>            |  ├─App.config   项目主配置文件
>            |  ├─DB.cs      数据库连接工具类
>            |  ├─GameMain.cs   游戏面板界面
>            |  ├─index.cs   游戏登录首页
>            |  ├─Loading.cs   游戏加载页
>            |  ├─Program.cs   应用程序入口
>            |  ├─pvp.cs   至尊场1V1对战界面
>            |  ├─QQLogin.cs   QQ登录界面
>            |  ├─QQMain.cs    QQ主界面
>            |  ├─QQRegister.cs   QQ注册界面
>            |  ├─QQSearch.cs    QQ搜索好友界面
>            |  ├─QQUserAdd.cs   QQ添加好友验证信息界面
>            |  ├─sql  :数据库文件
>                   |  |  ├─QQ.mdf
>                   |  |  └QQ_log.ldf

#### 6.界面设计

##### 6.1 登录界面

![img](https://snkkkait.oss-cn-beijing.aliyuncs.com/sanguosha/index-QQ.jpg)

##### 6.2 游戏主面板

![img](https://snkkkait.oss-cn-beijing.aliyuncs.com/sanguosha/GameMain.jpg)

##### 6.3 加载页面

![img](https://snkkkait.oss-cn-beijing.aliyuncs.com/sanguosha/loading.jpg)

##### 6.4 游戏对战界面

![img](https://snkkkait.oss-cn-beijing.aliyuncs.com/sanguosha/PVP.jpg)

##### 6.5 模拟QQ

![img](https://snkkkait.oss-cn-beijing.aliyuncs.com/sanguosha/QQRegister.jpg)

![img](https://snkkkait.oss-cn-beijing.aliyuncs.com/sanguosha/QQMain.jpg)

![img](https://snkkkait.oss-cn-beijing.aliyuncs.com/sanguosha/QQLogin.jpg)

#### 7.项目说明

> 核心技术采用.NET框架开发，界面简洁，实现了基本功能！

#### 8.如何启动这个项目?

##### 8.1 克隆代码

``` shell
git clone git@gitee.com:xuezipeng/sanguosha.git
```

##### 8.2 启动项目

> 将代码克隆下来以后会在文件夹中生成一个三国杀.sln 使用Visual Studio工具打开即可
>
> 然后在Visual Studio中点击启动，运行项目 ! 

![img](C:\Users\xzp\AppData\Roaming\Typora\typora-user-images\image-20200514092919504.png)

###### 8.2.1 修改数据库配置

![img](https://snkkkait.oss-cn-beijing.aliyuncs.com/picgo/20200514093219.png)

将配置改为你所需要的，我们默认仅支持SQL Server方式

###### 8.2.2 导入数据

拉下来代码以后，项目文件夹里边会有个sql文件夹，将里边的两个文件放置SQL Server的数据路径

![img](https://snkkkait.oss-cn-beijing.aliyuncs.com/picgo/20200514093343.png)

![img](https://snkkkait.oss-cn-beijing.aliyuncs.com/picgo/20200514094749.png)

将这两个文件放置到SQL Server安装路径下的```MSSQL12.MSSQLSERVER\MSSQL\DATA```文件夹中:

然后在SQL Server客户端附加数据库即可

![image-20200514095123830](https://snkkkait.oss-cn-beijing.aliyuncs.com/picgo/20200514095118.png)

然后启动项目就可以跑了！！！ 开始你的第一个.NET游戏吧！！！



如果有疑问可以直接在下面评论区提，有问必答！