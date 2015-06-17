// Task Description
// Write a function that sums an array of numbers:
//   1) numbers must be always of type Number
//   2) it returns 'null' if the array is empty
//   3) it throws Error if the parameter is not passed (undefined)
//   4) it throws Error if any of the elements is not convertible to 'Number'

function sum(numbers) {
  'use strict';

  if (numbers.length === 0) {
    return null;
  }

  if (typeof numbers === 'undefined') {
    throw new Error('Numbers cannot be undefined!');
  }

  return numbers.reduce(function (a, b) {
    a = +a;
    b = +b;

    if (isNaN(a) || isNaN(b)) {
      throw new Error('Any of the elements is not convertible to Number!');
    }

    return a + b;
  }, 0);
}

module.exports = sum;