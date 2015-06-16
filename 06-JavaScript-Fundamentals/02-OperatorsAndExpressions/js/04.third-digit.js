// Problem 4. Third digit
// Write an expression that checks for given integer if its third digit (right-to-left) is 7.

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

    for (element = 0, len = inputElements.length; element < len; element += 1) {
      inputElements[element].value = '';
    }

    jsConsole.clear();
  }
}());

function solve() {
  resetConsole();

  var input = document.getElementById('num').value;
  var checkValue = 7;

  if (isValidIntInput(input)) {
    var number = parseInt(input);
    var result = isThirdDigitSeven(number, checkValue);
    printResult(number, checkValue, result);
  } else {
    printInvalidInput(input);
  }
}

function isThirdDigitSeven(number, checkValue) {
  var thirdDigit = Math.floor((number % 1000) / 100);

  return thirdDigit === checkValue;
}

function printResult(number, checkValue, result) {
  jsConsole.writeLine('Third digit of ' + number + ' is ' + checkValue + ' ? : ' + result);
}

function isValidIntInput(input) {
  return !(isNaN(input) || input % 1 !== 0 || input === '');
}

function printInvalidInput(input) {
  if (input === '') {
    jsConsole.writeLine('Please fill the field');
  } else {
    jsConsole.writeLine('Invalid Input : ' + input);
    jsConsole.writeLine('Must be an integer');
  }
}

function resetConsole() {
  jsConsole.clear();
}