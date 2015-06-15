// Problem 2. Reverse number
// Write a function that reverses the digits of given decimal number.

(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('.js-console'),
    solveButton = document.querySelector('.btn-solve'),
    clearButton = document.querySelector('.btn-clear');

  solveButton.addEventListener('click', solve);
  clearButton.addEventListener('click', clearForm);

  function solve() {
    try {
      var number = jsConsole.readFloat('#number'),
        result = reverseNumber(number);

      jsConsole.writeLine('Result : ' + result);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function reverseNumber(number) {
    var isNegative = number < 0,
      numberAsString,
      reversedNumberAsString;

    if (isNegative) {
      number = number * -1;
    }

    numberAsString = number.toString();
    reversedNumberAsString = numberAsString.split('').reverse().join('');

    return isNegative ? parseFloat(reversedNumberAsString) * -1 : parseFloat(reversedNumberAsString);
  }

  function clearForm() {
    var inputElements = document.querySelectorAll('.input-container > input');

    for (var element = 0; element < inputElements.length; element += 1) {
      inputElements[element].value = '';
    }

    jsConsole.clear();
  }
}());