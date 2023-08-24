// reverse the words in a string

function reverse(string) {
  return string.split(' ').reverse().join(' ')
}

console.log(reverse('I am an expert at this'))
console.log(reverse(''))
