// determine if a string contains English

const spEng = sentence => sentence.toLowerCase().includes('english');

console.log(spEng('thdiEngLish')); // true
console.log(spEng('thdiEngLDish')); // false
