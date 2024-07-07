// remove extra exclamation marks from string

function remove(string) {
  return string.replaceAll('!', '') + '!';
}

console.log(remove('Th!is! has! !!too many')); // This has too many!
