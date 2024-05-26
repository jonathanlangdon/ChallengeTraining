// return summation of 1 through the value of n

export const summation = (num: number) => {
  let sum = 0;
  for (let i = 1; i <= num; i++) {
    sum += i;
  }
  return sum;
};

console.log(summation(5)); // 15
