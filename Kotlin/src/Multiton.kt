class Multiton private constructor() {
    companion object {
        private val instances = mutableMapOf<String, Multiton>()

        fun getInstance(key: String): Multiton {
            return instances.getOrPut(key) { Multiton() }
        }
    }
}

fun main() {
    val instance1 = Multiton.getInstance("key1")
    val instance2 = Multiton.getInstance("key2")
    val instance3 = Multiton.getInstance("key1")

    println(instance1.hashCode()) // Виведе хеш першого екземпляру
    println(instance2.hashCode()) // Виведе хеш другого екземпляру
    println(instance3.hashCode()) // Виведе інший хеш, оскільки це новий екземпляр

    println(instance1 === instance3) // Поверне true, оскільки це один і той же екземпляр
}
