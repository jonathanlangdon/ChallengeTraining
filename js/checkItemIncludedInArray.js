// determine if array contains a value without a loop

const check = (arr, x) => arr.includes(x);

console.log(check([66, 100], 66)); // true
console.log(check([64, 100], 66)); // false
