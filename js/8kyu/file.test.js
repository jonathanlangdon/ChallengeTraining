const { billboard } = require('./file');

describe('Test Suite 1', () => {
  describe('Just characters', () => {
    it('should equal correct price', () => {
      //Arrange
      const expected = 600;
      const input = 'Jeong-Ho Aristotelis';
      //Act
      const actual = billboard(input);
      //Assert
      expect(actual).toBe(expected);
    });
  });
  describe('Name + custom price', () => {
    it('should equal correct price', () => {
      //Arrange
      const expected = 260;
      const input1 = 'Hadufuns John';
      const input2 = 20;
      //Act
      const actual = billboard(input1, input2);
      //Assert
      expect(actual).toBe(expected);
    });
  });
  describe('cannot include *', () => {
    it('should have no multiplier operator', () => {
      //Arrange
      const expected = NaN;
      //Act
      const actual = billboard('a', 'b');
      //Assert
      expect(actual).toBeTruthy();
    });
  });
});
