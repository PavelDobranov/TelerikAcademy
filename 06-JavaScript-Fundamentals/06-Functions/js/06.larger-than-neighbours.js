// Problem 6. Larger than neighbours
// Write a function that checks if the element at given position in given array of integers
// is bigger than its two neighbours (when such exist).

(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('.js-console'),
    solveButton = document.querySelector('.btn-solve'),
    clearButton = document.querySelector('.btn-clear');

  solveButton.addEventListener('click', solve);
  clearButton.addEventListener('click', clearForm);

  function solve() {
    try {
      var array = jsConsole.readIntArray('#array'),
        position = jsConsole.readInteger('#position'),
        result = isLargerThanNeighbours(array, position);

      jsConsole.writeLine('Is element at position ' + position + ' is larger than its two neighbours? : ' + result);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function isLargerThanNeighbours(array, position) {
    if (position === 0) {
      return array[position] > array[position + 1];
    } else if (position === array.length - 1) {
      return array[position] > array[position - 1];
    } else {
      return array[position] > array[position - 1] && array[position] > array[position + 1];
    }
  }

  function clearForm() {
    var inputElements = document.querySelectorAll('.input-container > input');

    for (var element = 0; element < inputElements.length; element += 1) {
      inputElements[element].value = '';
    }

    jsConsole.clear();
  }
}());