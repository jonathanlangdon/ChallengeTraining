// fill in an array with sequential numbers

function pipeFix(numbers) {
  const max = numbers.at(-1)
  const min = numbers[0]
  return Array.from({ length: max - min + 1 }, (_, index) => min + index)
}

console.log(pipeFix([1, 2, 3, 12]))
// returns [1,2,3,4,5,6,7,8,9,10,11,12]
