/*
Problem 3. Maximal sequence
Write a script that finds the maximal sequence of equal elements in an array.
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
      var array = jsConsole.readArray('#array'),
        maxSequenceElement = array[0],
        maxSequenceLength = 1,
        currentSequenceLength = 1,
        index,
        len;

      for (index = 1, len = array.length; index < len; index++) {
        if (array[index] === array[index - 1]) {
          currentSequenceLength += 1;
        } else {
          currentSequenceLength = 1;
        }

        if (currentSequenceLength > maxSequenceLength) {
          maxSequenceLength = currentSequenceLength;
          maxSequenceElement = array[index];
        }
      }

      printResult(maxSequenceElement, maxSequenceLength);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function printResult(maxElement, maxLength) {
    var count;

    jsConsole.write('Result : ');

    for (count = 0; count < maxLength; count++) {
      jsConsole.write(maxElement);

      if (count !== maxLength - 1) {
        jsConsole.write(', ');
      }
    }

    jsConsole.writeLine('');
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