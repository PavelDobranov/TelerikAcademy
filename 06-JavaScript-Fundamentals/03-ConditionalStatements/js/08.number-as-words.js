// Problem 8. Number as words
// Write a script that converts a number in the range [0 - 999] to words, corresponding to its English pronunciation.

(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('.js-console'),
    solveButton = document.querySelector('.btn-solve'),
    clearButton = document.querySelector('.btn-clear'),
    ones = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine', 'ten', 'eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen'],
    tens = ['#', '#', 'twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety'];

  solveButton.addEventListener('click', solve);
  clearButton.addEventListener('click', clearForm);

  function solve() {
    try {
      var number = jsConsole.readInteger('#number'),
        minValidNumber = 0,
        maxValidNumber = 999;

      if (number < minValidNumber || number > maxValidNumber) {
        jsConsole.writeLine('Please enter number in the range [' + minValidNumber + ' - ' + maxValidNumber + ']!');
        return;
      }

      if (number >= 0 && number <= 19) {
        jsConsole.writeLine(getOnes(number));
      }

      if (number >= 20 && number <= 99) {
        jsConsole.writeLine(getTnes(number));
      }

      if (number >= 100 && number < 1000) {
        jsConsole.writeLine(getHundreds(number));
      }
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function getOnes(num) {
    return ones[num];
  }

  function getTnes(num) {
    var firstDigit = Math.floor(num / 10);
    var secondDigit = num % 10;

    if (secondDigit === 0) {
      return tens[firstDigit];
    } else {
      return tens[firstDigit] + ' ' + ones[secondDigit];
    }
  }

  function getHundreds(num) {
    var firstDigit = Math.floor(num / 100);
    var tensDigits = num % 100;

    if (tensDigits === 0) {
      return ones[firstDigit] + ' hundred';
    } else if (tensDigits < 20) {
      return ones[firstDigit] + ' hundred and ' + getOnes(tensDigits);
    } else {
      return ones[firstDigit] + ' hundred and ' + getTnes(tensDigits);
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