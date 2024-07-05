// return lowest unused id_number

function nextId(ids) {
  let uniqueIds = new Set(ids);
  const sortedIds = Array.from(uniqueIds).sort((a, b) => a - b);
  for (let i = 0; i <= sortedIds.length; i++) {
    if (sortedIds[i] !== i) return i;
  }
  return sortedIds[ids.length - 1] + 1;
}

console.log(nextId([3, 4, 0, 1, 2, 2, 6])); // 5
console.log(nextId([3, 4, 1, 2, 2, 6])); // 0
console.log(nextId([0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10])); // 11
console.log(nextId([3, 4, 0, 1, 2, 2, 5, 6])); // 7
