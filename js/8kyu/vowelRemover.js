// removes all lowercase vowels from a string

const shortcut = str => str.replace(/[aeiou]/g, '')

console.log(shortcut('this is the end'))
