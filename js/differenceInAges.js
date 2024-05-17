// with list of ages, find youngest, oldest and difference

function differenceInAges(ages) {
  const maxAge = Math.max(...ages);
  const minAge = Math.min(...ages);
  const ageDif = maxAge - minAge;
  return [minAge, maxAge, ageDif];
}

console.log(differenceInAges([82, 15, 6, 38, 35])); // [6, 82, 76]
