// filter an array by whether the items are a multiple of their indices

const multipleOfIndex = array => array.filter((x, i) => x === 0 || x % i === 0)

console.log(multipleOfIndex([0, 2, 3, 6, 9]))
// returns [ +0, 2, 6 ]
console.log(multipleOfIndex([22, -6, 32, 82, 9, 25]))
// returns [-6, 32, 25]
