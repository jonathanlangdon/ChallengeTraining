// tests to calculate how many stairs are climbed in 20 years

const { stairsIn20 } = require('./suzukiStairs');

describe('suite 1 of tests`', () => {
  describe('run a specific number of steps', () => {
    it('should calculate a specific number', () => {
      //Arrange
      const expected = 1327320;
      const sunday = [6737, 7244, 5776];
      const monday = [9175, 7883, 7596];
      const tuesday = [8646, 6945, 6364];
      const stairs = [sunday, monday, tuesday];
      //Act
      const actual = stairsIn20(stairs);
      //Assert
      expect(actual).toBe(expected);
    });
  });
});
