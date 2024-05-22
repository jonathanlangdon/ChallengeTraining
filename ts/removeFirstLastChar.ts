// remove first and last character of a string

export const removeChar = (str: string): string => str.slice(1, -1);

console.log(removeChar('this')); // hi
