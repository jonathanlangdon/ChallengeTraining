// find smallest integer in an array

class SmallestIntegerFinder {

  fun findSmallestInt(nums: List<Int>): Int = nums.min()

}

fun main() {
    val sif = SmallestIntegerFinder()
    println(sif.findSmallestInt(listOf(15, 20, 10, 17, 22, 9001))) // expected: 10
    println(sif.findSmallestInt(listOf(15, 20, 10, 17, -22, 9001))) // expected: -22
}