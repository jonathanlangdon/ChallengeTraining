function billboard(name, price = 30) {
  let totalPrice = 0;
  for (let i = 0; i < name.length; i++) {
    totalPrice += price;
  }
  return totalPrice;
}

module.exports = { billboard };
