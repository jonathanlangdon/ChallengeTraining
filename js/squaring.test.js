// test function for squaring

import { it, expect } from 'vitest';
import { square } from './squaring';

it('should return the square of a number', () => {
  const result = square(2);
  expect(result).toBe(4);
});

it('should return the square of a number', () => {
  const result = square(3);
  expect(result).toBe(9);
});
