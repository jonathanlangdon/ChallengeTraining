// write a function that takes two parameters: the year of birth and the year to count years in relation to.

function calculateAge(birthYear, curYear) {
  const age = curYear - birthYear
  if (curYear > birthYear) {
    return `You are ${age} year${age > 1 ? 's' : ''} old.`
  } else if (curYear < birthYear) {
    return `You will be born in ${-age} year${-age > 1 ? 's' : ''}.`
  } else if (curYear === birthYear) {
    return 'You were born this very year!'
  } else {
    return 'Error: please enter valid input'
  }
}

console.log(calculateAge(2012, 2016)) // You are 4 years old.");
console.log(calculateAge(1989, 2016)) // You are 27 years old.");
console.log(calculateAge(2000, 2090)) // You are 90 years old.");
console.log(calculateAge(2000, 1990)) // You will be born in 10 years.");
console.log(calculateAge(3400, 3400)) // You were born this very year!");
console.log(calculateAge(900, 2900)) // You are 2000 years old.");
console.log(calculateAge(2010, 1990)) // You will be born in 20 years.");
console.log(calculateAge(2010, 1500)) // You will be born in 510 years.");
console.log(calculateAge(2011, 2012)) // You are 1 year old.");
console.log(calculateAge(2000, 1999)) // You will be born in 1 year.");
