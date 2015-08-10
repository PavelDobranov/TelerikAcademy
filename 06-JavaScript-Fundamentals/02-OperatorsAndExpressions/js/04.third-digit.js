/*
Problem 4. Third digit
Write an expression that checks for given integer if its third digit (right-to-left) is 7.
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
        value = 7,
        result = checkThirdDigit(number, value);

      jsConsole.writeLine('Third digit(right-to-left) of ' + number + ' is ' + value + ' ? : ' + result);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function checkThirdDigit(number, value) {
    return Math.floor((number % 1000) / 100) === value;
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