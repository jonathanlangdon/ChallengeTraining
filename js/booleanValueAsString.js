// return boolean value as string

const trueOrFalse = val => String(Boolean(val));

console.log(trueOrFalse(1 > 2)); // "false"
console.log(trueOrFalse(true && false)); // "false"
console.log(trueOrFalse(123)); // "true"
