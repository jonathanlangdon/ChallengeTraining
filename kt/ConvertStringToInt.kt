// convert a string to an int

fun stringToNumber(str: String): Int = str.toInt()


fun main() {
    println(stringToNumber("1234")) // expected: 1234
    println(stringToNumber("605"))  // expected: 605
    println(stringToNumber("1405")) // expected: 1405
    println(stringToNumber("-7"))   // expected: -7
}
