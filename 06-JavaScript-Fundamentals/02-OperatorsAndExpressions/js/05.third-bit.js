// Problem 5. Third bit
// Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
// The bits are counted from right to left, starting from bit #0.
// The result of the expression should be either 1 or 0.

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
        position = 3,
        binaryRepresentarion = number.toString(2),
        bit = getBitValue(number, position);

      jsConsole.writeLine('Binary representation  : ' + binaryRepresentarion.padLeft('0', 16));
      jsConsole.writeLine('Bit #3 : ' + bit);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function getBitValue(number, position) {
    return ((1 << position) & number) >> position;
  }

  String.prototype.padLeft = function(symbol, count) {
    var str = this,
      c = symbol || ' ';

    while (this.length < count) {

    }

    return this;
  };

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
  var bitPosition = 3;

  if (isValidIntInput(input)) {
    var number = parseInt(input);
    var result = getBitValue(number, bitPosition);
    printResult(number, bitPosition, result);
  } else {
    printInvalidInput(input);
  }
}

function getBitValue(number, bitPosition) {
  var isZero = ((1 << bitPosition) & number) >> bitPosition == 0;

  return isZero ? 0 : 1;
}

function printResult(number, bitPosition, result) {
  jsConsole.writeLine('Bit ' + bitPosition + ' of ' + number + ' is : ' + result);
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