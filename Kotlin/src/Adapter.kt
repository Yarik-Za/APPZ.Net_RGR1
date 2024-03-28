import java.time.LocalDate
import java.time.format.DateTimeFormatter

interface DateParser {
    fun parseDate(dateString: String): LocalDate
}

class DateAdapter : DateParser {
    override fun parseDate(dateString: String): LocalDate {
        return LocalDate.parse(dateString, DateTimeFormatter.ofPattern("yyyy-MM-dd"))
    }
}

fun main() {
    val dateParser: DateParser = DateAdapter()
    val parsedDate = dateParser.parseDate("2024-03-20")

    println(parsedDate)
}
