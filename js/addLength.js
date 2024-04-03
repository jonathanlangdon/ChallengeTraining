// return an array of the words in a string with their length

const addLength = str => str.split(' ').map(word => `${word} ${word.length}`)

console.log(addLength('apple ban'))
