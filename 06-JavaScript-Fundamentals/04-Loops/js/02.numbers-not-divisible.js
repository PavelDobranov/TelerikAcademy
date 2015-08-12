/*
Problem 2. Numbers not divisible
Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time
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
        rangeStart = 1,
        firstDivider = 3,
        secondDivider = 7;

      while (true) {
        if (isNotDivisibleBy(rangeStart, firstDivider, secondDivider)) {
          jsConsole.writeLine(rangeStart);
        }

        if (rangeStart < number) {
          rangeStart++;
        } else if (rangeStart > number) {
          rangeStart--;
        } else {
          break;
        }
      }
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function isNotDivisibleBy(number, firstDivider, secondDivider) {
    return number % (firstDivider * secondDivider) !== 0;
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