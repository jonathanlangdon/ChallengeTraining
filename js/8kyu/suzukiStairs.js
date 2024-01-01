// calculate how many stairs are climbed in 20 years

function stairsIn20(s) {
  return [...s].flat().reduce((a, c) => a + c) * 20;
}

module.exports = { stairsIn20 };
