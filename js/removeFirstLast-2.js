// modify a string of items separated by commas so first and last items are removed and then items separated by spaces instead

function array(string) {
  return string.split(',').slice(1, -1).join(' ') || null
}
