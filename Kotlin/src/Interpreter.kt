interface Expression {
    fun interpret(): Int
}

class NumberExpression(private val number: Int) : Expression {
    override fun interpret(): Int {
        return number
    }
}

class AddExpression(private val left: Expression, private val right: Expression) : Expression {
    override fun interpret(): Int {
        return left.interpret() + right.interpret()
    }
}

fun main() {
    val expression: Expression = AddExpression(NumberExpression(10), NumberExpression(5))
    println(expression.interpret()) // Результат: 15
}
