// is sum of squares of one array > sum of cubes of 2nd array

function arrayMadness(a, b) {
  const sumOfSquaresA = a.reduce((a, c) => a + c ** 2, 0);
  const sumOfCubesB = b.reduce((a, c) => a + c ** 3, 0);
  return sumOfSquaresA > sumOfCubesB;
}

console.log(arrayMadness([4, 5, 6], [1, 2, 3])); // true
