/*
Problem 7. First larger than neighbours
Write a function that returns the index of the first element in array that is larger than its neighbours or -1,
if there’s no such element.
Use the function from the previous exercise.
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
        result = firstLargerThanNeighbours(array);

      if (result >= 0) {
        jsConsole.writeLine('First element larger than its neighbours');
        jsConsole.writeLine('Position : ' + result);
      } else {
        jsConsole.writeLine('There’s no such element');
      }
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function firstLargerThanNeighbours(array) {
    for (var index = 0; index < array.length; index += 1) {
      if (isLargerThanNeighbours(array, index)) {
        return index;
      }
    }

    return -1;
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
    var inputElements = document.querySelectorAll('.input-container input');

    for (var element = 0; element < inputElements.length; element++) {
      inputElements[element].value = '';
    }

    jsConsole.clear();
  }
}());