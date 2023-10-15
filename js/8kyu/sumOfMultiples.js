// return the sum of multiples

function sumMul(n, m) {
  if (m < 1 || n < 1) return 'INVALID'
  let sum = 0
  for (let i = n; i < m; i += n) {
    sum += i
  }
  return sum
}

console.log(sumMul(0, 0)) // INVALID
console.log(sumMul(2, 9)) // 20
console.log(sumMul(4, -7)) // INVALID
console.log(sumMul(4, 123)) // 1860
console.log(sumMul(760, 2)) // 0
