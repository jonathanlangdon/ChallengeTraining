// reverse a string passed to it

export const solution = (str: string): string =>
  str.split('').reverse().join('');

console.log(solution('this')); // siht
