// convert boolean values to yes or no

export const boolToWord = (bool: boolean): string => (bool ? 'Yes' : 'No');

console.log(boolToWord(true)); // "Yes"
console.log(boolToWord(false)); // "No"
