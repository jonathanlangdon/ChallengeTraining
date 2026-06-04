// repeat a string r number of times

fun repeatStr(r: Int, str: String) : String = str.repeat(r)

fun main() {
    println(repeatStr(4, "a"))     // expected: aaaa
    println(repeatStr(3, "Hello")) // expected: HelloHelloHello
    println(repeatStr(5, ""))      // expected: 
    println(repeatStr(0, "kata"))  // expected: 
    println(repeatStr(0, ""))      // expected: 
    println(repeatStr(6, "I"))     // expected: IIIIII
    println(repeatStr(5, "Hello")) // expected: HelloHelloHelloHelloHello
}
