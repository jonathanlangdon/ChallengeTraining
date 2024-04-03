/* Your friend is traveling abroad to the United States so he wrote a program to convert fahrenheit to celsius. Unfortunately his code has some bugs.

Find the errors in the code to get the celsius converter working properly. */

function weatherInfo(temp) {
  const c = convertToCelsius(temp)
  return `${c} is ${c > 0 ? 'above ' : ''}freezing temperature`
}

function convertToCelsius(temperature) {
  const celsius = (temperature - 32) * (5 / 9)
  return celsius.toFixed(0)
}

console.log(weatherInfo(56))
