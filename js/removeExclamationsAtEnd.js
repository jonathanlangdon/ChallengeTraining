// remove exclamation points from end of string

function remove(string) {
  return string.replace(/!*$/g, '');
}

console.log(remove('!H!i!!!')); // !H!i
