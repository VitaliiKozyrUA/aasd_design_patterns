package com.test

class ConcreteObserver : IObserver {
    override fun update() {
        println("ConcreteObserver received an update.")
    }
}

class ConcreteSubject : ISubject {
    private val observers = mutableListOf<IObserver>()

    override fun registerObserver(observer: IObserver) {
        observers.add(observer)
    }

    override fun removeObserver(observer: IObserver) {
        observers.remove(observer)
    }

    override fun notifyObservers() {
        for (observer in observers) {
            observer.update()
        }
    }
}

interface IObserver {
    fun update()
}

interface ISubject {
    fun registerObserver(observer: IObserver)
    fun removeObserver(observer: IObserver)
    fun notifyObservers()
}
