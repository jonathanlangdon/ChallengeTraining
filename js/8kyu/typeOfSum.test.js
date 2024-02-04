// tests for return the type of the sum of two arguments

const { typeOfSum } = require('./typeOfSum');

describe('Test Suite 1', () => {
  it('should return "number" when both arguments are numbers', () => {
    expect(typeOfSum(12, 1)).toBe('number');
  });

  it('should return "string" when one argument is a string', () => {
    expect(typeOfSum('d', 1)).toBe('string');
    expect(typeOfSum(1, 'a')).toBe('string');
    expect(typeOfSum('dd', '')).toBe('string');
    expect(typeOfSum('s', false)).toBe('string');
    expect(typeOfSum('s', null)).toBe('string');
    expect(typeOfSum(undefined, 're')).toBe('string');
  });

  it('should return "number" when one argument is a boolean or null', () => {
    expect(typeOfSum(true, 1)).toBe('number');
    expect(typeOfSum(null, 1)).toBe('number');
    expect(typeOfSum(null, undefined)).toBe('number');
    expect(typeOfSum(undefined, true)).toBe('number');
    expect(typeOfSum(null, false)).toBe('number');
  });
});
