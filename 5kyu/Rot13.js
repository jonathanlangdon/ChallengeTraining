const rot13 = str => {
  let arr = str.split('');
  for (let i = 0; i < arr.length; i++) {
    let n = str.charCodeAt(i);
    if ((n >= 65 && n <= 77) || (n >= 97 && n <= 109)) {
      n += 13;
    } else if (n >= 78 && n <= 90) {
      n = 65 + 13 - (91 - n)
    } else if (n >= 110 && n <= 122) {
      n = 97 + 13 - (123 - n)
    }
    arr[i] = String.fromCharCode(n);
  }
  return arr.join('');
}

/* ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 letters after it in the alphabet. ROT13 is an example of the Caesar cipher.

Create a function that takes a string and returns the string ciphered with Rot13. If there are numbers or special characters included in the string, they should be returned as they are. Only letters from the latin/english alphabet should be shifted, like in the original Rot13 "implementation".
*/

/*
A better solution I found froms someone else:

const rot13 = str => {
  const a = 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ'
  const b = 'nopqrstuvwxyzabcdefghijklmNOPQRSTUVWXYZABCDEFGHIJKLM'
  return str.replace(/[a-z]/gi, c => b[a.indexOf(c)])
}
*/
