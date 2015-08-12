/*
Problem 3. Min/Max of sequence
Write a script that finds the max and min number from a sequence of numbers.
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
      var numbers = jsConsole.readArray('#numbers'),
        minNumber = getMinNumberFromArray(numbers),
        maxNumber = getMaxNumberFromArray(numbers);

      jsConsole.writeLine('Min number: ' + minNumber);
      jsConsole.writeLine('Max number: ' + maxNumber);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function getMinNumberFromArray(numbers) {
    var min;

    numbers.forEach(function(number) {
      if (!min || number < min) {
        min = number;
      }
    });

    return min;
  }

  function getMaxNumberFromArray(numbers) {
    var max;

    numbers.forEach(function(number) {
      if (!max || number > max) {
        max = number;
      }
    });

    return max;
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