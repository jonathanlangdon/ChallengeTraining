// return sum of all positive values in an array

export const positiveSum = (arr: number[]): number =>
  arr.reduce((a, c) => (c > 0 ? a + c : a), 0);

console.log(positiveSum([-1, 2, -3, 4])); // 6
