/*
Problem 1. Odd or Even
Write an expression that checks if given integer is odd or even.
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
        result = isOddOrEven(number);

      jsConsole.writeLine('Result : ' + result);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function isOddOrEven(number) {
    return number % 2 === 0 ? 'even' : 'odd';
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