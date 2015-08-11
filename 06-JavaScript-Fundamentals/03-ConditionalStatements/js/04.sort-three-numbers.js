// Problem 4. Sort 3 numbers
// Sort 3 real values in descending order.
// Use nested if statements.

(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('.js-console'),
    solveButton = document.querySelector('.btn-solve'),
    clearButton = document.querySelector('.btn-clear'),
    inputElements = document.querySelectorAll('.input-container > input');

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

      result = getSortedNumbers(numbers);

      jsConsole.writeLine('Result: ' + result.join(', '));

    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function getSortedNumbers(numbers) {
    if (numbers[0] > numbers[1] && numbers[0] > numbers[2]) {
      if (numbers[1] > numbers[2]) {
        return [numbers[0], numbers[1], numbers[2]];
      } else {
        return [numbers[0], numbers[2], numbers[1]];
      }
    } else if (numbers[1] > numbers[0] && numbers[1] > numbers[2]) {
      if (numbers[0] > numbers[2]) {
        return [numbers[1], numbers[0], numbers[2]];
      } else {
        return [numbers[1], numbers[2], numbers[0]];
      }
    } else if (numbers[2] > numbers[0] && numbers[2] > numbers[1]) {
      if (numbers[0] > numbers[1]) {
        return [numbers[2], numbers[0], numbers[1]];
      } else {
        return [numbers[2], numbers[1], numbers[0]];
      }
    } else {
      return numbers;
    }
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