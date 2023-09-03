// with volume and side length as input, determine if it is a cube

var cubeChecker = function (volume, side) {
  return volume > 0 && side > 0 && side ** 3 === volume
}

console.log(cubeChecker(8, 2))
