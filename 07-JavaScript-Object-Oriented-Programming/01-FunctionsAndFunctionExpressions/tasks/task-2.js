// Task Description
// Write a function that finds all the prime numbers in a range:
//   1) it should return the prime numbers in an array
//   2) it must throw an Error if any of the range params is not convertible to 'Number'
//   3) it must throw an Error if any of the range params is missing

function findPrimes(from, to) {
  var divisor,
    maxDivisor,
    num,
    isPrime,
    result = [];

  if (typeof from === 'undefined' || typeof to === 'undefined') {
    throw new Error('Any of the range params is missing!');
  }

  from = +from;
  to = +to;

  if (isNaN(from) || isNaN(to)) {
    throw new Error('Any of the range params is not convertible to Number!');
  }

  for (num = from; num <= to; num += 1) {
    isPrime = true;
    maxDivisor = Math.sqrt(num);

    for (divisor = 2; divisor <= maxDivisor; divisor += 1) {
      if (!(num % divisor)) {
        isPrime = false;
        break;
      }
    }

    if (isPrime && num > 1) {
      result.push(num);
    }
  }

  return result;
}

module.exports = findPrimes;