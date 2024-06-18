// determine how many liters Nathan needs to drink

export function litres(time: number): number {
  return Math.floor(time / 2);
}

console.log(litres(3)); // 1
console.log(litres(6.7)); // 3
console.log(litres(11.8)); // 5
