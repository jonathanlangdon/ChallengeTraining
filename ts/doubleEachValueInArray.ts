// double each value in an array

export function maps(arr: number[]): number[] {
  return arr.map(x => x * 2);
}

console.log(maps([1, 2, 3])); // 2, 4, 6
