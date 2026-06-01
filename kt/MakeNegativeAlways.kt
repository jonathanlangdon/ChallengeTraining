// make sure any input number outputs to a negative

fun main() {
    val kata = Kata()
    println(kata.makeNegative(42)) // expected: -42
    println(kata.makeNegative(-432)) // expected: -432
}

class Kata {
    fun makeNegative(x: Int): Int = if (x > 0) -x else x
}