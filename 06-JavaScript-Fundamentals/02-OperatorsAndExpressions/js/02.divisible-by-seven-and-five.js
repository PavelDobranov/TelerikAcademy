/*
Problem 2. Divisible by 7 and 5
Write a boolean expression that checks for given integer if it can be divided (without remainder)
by 7 and 5 in the same time.
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
        firstDivider = 7,
        secondDivider = 5,
        result = isDivisible(number, firstDivider, secondDivider);

      jsConsole.writeLine('Result : ' + result);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function isDivisible(number, firstDivider, secondDivider) {
    return number % (firstDivider * secondDivider) === 0;
  }

  function clearForm() {
    var inputElements = document.querySelectorAll('.input-container > input'),
      element,
      len;

    for (element = 0, len = inputElements.length; element < len; element++) {
      inputElements[element].value = '';
    }

    jsConsole.clear();
  }
}());