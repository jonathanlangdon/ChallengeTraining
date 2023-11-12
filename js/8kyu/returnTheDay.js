// return day of week with number input

function whatday(n) {
  const dow = [
    'Sunday',
    'Monday',
    'Tuesday',
    'Wednesday',
    'Thursday',
    'Friday',
    'Saturday'
  ]
  return dow[n - 1] || 'Wrong, please enter a number between 1 and 7'
}

console.log(whatday(3)) // Tuesday
console.log(whatday(8)) // error message
console.log(whatday(0)) // error message
