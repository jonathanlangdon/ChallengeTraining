// fix an arrow function that multiplies

val multiply: (Double, Double) -> Double = { x, y -> x * y }

fun main() {
    println(multiply(1.0, 1.0)) // 1.0
    println(multiply(2.0, 1.0)) // 2.0
    println(multiply(2.0, 2.0)) // 4.0
    println(multiply(3.0, 5.0)) // 15.0
    println(multiply(0.5, 0.5)) // 0.25
    println(multiply(5.0, 0.0)) // 0.0
    println(multiply(0.0, 5.0)) // 0.0
    println(multiply(0.0, 0.0)) // 0.0
}
