// make all numbers negative (or keep negative if already negative)

export const makeNegative = (num: number): number => {
  return num > 0 ? -num : num;
};

console.log(makeNegative(-5)); // -5
console.log(makeNegative(5)); // -5
console.log(makeNegative(0)); // 0
