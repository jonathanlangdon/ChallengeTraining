// return an operation given the operator as a argument

export function basicOp(op: string, val1: number, val2: number): number {
  return eval(val1 + op + val2);
}

console.log(basicOp('+', 4, 7)); // 11
