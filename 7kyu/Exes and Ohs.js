function XO(str) {
  const count = char => str.toLowerCase().split(char).length - 1;
  return count('x') === count('o');
}

// That was my final(3rd) solution


// 1st Idea

/* 
function XO(str) {
  const count = char => {
  return (str.match(new RegExp(`${char}`, 'gi')) 
    || 0).length}
  return count('x') === count('o')
}
*/


// 2nd Idea
/* function XO(str) {
  const strLow = str.toLowerCase();
  return (strLow.split('x').length - 1)
    === (strLow.split('o').length - 1)
}
*/


/* Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. The string can contain any char.

Examples input/output:

XO("ooxx") => true
XO("xooxx") => false
XO("ooxXm") => true
XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
XO("zzoo") => false

*/
