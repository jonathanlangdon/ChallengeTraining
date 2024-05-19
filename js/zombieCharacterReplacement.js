// replace all characters with zombie characters//

function contamination(text, zombieChar) {
  return text.replace(/./g, zombieChar);
}

console.log(contamination('this is it', '^')); //^^^^^^^^^^

/* other methods

function contamination(text, char) {
  return text.split("").fill(char).join("");
}

/////////////////////////////////////////////////

function contamination(text, char) {
  return char.repeat(text.length);
}

*/
