// Fizz Buzz using a recursive function

function fizzBuzz(num) {
  if (num > 100) return;
  let result = '';
  if (num % 3 == 0) result += 'Fizz';
  if (num % 5 == 0) result += 'Buzz';
  if (result == '') result = num;
  console.log(result);
  fizzBuzz(num + 1);
}

fizzBuzz(1);
