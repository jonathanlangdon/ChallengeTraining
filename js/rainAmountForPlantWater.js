// fix rain function to determine how much to water plant

function rainAmount(mm) {
  if (mm >= 40) {
    return 'Your plant has had more than enough water for today!';
  } else {
    return `You need to give your plant ${40 - mm}mm of water`;
  }
}

console.log(rainAmount(100));
console.log(rainAmount(10));
