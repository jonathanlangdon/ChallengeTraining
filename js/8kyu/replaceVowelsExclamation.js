// Replace all vowel to exclamation mark in the sentence. aeiouAEIOU is vowel.

const replace = sentence => sentence.replace(/[aeiou]/gi, '!')

console.log(replace('!Hi! HI!'))
