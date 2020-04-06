## DesignPatterns


<!-- @import "[TOC]" {cmd="toc" depthFrom=1 depthTo=6 orderedList=false} -->

<!-- code_chunk_output -->
目录：
- [DesignPatterns](#designpatterns)
  - [00.面向对象设计原则](#00面向对象设计原则)
  - [01.简单工厂模式](#01简单工厂模式)
  - [02.工厂方法模式](#02工厂方法模式)
  - [03.单例模式](#03单例模式)
  - [02.工厂方法模式](#02工厂方法模式)
<!-- /code_chunk_output -->


<div style="color:gray;text-align:right">shanzm-2020年4月7日 01:01:59</div>
<hr style="height:8px;border:none;border-top:5px double black;" />



### 00.面向对象设计原则

[设计模式——面向对象的设计原则](https://www.cnblogs.com/shanzhiming/p/12608123.html)

在软件开发中，为了提高软件系统的可维护性和可复用性，增加软件的可扩展性和灵活性，程序设计要尽量根据以下7 条原则来开发程序，从而提高软件开发效率、节约软件开发成本和维护成本。
1. 开闭原则
2. 里氏替换原则
3. 依赖倒置原则
4. 单一职责原则
5. 接口隔离原则
6. 迪米特法则
7. 合成复用原则

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

### 03.单例模式

**单例模式（Singleton Pattern）**：确保某一个类只有一个实例，而且自行实例化并向整个系统提供这个实例。

实现单例模式的最好方法就是，私有化构造函数，让类自己内部创建一个实例并在类内部保存它的这个唯一实例，并提供一个访问该实例的静态方法GetInstance()

单例模式分为两种：“懒汉式单例模式”和“饿汉式单例模式”。

示例1源于《大话设计模式》，是个WinForm项目，实现特定窗口一次只能创建一个。

示例2改编于《研磨设计模式》，实现读取配置的类单例化。在实现单例化后重构实现线程安全，再之后重构实现饿汉式单例模式。

