// convert mpg to km/L
function converter(mpg) {
  const milesToKm = 1.609344;
  const gallonsToLiters = 4.54609188;
  return +((mpg * milesToKm) / gallonsToLiters).toFixed(2);
}

module.exports = { converter };
