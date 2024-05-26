// return smallest interger in an array

export const findSmallestInt = (numbers: number[]): number =>
  Math.min(...numbers);

console.log(findSmallestInt([4, 5, 8, 29])); // 4
