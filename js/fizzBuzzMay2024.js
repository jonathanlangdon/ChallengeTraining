// fizzbuzz 2024 May

function fizzBuzz() {
  for (let i = 1; i <= 100; i++) {
    const fizz = i % 3 == 0;
    const buzz = i % 5 == 0;
    let result = '';
    if (fizz) result += 'Fizz';
    if (buzz) result += 'Buzz';
    console.log(`${result ? result : i}`);
  }
}

fizzBuzz();
