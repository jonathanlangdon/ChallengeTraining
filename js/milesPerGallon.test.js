// // convert mpg to km/L tests
const { converter } = require('./milesPerGallon');

describe('Test Suite 1', () => {
  describe('correct conversions', () => {
    it('should return the correct conversion', () => {
      //Arrange
      const expected = 3.54;
      const input = 10;
      //Act
      const actual = converter(input);
      //Assert
      expect(actual).toBe(expected);
    });
    it('should return the correct conversion', () => {
      //Arrange
      const expected = 7.08;
      const input = 20;
      //Act
      const actual = converter(input);
      //Assert
      expect(actual).toBe(expected);
    });
  });
});
