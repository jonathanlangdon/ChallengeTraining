const { twoDecimalPlaces } = require('./formattingDecimalPlaces0');

describe('twoDecimalPlaces', () => {
  describe('integer', () => {
    it('should return integer + .00', () => {
      //Arrange
      const expected = 5.0;
      const input = 5;
      //Act
      const actual = twoDecimalPlaces(input);
      //Assert
      expect(actual).toBe(expected);
    });
  });
  describe('roundup', () => {
    it('should return value rounded up', () => {
      //Arrange
      const expected = 5.56;
      const input = 5.5589;
      //Act
      const actual = twoDecimalPlaces(input);
      //Assert
      expect(actual).toBe(expected);
    });
  });
  describe('rounddown', () => {
    it('should return value rounded down', () => {
      //Arrange
      const expected = 3.34;
      const input = 3.3424;
      //Act
      const actual = twoDecimalPlaces(input);
      //Assert
      expect(actual).toBe(expected);
    });
  });
});
