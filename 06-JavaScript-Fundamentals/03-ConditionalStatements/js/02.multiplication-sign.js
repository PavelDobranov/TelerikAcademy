// Problem 2. Multiplication Sign
// Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators.

(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('.js-console'),
    solveButton = document.querySelector('.btn-solve'),
    clearButton = document.querySelector('.btn-clear'),
    inputElements = document.querySelectorAll('.input-container input');

  solveButton.addEventListener('click', solve);
  clearButton.addEventListener('click', clearForm);

  function solve() {
    try {
      var numbers = [],
        element,
        len,
        number,
        result;

      for (element = 0, len = inputElements.length; element < len; element++) {
        number = jsConsole.readFloat(inputElements[element]);
        numbers.push(number);
      }

      result = getMultiplicationSign(numbers);

      jsConsole.writeLine('Result: ' + result);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function getMultiplicationSign(numbers) {
    var negativeNumbersCount = 0,
      number;

    for (number in numbers) {
      if (numbers[number] === 0) {
        return '0';
      }

      if (numbers[number] < 0) {
        negativeNumbersCount++;
      }
    }

    if (negativeNumbersCount % 2 === 0) {
      return '+';
    }

    return '-';
  }

  function clearForm() {
    var element,
      len;

    for (element = 0, len = inputElements.length; element < len; element++) {
      inputElements[element].value = '';
    }

    jsConsole.clear();
  }
}());