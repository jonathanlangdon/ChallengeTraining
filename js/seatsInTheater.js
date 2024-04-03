// calculate how many people would have their view blocked leaving your seat

function seatsInTheater(nCols, nRows, col, row) {
  return (nCols - col + 1) * (nRows - row)
}
