// return sum of positive numbers from an array

fun sum(numbers: IntArray): Int {
    var numberSum = 0
    numbers.forEach { number ->
        if (number > 0) numberSum += number
    }
    return numberSum
}

fun main() {
    println(sum(intArrayOf(1, 2, 3, 4, 5)))       // expected: 15
    println(sum(intArrayOf(1, -2, 3, 4, 5)))      // expected: 13
    println(sum(intArrayOf()))                    // expected: 0
    println(sum(intArrayOf(-1, -2, -3, -4, -5)))  // expected: 0
    println(sum(intArrayOf(-1, 2, 3, 4, -5)))     // expected: 9
}