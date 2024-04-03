// repair dalmatian function

function howManyDalmatians(numberOfDogs) {
  if (numberOfDogs <= 10) return 'Hardly any'
  else if (numberOfDogs <= 50) return 'More than a handful!'
  else if (numberOfDogs === 101) return '101 DALMATIANS!!!'
  else return "Woah that's a lot of dogs!"
}

console.log(howManyDalmatians(100))
