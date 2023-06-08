/* solution #2 - still too long to calculate
function elderAge(m,n,l,t) {
  let matrix = 0;
  for (let i = 0; i < n; i++) {
    for (let j = 0; j < m; j++) {
      matrix += i^j || (i^j) - l;
    }
  }
  return matrix % t;
}

console.log(elderAge(8,8,0,100007))
*/

/* first solution - too long in evaluating
function elderAge(m,n,l,t) {
  let matrix = [];
  for (let i = 0; i < n; i++) {
    matrix[i] = [];
    for (let j = 0; j < m; j++) {
      matrix[i][j] = (i^j) - l > 0 ? (i^j) - l : 0;
    }
  }
  return matrix.flat().reduce((a,c)=> a + c) % t;
}

console.log(elderAge(8,8,0,100007))
*/
