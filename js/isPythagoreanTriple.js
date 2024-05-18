// Determine if 3 integers work in pythagorean theorom in any order

function isPythagoreanTriple(integers) {
  const [n1, n2, n3] = integers;
  const way1 = n1 ** 2 + n2 ** 2 == n3 ** 2;
  const way2 = n2 ** 2 + n3 ** 2 == n1 ** 2;
  const way3 = n3 ** 2 + n1 ** 2 == n2 ** 2;
  return way1 || way2 || way3;
}

console.log(isPythagoreanTriple([4, 5, 3])); // true
console.log(isPythagoreanTriple([3, 5, 4])); // true
console.log(isPythagoreanTriple([3, 4, 5])); // true
console.log(isPythagoreanTriple([2, 4, 5])); // false
