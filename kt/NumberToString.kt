// convert a number to a string by function

fun main() {
    println(numberToString(67))  // expected: 67
    println(numberToString(123)) // expected: 123
    println(numberToString(999)) // expected: 999
    println(numberToString(0))   // expected: 0
}

fun numberToString(num: Int): String = "$num"