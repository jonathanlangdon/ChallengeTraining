// create basic functions for arrays

function getLength(arr) {
  return arr.length
}

function getFirst(arr) {
  return arr[0]
}

function getLast(arr) {
  return arr[arr.length - 1]
}

function pushElement(arr) {
  const el = 1
  arr.push(el)
  return arr
}

function popElement(arr) {
  arr.pop(arr.length - 1)
  return arr
}

console.log(getLength([1, 2, 3])) // 3
console.log(getFirst([1, 2, 3])) // 1
console.log(getLast([1, 2, 3])) // 3
console.log(pushElement([1, 2, 3]).length) // 4
console.log(popElement([1, 2, 3]).length) // 2
