import java.util.concurrent.locks.ReentrantLock

class SharedResource {
    private var counter = 0
    private val lock = ReentrantLock()

    fun increment() {
        lock.lock()
        try {
            counter++
        } finally {
            lock.unlock()
        }
    }

    fun getValue(): Int {
        lock.lock()
        try {
            return counter
        } finally {
            lock.unlock()
        }
    }
}

fun main() {
    val resource = SharedResource()

    val thread1 = Thread {
        repeat(10000) { resource.increment() }
    }

    val thread2 = Thread {
        repeat(10000) { resource.increment() }
    }

    thread1.start()
    thread2.start()

    thread1.join()
    thread2.join()

    println("Final value: ${resource.getValue()}")
}
