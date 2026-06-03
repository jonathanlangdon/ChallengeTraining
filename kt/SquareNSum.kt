// square each inputed number from an array and sum them

package solution

fun squareSum(n: Array<Int>): Int = n.map{it * it}.sum()

fun main() {
    println(squareSum(arrayOf(1, 2)))       // expected: 5
    println(squareSum(arrayOf(0, 3, 4, 5))) // expected: 50
    println(squareSum(arrayOf()))           // expected: 0
}