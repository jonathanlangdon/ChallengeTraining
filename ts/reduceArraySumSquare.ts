// sum each value in an array after squaring each value

export const squareSum = (numbers: number[]): number => numbers.reduce((a, c) => a + c ** 2, 0);

console.log(squareSum([1, 2, 2]))