// create subclasses for Adam and Eve

class Human {}
class Man extends Human {}
class Woman extends Human {}
class God {
  static create() {
    return [new Man(), new Woman()];
  }
}

const humans = God.create();

console.log(humans[0] instanceof Man);
console.log(humans[1] instanceof Woman);
