const { Ship } = require('./OOPPiracy');

describe('Captain we see some ships!', () => {
  describe('an empty ship', () => {
    it('should not be worth it', () => {
      //Arrange
      const expected = false;
      const draftInput = 0;
      const crewInput = 0;
      const emptyShip = new Ship(draftInput, crewInput);
      //Act
      const actual = emptyShip.isWorthIt();
      //Assert
      expect(actual).toBe(expected);
    });
  });
  describe('a ship with 39.6 draft and 13 crew(19.5 draft)', () => {
    it('should be worth it', () => {
      //Arrange
      const expected = true;
      const draftInput = 39.6;
      const crewInput = 13;
      const emptyShip = new Ship(draftInput, crewInput);
      //Act
      const actual = emptyShip.isWorthIt();
      //Assert
      expect(actual).toBe(expected);
    });
  });
  describe('a ship with 39.5 draft and 13 crew(19.5 draft)', () => {
    it('should be not be worth it', () => {
      //Arrange
      const expected = false;
      const draftInput = 39.5;
      const crewInput = 13;
      const emptyShip = new Ship(draftInput, crewInput);
      //Act
      const actual = emptyShip.isWorthIt();
      //Assert
      expect(actual).toBe(expected);
    });
  });
});
