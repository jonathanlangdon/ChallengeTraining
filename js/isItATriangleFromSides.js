// given 3 side lengths, determine if it can be a triangle

function isTriangle(...sides) {
  if (sides.reduce((a, c) => a + c, 0) <= 0) return false;
  const [a, b, c] = sides;
  const inequality1 = a + b > c;
  const inequality2 = a + c > b;
  const inequality3 = b + c > a;
  return inequality1 && inequality2 && inequality3;
}
console.log(isTriangle(1, 2, 2)); // true
console.log(isTriangle(4, 2, 3)); // true
console.log(isTriangle(2, 2, 2)); // true
console.log(isTriangle(1, 2, 3)); // false
console.log(isTriangle(-5, 1, 2)); // false
console.log(isTriangle(0, 2, 3)); // false
console.log(isTriangle(1, 2, 9)); // false
