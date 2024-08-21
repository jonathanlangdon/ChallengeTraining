// calculate time since midnight in milliseconds

export function past(h: number, m: number, s: number): number {
  return (h * 3600 + m * 60 + s) * 1000;
}

console.log(past(0, 1, 1)); // 61000
