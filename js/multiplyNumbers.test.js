// test for multiply function

const { multiply } = require('./multiplyNumbers');

describe('Test Suite 1', () => {
  describe('multiply 2 numbers', () => {
    it('should return correct product', () => {
      //Arrange
      const expected = 36;
      //Act
      const actual = multiply(9, 4);
      //Assert
      expect(actual).toBe(expected);
    });
  });
});
