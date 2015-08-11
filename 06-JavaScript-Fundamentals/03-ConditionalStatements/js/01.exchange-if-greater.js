/*
Problem 1. Exchange if greater
Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
As a result print the values a and b, separated by a space.
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
      var firstNumber = jsConsole.readFloat('#first-number'),
        secondNumber = jsConsole.readFloat('#second-number');

      if (firstNumber > secondNumber) {
        firstNumber = firstNumber + secondNumber;
        secondNumber = firstNumber - secondNumber;
        firstNumber = firstNumber - secondNumber;
      }

      printNumbers(firstNumber, secondNumber);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function printNumbers(firstNumber, secondNumber) {
    jsConsole.writeLine('Result : ' + firstNumber + ' ' + secondNumber);
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