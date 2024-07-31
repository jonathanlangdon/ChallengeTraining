function paperwork(n: number, m: number): number {
  return n >= 0 && m >= 0 ? n * m : 0;
}

console.log(paperwork(5, 4)); // 20
console.log(paperwork(-5, 4)); // 0
console.log(paperwork(5, -4)); // 0
