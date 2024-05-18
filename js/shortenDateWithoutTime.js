// return shortened date/time format that removes the time

const shortenToDate = longDate => longDate.split(',')[0];

console.log(shortenToDate('Friday May 2, 7pm')); // Friday May 2
