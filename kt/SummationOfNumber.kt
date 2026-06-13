// create a calculus like summation from 1 through a number

object GrassHopper {
  fun summation(n: Int) = (1..n).sum()
//   fun summation(n:Int):Int {
//       var sum = 0
//       for (i in 1..n) {
//           sum += i
//       }
//       return sum
//   }
}

fun main() {
    println(GrassHopper.summation(1)) // expected: 1
    println(GrassHopper.summation(8)) // expected: 36
}s
