// count how many sheep are in an array

export function countSheeps(arrayOfSheep: (boolean | undefined | null)[]) {
  return arrayOfSheep.reduce((a, c) => (c ? a + 1 : a), 0);
}

console.log(
  countSheeps([
    true,
    true,
    true,
    false,
    true,
    true,
    true,
    true,
    true,
    false,
    true,
    false,
    true,
    false,
    false,
    true,
    true,
    true,
    true,
    true,
    false,
    false,
    true,
    true
  ])
); // 17

console.log(countSheeps([])); // 0

// Other method:

// export function countSheeps(arrayOfSheep) {
//   return arrayOfSheep.filter(x => x).length;
// }
