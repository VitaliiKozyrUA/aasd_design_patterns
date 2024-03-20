package com.test

class ConcreteFlyweight(private val intrinsicState: String) : IFlyweight {
    override fun operation(extrinsicState: String) {
        println("ConcreteFlyweight: IntrinsicState $intrinsicState, ExtrinsicState $extrinsicState")
    }
}

class FlyweightFactory {
    private val flyweights = HashMap<String, IFlyweight>()

    fun getFlyweight(key: String): IFlyweight {
        if (!flyweights.containsKey(key)) {
            flyweights[key] = ConcreteFlyweight(key)
        }
        return flyweights[key]!!
    }
}

interface IFlyweight {
    fun operation(extrinsicState: String)
}