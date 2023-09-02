// calculate price of mangos based on buy 2 get 1 free

function mango(quantity, price) {
  return (Math.floor(quantity / 3) * 2 + (quantity % 3)) * price
}

console.log(mango(7, 5)) //25
