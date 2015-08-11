/*
Problem 7. Is prime
Write an expression that checks if given positive integer number n (n ≤ 100) is prime.
*/

(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('.js-console'),
    solveButton = document.querySelector('.btn-solve'),
    clearButton = document.querySelector('.btn-clear');

  solveButton.addEventListener('click', solve);
  clearButton.addEventListener('click', clearForm);

  function solve() {
    try {
      var number = jsConsole.readInteger('#number'),
        minValidNumber = 1,
        maxValidNumber = 100,
        result;

      if (minValidNumber < number || number > maxValidNumber) {
        throw new Error('Number must be in range [' + minValidNumber + ' - ' + maxValidNumber + ']');
      }

      result = isPrime(number);

      jsConsole.writeLine('Is prime ? : ' + result);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function isPrime(number) {
    var start = 2;

    while (start <= Math.sqrt(number)) {
      if (number % start++ < 1) {
        return false;
      }
    }

    return number > 1;
  }

  function clearForm() {
    var inputElements = document.querySelectorAll('.input-container input'),
      element,
      len;

    for (element = 0, len = inputElements.length; element < len; element++) {
      inputElements[element].value = '';
    }

    jsConsole.clear();
  }
}());