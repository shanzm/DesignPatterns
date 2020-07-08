## DesignPatterns


<!-- @import "[TOC]" {cmd="toc" depthFrom=1 depthTo=6 orderedList=false} -->

<!-- code_chunk_output -->
目录：
- [DesignPatterns](#designpatterns)
  - [00.面向对象设计原则](#00面向对象设计原则)
  - [01.简单工厂模式](#01简单工厂模式)
  - [02.工厂方法模式](#02工厂方法模式)
  - [03.单例模式](#03单例模式)
  - [04.抽象工厂模式](#04抽象工厂模式)
<!-- /code_chunk_output -->


<div style="color:gray;text-align:right">shanzm-2020年4月7日 01:01:59</div>
<hr style="height:8px;border:none;border-top:5px double black;" />



### 00.面向对象设计原则

[设计模式——面向对象的设计原则](https://www.cnblogs.com/shanzhiming/p/12608123.html)

在软件开发中，为了提高软件系统的可维护性和可复用性，增加软件的可扩展性和灵活性，程序设计要尽量根据以下7 条原则来开发程序，从而提高软件开发效率、节约软件开发成本和维护成本。

|                         名称                         |                             定义                             | 使用频率 |
| :--------------------------------------------------: | :----------------------------------------------------------: | :------: |
|       开闭原则（ Open Closed Principle，OCP ）       |              软件实体应该对扩展开放，对修改关闭              |  ★★★★★   |
|  里氏替换原则（Liskov Substitution Principle，LSP）  |           父类对象出现的地方都可以使用子类对象替换           |  ★★★★★   |
| 依赖倒置原则（Dependence Inversion Principle，DIP）  | 高层模块不应该依赖低层模块，两者都应该依赖其抽象；抽象不应该依赖细节，细节应该依赖抽象 |  ★★★★★   |
| 单一职责原则（Single Responsibility Principle，SRP） |             一个类只负责一个功能领域中的相应职责             |  ★★★★☆   |
| 接口隔离原则（Interface Segregation Principle ,ISP)  |     不要使用单一的总接口，而是使用具体的有针对性的小接口     |  ★★☆☆☆   |
|           迪米特法则(Law of Demeter, LoD)            |       一个软件实体应当尽可能少地与其他实体发生相互作用       |  ★★★☆☆   |
|    合成复用原则（Composite Reuse Principle,CRP）     |      尽量使用对象组合，而不是使用继承来达到复用的目的      |  ★★★★☆   |



</br>
<hr style="height:8px;border:none;border-top:4px double black;" />

### 01.简单工厂模式

[设计模式——简单工厂模式](https://www.cnblogs.com/shanzhiming/p/12616423.html)

**简单工厂模式（Simple Factory Principle）**：定义一个工厂类，根据不同的参数，创建并返回不同的类。其中这些类具有一个公共的父类或是一个接口。

简单工厂模式不属于GoF四人组提出的23种设计模式，它是最简单的工厂模式。

示例源于《大话设计模式》，通过一个简单的四则计算器来逐步的重构，最终通过简单工厂实现一个简单的四则计算器。

</br>
<hr style="height:8px;border:none;border-top:4px double black;" />

### 02.工厂方法模式

[设计模式——工厂方法模式](https://www.cnblogs.com/shanzhiming/p/12629387.html)

**工厂方法模式（Factory Method Pattern）**也称为**工厂模式**，又称为虚拟构造器模式或多态模式。

在工厂方法模式中，工厂父类负责定义创建产品对象的公共接口，而工厂子类则负责生成具体的产品对象，这样做的目的是将产品类的实例化操作延迟到工厂子类中完成，即通过工厂子类来确定究竟应该实例化哪一个具体产品类。

示例1是对简单工厂模式中的四则计算器的重构

示例2是源于《设计模式实训-第二版》，是模拟实现一个可以将日志存入文件和数据库中的日志记录器

</br>
<hr style="height:8px;border:none;border-top:4px double black;" />

### 03.单例模式

[设计模式——单例模式](https://www.cnblogs.com/shanzhiming/p/12663493.html)

**单例模式（Singleton Pattern）**：确保某一个类只有一个实例，而且自行实例化并向整个系统提供这个实例。

实现单例模式的最好方法就是，私有化构造函数，让类自己内部创建一个实例并在类内部保存它的这个唯一实例，并提供一个访问该实例的静态方法GetInstance()

单例模式分为两种：“懒汉式单例模式”和“饿汉式单例模式”。

示例1源于《大话设计模式》，是个WinForm项目，实现特定窗口一次只能创建一个。

示例2改编于《研磨设计模式》，实现读取配置的类单例化。在实现单例化后重构实现线程安全，再之后重构实现饿汉式单例模式。

</br>
<hr style="height:8px;border:none;border-top:4px double black;" />

### 04.抽象工厂模式

[设计模式——抽象工厂模式](https://www.cnblogs.com/shanzhiming/p/12815420.html)

**抽象工厂模式（Abstract Factory Pattern）**：为创建一组相关或相互依赖的对象提供一个接口，而且无须指定它们的具体类。

注意抽象工厂模式中的两个新概念：**产品族**、**产品等级**

示例1源于《大话设计模式》，是使用工厂方法模式实现切换操作数据某个表的操作类

示例2对示例1的扩展，实现可以同时切换多个表的操作类，即完整的实现切换数据库

之后，使用简单工厂进行重构，实现简化工厂类。

</br>
<hr style="height:8px;border:none;border-top:4px double black;" />



### 责任链模式

[设计模式——责任链模式]()

**责任链模式（Chain of Responsibility）**：为了避免请求发送者与多个请求处理者耦合在一起，将所有请求的处理者通过前一对象记住其下一个对象的引用而连成一条链；当有请求发生时，可将请求沿着这条链传递，直到有对象处理它为止。

示例来源于C语言中文网，模拟学生请假审批模块

</br>
<hr style="height:8px;border:none;border-top:4px double black;" />