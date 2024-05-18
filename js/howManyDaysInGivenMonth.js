// determine how many days in month given month number

function howManydays(month) {
  if ([4, 6, 9, 11].includes(month)) return 30;
  if (month == 2) return 28;
  else return 31;
}

console.log(howManydays(3)); // 31
console.log(howManydays(2)); // 28
console.log(howManydays(4)); // 30
