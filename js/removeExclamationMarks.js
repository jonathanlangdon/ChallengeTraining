// remove an input number of exclamation marks from a string

function remove(s, n) {
  let newString = s;
  for (let i = 0; i < n; i++) {
    newString = newString.replace('!', '');
  }
  return newString;
}

console.log(remove('Hi!!', 1)); // Hi!
console.log(remove('Hi!!', 2)); // Hi
console.log(remove('Hi!!', 0)); // Hi!!
