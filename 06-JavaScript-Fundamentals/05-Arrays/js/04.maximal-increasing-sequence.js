/*
Problem 4. Maximal increasing sequence
Write a script that finds the maximal increasing sequence in an array.
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
        if (array[index] === array[index - 1] + 1) {
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

    for (count = maxLength - 1; count >= 0; count--) {
      jsConsole.write(maxElement - count);

      if (count > 0) {
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