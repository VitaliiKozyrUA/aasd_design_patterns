package com.test

import kotlinx.coroutines.DelicateCoroutinesApi
import kotlinx.coroutines.GlobalScope
import kotlinx.coroutines.launch
import java.util.concurrent.LinkedBlockingQueue

@OptIn(DelicateCoroutinesApi::class)
class ActiveObject {
    private val dispatchQueue = LinkedBlockingQueue<() -> Unit>()
    var value = 0.0

    init {
        GlobalScope.launch {
            while (true) {
                try {
                    dispatchQueue.take().invoke()
                } catch (e: InterruptedException) {

                }
            }
        }
    }

    fun doSomething() {
        dispatchQueue.add { value = 1.0 }
    }

    fun doSomethingElse() {
        dispatchQueue.add { value = 2.0 }
    }
}