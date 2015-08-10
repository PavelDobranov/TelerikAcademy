/*
Problem 5. Third bit
Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.
*/

(function() {
  'use strict';

  String.prototype.padLeft = function(character, count) {
    var paddingChar = character || ' ';

    if (count <= this.length) {
      return this;
    }

    return new Array(count - (this.length - 1)).join(paddingChar) + this;
  };

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