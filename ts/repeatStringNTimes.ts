// repeat a string n number of times

export function repeatStr(n: number, s: string): string {
  return s.repeat(n);
}

console.log(repeatStr(3, 'Hi')); // HiHiHi
