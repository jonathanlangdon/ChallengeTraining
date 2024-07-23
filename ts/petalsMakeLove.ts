// determine love by number of flower petals

export function lovefunc(flower1: number, flower2: number): boolean {
  return (flower1 + flower2) % 2 == 0 ? false : true;
}

console.log(lovefunc(2, 3)); // true
