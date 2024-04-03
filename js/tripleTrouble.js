// Create a function that will return a string that combines all of the letters of the three inputed strings in groups. Taking the first letter of all of the inputs and grouping them next to each other.

function tripleTrouble(one, two, three) {
  const newArr = []
  one.split('').map((el, index) => newArr.push(el + two[index] + three[index]))
  return newArr.join('')
}

console.log(tripleTrouble('Sea', 'urn', 'pms')) // returns "Supermans"
