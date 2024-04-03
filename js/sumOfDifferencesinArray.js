// sort array then find sum of difference of pairs in array

function sumOfDifferences(arr) {
  return arr.sort((a,b)=> b - a)
  .reduce((a,c,i)=> a + (i > 0 ? arr[i - 1] - c : 0), 0)
}


