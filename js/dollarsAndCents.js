// Take a float and return proper currency format

const formatMoney = amount => `\$${amount.toFixed(2)}`

console.log(formatMoney(39.99))
console.log(formatMoney(39.9))
console.log(formatMoney(39))
