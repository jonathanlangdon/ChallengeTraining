// complete constructor for a person class

class Person {
  constructor(name, age) {
    this.info = `${name}s age is ${age}`;
  }
}

const john = new Person('john', 34);
console.log(john.info); // 'johns age is 34'
