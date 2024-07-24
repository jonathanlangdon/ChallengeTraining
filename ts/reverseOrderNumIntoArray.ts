// return digits in reverse (and in an array)

export const digitize = (n: number): number[] => {
  const numArr: string[] = n.toString().split('').reverse();
  return numArr.map(n => Number(n));
};

console.log(digitize(1234)); // 4321
