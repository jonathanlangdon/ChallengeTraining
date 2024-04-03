// function to create a ghost object with random color

function Ghost() {
  const colors = ['white', 'yellow', 'purple', 'red'];
  const randomIndex = Math.floor(Math.random() * colors.length);
  this.color = colors[randomIndex];
}

module.exports = { Ghost };
