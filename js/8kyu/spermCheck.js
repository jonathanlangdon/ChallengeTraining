// return whether someone is expecting boy or girl based on sperm

function chromosomeCheck(sperm) {
  if (sperm === 'XX') return "Congratulations! You're going to have a daughter."
  else return "Congratulations! You're going to have a son."
}

console.log(chromosomeCheck('XX'))
