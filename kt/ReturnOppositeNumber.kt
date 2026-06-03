// return the opposite sign of number inputed

fun main() {
    println(opposite(1))   // expected: -1
    println(opposite(0))   // expected: 0
    println(opposite(-25)) // expected: 25
}

fun opposite(number: Int): Int = -number