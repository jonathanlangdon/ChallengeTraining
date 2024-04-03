//Try # 2
const twiceAsOld = (dadAge, sonAge) => Math.abs(dadAge - 2 * sonAge);

/*
function twiceAsOld(dadAge, sonAge) {
  const ageDiff = dadAge - sonAge;
  let hypSon = 1;
  let hypDad = hypSon + ageDiff; 
  while (hypSon * 2 !== hypDad) {
    hypSon++;
    hypDad++;
  }
  return Math.abs(hypDad - dadAge);
}

Your function takes two arguments:

    current father's age (years)
    current age of his son (years)

Сalculate how many years ago the father was twice as old as his son (or in how many years he will be twice as old). The answer is always greater or equal to 0, no matter if it was in the past or it is in the future.
*/
