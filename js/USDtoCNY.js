//Create a function that converts US dollars (USD) to Chinese Yuan (CNY)

function usdcny(usd) {
  return `${(usd * 6.75).toFixed(2)} Chinese Yuan`
}

console.log(usdcny(15)) // 101.25 Chinese Yuan');
console.log(usdcny(465)) // 3138.75 Chinese Yuan');
console.log(usdcny(0.5)) // 3.38 Chinese Yuan');
console.log(usdcny(0)) // 0.00 Chinese Yuan');
