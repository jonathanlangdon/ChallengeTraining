// create function that determines if input int is odd or even

fun evenOrOdd(number: Int): String {
    return if(number % 2 == 0) "Even" else "Odd"
}

fun main() {
    println(evenOrOdd(1))   // expected: Odd
    println(evenOrOdd(2))   // expected: Even
    println(evenOrOdd(-1))  // expected: Odd
    println(evenOrOdd(-2))  // expected: Even
    println(evenOrOdd(0))   // expected: Even
}
