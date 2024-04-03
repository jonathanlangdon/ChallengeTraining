// Test suite for define suit

const { defineSuit } = require('./defineSuit');

describe('Test Suite 1', () => {
  describe('input with clubs', () => {
    it('should return clubs', () => {
      //Arrange
      const expected = 'clubs';
      const input = '3♣';
      //Act
      const actual = defineSuit(input);
      //Assert
      expect(actual).toBe(expected);
    });
  });
  describe('input with diamonds', () => {
    it('should return diamonds', () => {
      //Arrange
      const expected = 'diamonds';
      const input = '3♦';
      //Act
      const actual = defineSuit(input);
      //Assert
      expect(actual).toBe(expected);
    });
  });
  describe('input with hearts', () => {
    it('should return hearts', () => {
      //Arrange
      const expected = 'hearts';
      const input = '3♥';
      //Act
      const actual = defineSuit(input);
      //Assert
      expect(actual).toBe(expected);
    });
  });
  describe('input with spades', () => {
    it('should return spades', () => {
      //Arrange
      const expected = 'spades';
      const input = '3♠';
      //Act
      const actual = defineSuit(input);
      //Assert
      expect(actual).toBe(expected);
    });
  });
});
