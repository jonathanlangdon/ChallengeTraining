// return the closest elevator

function elevator(left, right, call) {
  return Math.abs(call - right) > Math.abs(call - left) ? 'left' : 'right';
}

console.log(
  elevator(0, 1, 0), // => "left"
  elevator(0, 1, 1), // => "right"
  elevator(0, 1, 2), // => "right"
  elevator(0, 0, 0), // => "right"
  elevator(0, 2, 1) // => "right"
);
