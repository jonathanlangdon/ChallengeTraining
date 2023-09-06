// find the closest square number

const nearestSq = n => Math.round(Math.sqrt(n)) ** 2

console.log(nearestSq(10)) //9
console.log(nearestSq(111)) //121
