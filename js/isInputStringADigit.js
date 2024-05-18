// return whether an input is a number

function isDigit(str) {
  return str ? parseFloat(str) == str : false;
}

console.log(isDigit('-4.4'));
