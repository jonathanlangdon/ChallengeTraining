// calculate sum of nth row of odd number triangle

function rowSumOddNumbers(n) {
  return n ** 3;
}

console.log(rowSumOddNumbers(4));

/* other method:
function rowSumOddNumbers(n) {
  const rowArray = Array.from({length: n}, (_, index) => n**2 - n + 1 + index *2);
  return rowArray.reduce((a, c) => a + c, 0) // sum up row
}*/
