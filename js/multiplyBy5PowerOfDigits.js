// multiply a number by 5 raised to power of the number of digits

const multiply = num => num * 5 ** Math.abs(num).toString().length;

console.log(multiply(3)); // 15
console.log(multiply(10)); // 250
console.log(multiply(200)); // 25000
console.log(multiply(0)); // 0
console.log(multiply(-2)); // -10
