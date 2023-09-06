// return an object's properties in a formatted string

function animal(obj) {
  return `This ${obj.color} ${obj.name} has ${obj.legs} legs.`
}

console.log(animal({ name: 'dog', legs: 4, color: 'white' }))
// returns "This white dog has 4 legs."
