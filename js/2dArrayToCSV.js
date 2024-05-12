// take a 2-d array and convert to CSV format

function toCsvText(arr) {
  return arr.join('\n');
}

console.log(
  toCsvText([
    [4, 2, 5],
    [3, 5, 2]
  ])
);
// '4,2,5\n'+'3,5,2\n'

/* long method:
  let new_csv = ""
  for (let i = 0; i < arr.length; i++) {
      for (let j = 0; j < arr[i].length; j++) {
          new_csv = new_csv.concat(arr[i][j]) + ","
      }
      new_csv = new_csv.slice(0, -1) + "\n"
  }
  new_csv = new_csv.slice(0, -1)
  return new_csv
*/
