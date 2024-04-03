// find average of values of an array

var findAverage = function (nums) {
  let count = 0
  let sum = 0
  nums.map(x => (sum += x) && (count += 1))
  if (count === 0) return 0
  return sum / count
}

console.log(findAverage([0, 0, 1, 2, 3])) // 4
