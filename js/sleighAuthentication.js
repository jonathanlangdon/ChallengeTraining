class Sleigh {
  authenticate(name, password) {
    return name === 'Santa Claus' && password === 'Ho Ho Ho!'
  }
}

const sleigh = new Sleigh()
console.log(sleigh.authenticate('Santa Claus', 'Ho Ho Ho!'))
// returns true
console.log(sleigh.authenticate('The Grinch', 'Ho Ho Ho!'))
// returns false
console.log(sleigh.authenticate('Santa Claus', 'Ho Ho!'))
// returns false
