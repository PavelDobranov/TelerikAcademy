/*
Problem 3. The biggest of Three
Write a script that finds the biggest of three numbers.
Use nested if statements.
*/

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

      result = getBiggestNumber(numbers);

      jsConsole.writeLine('Result: ' + result);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function getBiggestNumber(numbers) {
    var biggest;

    numbers.forEach(function(number) {
      if (!biggest || number > biggest) {
        biggest = number;
      }
    });

    return biggest;
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