# 静态代理模式

## 优点

* 在不修改目标对象的情况下，对目标对象进行功能扩展

## 缺点

* 因为代理对象需要和目标对象都实现同一个接口，所以会有很多代理类

* 一旦接口增加方法，目标对象和代理对象都需要维护