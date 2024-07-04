// return what century a year is part of

export const centuryFromYear = (year: number): number => {
  return Math.ceil(year / 100);
};

console.log(centuryFromYear(1701)); // 18
console.log(centuryFromYear(1700)); // 17
console.log(centuryFromYear(1699)); // 17
