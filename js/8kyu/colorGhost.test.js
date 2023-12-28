const { Ghost } = require('./colorGhost');

describe('Ghost', () => {
  describe('property color in list of colors', () => {
    it('should return white, yellow, purple or red', () => {
      //Arrange
      const ghost = new Ghost();
      const expectedColors = ['white', 'yellow', 'purple', 'red'];
      //Act
      const actual = ghost.color;
      //Assert
      expect(expectedColors).toContain(actual);
    });
  });
  describe('color should not always be same color', () => {
    it('50 random objects should not all be the same color', () => {
      //Arrange
      const ghostSet = new Set();
      for (let i = 0; i < 50; i++) {
        const ghost = new Ghost();
        ghostSet.add(ghost.color);
      }
      console.log(ghostSet);
      const expected = 1; //Set size if only 1 color
      //Act
      const actual = ghostSet.size;
      //Assert
      expect(actual).toBeGreaterThan(expected);
    });
  });
});
