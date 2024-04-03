// return an array either squaring or square-rooting items in array

function squareOrSquareRoot(array) {
  return array.map(n => (Math.sqrt(n) % 1 === 0 ? Math.sqrt(n) : n ** 2))
}
