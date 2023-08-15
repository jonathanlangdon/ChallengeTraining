// function that creates an array based on min, max, step input

/* Implement a function named generateRange(min, max, step), which takes three arguments and generates a range of integers from min to max, with the step. The first integer is the minimum value, the second is the maximum of the range and the third is the step. (min < max) */
function generateRange(min, max, step) {
  const arr = []
  for (let i = min; i <= max; i += step) {
    arr.push(i)
  }
  return arr
}

console.log(generateRange(2, 10, 3))
