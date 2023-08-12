// remove all zeros at the end of a number (leave 0)

function noBoringZeros(n) {
  return n == 0 ? 0 : Number(String(n).replace(/0+$/, ''))
}

console.log(noBoringZeros(1450)) // 145
