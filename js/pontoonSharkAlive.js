// determine if shark will eat you

function shark(pontoonDist, sharkDist, youSpeed, sharkSpeed, dolphin) {
  const sharkTime = (sharkDist / sharkSpeed) * (dolphin ? 2 : 1);
  const youTime = pontoonDist / youSpeed;
  if (youTime < sharkTime) return 'Alive!';
  return 'Shark Bait!';
}

console.log(shark(12, 50, 4, 8, true)); //, "Alive!");
console.log(shark(7, 55, 4, 16, true)); //, "Alive!");
console.log(shark(24, 0, 4, 8, true)); //, "Shark Bait!");
