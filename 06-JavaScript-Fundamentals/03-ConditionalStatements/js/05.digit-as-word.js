// Problem 5. Digit as word
// Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
// Print "not a digit" in case of invalid input.
// Use a switch statement.

(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('.js-console'),
    solveButton = document.querySelector('.btn-solve'),
    clearButton = document.querySelector('.btn-clear');

  solveButton.addEventListener('click', solve);
  clearButton.addEventListener('click', clearForm);

  function solve() {
    try {
      var digit = jsConsole.readText('#digit'),
        result = getDigitAsWord(digit);

      jsConsole.writeLine('Result: ' + result);

    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function getDigitAsWord(digit) {
    switch (digit) {
      case '0': return 'zero';
      case '1': return 'one';
      case '2': return 'two';
      case '3': return 'three';
      case '4': return 'four';
      case '5': return 'five';
      case '6': return 'six';
      case '7': return 'seven';
      case '8': return 'eight';
      case '9': return 'nine';
      default: return 'not a digit';
    }
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