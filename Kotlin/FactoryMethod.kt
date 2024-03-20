package com.test

class ConcreteCreator : Creator() {
    override fun factoryMethod(): IProduct {
        return ConcreteProduct()
    }
}

class ConcreteProduct : IProduct {
    override fun operation(): String {
        return "Result of ConcreteProduct"
    }
}

abstract class Creator {
    abstract fun factoryMethod(): IProduct

    fun anOperation(): String {
        val product = factoryMethod()
        return "Creator: The same creator's code has just worked with ${product.operation()}"
    }
}

interface IProduct {
    fun operation(): String
}