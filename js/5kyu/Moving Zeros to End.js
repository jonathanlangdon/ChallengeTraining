const moveZeros = arr => {
  let count = 0;
  let newArr = [];
  arr.forEach(el => el === 0 ? count++ : newArr.push(el))
  for (let i = 1; i <= count; i++) {
    newArr.push(0)
  }
  return newArr;
}

/* Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

moveZeros([false,1,0,1,2,0,1,3,"a"]) // returns[false,1,1,2,1,3,"a",0,0]

*/

/* not the simpliest way to do it... I'll work on better solutions... */
