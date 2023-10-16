function getDrinkByProfession(profession) {
  return bartender[profession.toLowerCase()] || 'Beer'
}

const bartender = {
  jabroni: 'Patron Tequila',
  'school counselor': 'Anything with Alcohol',
  programmer: 'Hipster Craft Beer',
  'bike gang member': 'Moonshine',
  politician: 'Your tax dollars',
  rapper: 'Cristal'
}

console.log(getDrinkByProfession('jabrOni')) //'Patron Tequila'");
console.log(getDrinkByProfession('scHOOl counselor')) //'Anything with alcohol'");
console.log(getDrinkByProfession('prOgramMer')) //'Hipster Craft Beer'");
console.log(getDrinkByProfession('bike ganG member')) //'Moonshine'");
console.log(getDrinkByProfession('poLiTiCian')) //'Your tax dollars'");
console.log(getDrinkByProfession('rapper')) //'Cristal'");
console.log(getDrinkByProfession('pundit')) //'Beer'");
console.log(getDrinkByProfession('Pug')) //'Beer'");
