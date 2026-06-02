// Remove the first and last characters of a string

fun removeChar(str: String): String = str.substring(1,str.lastIndex)

fun main() {
    println(removeChar("eloquent")) // expected: loquen
    println(removeChar("country"))  // expected: ountr
    println(removeChar("person"))   // expected: erso
    println(removeChar("place"))    // expected: lac
    println(removeChar("ok"))       // expected: 
}