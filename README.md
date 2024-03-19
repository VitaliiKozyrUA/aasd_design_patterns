# aasd_design_patterns

```mermaid
classDiagram
      Creator <|-- ConcreteCreator
      Product <|.. ConcreteProduct
      
      class Creator {
          +FactoryMethod() Product
          +AnOperation() void
      }
      
      class ConcreteCreator {
          +FactoryMethod() Product
      }
      
      class Product {
          <<interface>>
      }
      
      class ConcreteProduct {
          +operation1()
          +operation2()
      }
```
```mermaid
classDiagram
      Flyweight <|.. ConcreteFlyweight
      FlyweightFactory ..> Flyweight
      class Flyweight{
          <<interface>>
          -IntrinsicState
          +Operation(extrinsicState)
      }
      class ConcreteFlyweight{
          -AllState
          +Operation(extrinsicState)
      }
      class FlyweightFactory{
          -flyweights
          +GetFlyweight(key)
      }
```
```mermaid
classDiagram
  class Subject {
    +RegisterObserver(Observer)
    +RemoveObserver(Observer)
    +NotifyObservers()
  }
  class Observer {
    +Update()
  }
  class ConcreteObserver {
    +Update()
  }
  Subject "1" *-- "*" Observer : notifies >
  Observer <|-- ConcreteObserver
```
```mermaid
classDiagram
class Proxy {
  +Service()
}

class Servant {
  +Service()
}

class MethodRequest {
  +Call()
}

class Scheduler {
  +Schedule()
}

class ActivationList {
  +AddMethodRequest()
  +RemoveMethodRequest()
}

Proxy --> Scheduler : uses
Servant --> MethodRequest : implements
Scheduler --> ActivationList : uses
ActivationList o-- MethodRequest : contains
```
