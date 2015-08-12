/*
Problem 5. Selection sort
Sorting an array means to arrange its elements in increasing order.
Write a script to sort an array.
Use the selection sort algorithm: Find the smallest element, move it at the first position,
find the smallest from the rest, move it at the second position, etc.
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
      var array = jsConsole.readArray('#array');

      selectionSort(array);
      printArray(array);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function selectionSort(array) {
    var arrayLength = array.length,
      i,
      j;

    for (i = 0; i < arrayLength - 1; i++) {
      for (j = i + 1; j < arrayLength; j++) {
        if (array[i] > array[j]) {
          array[i] = array[j] + array[i];
          array[j] = array[i] - array[j];
          array[i] = array[i] - array[j];
        }
      }
    }
  }

  function printArray(array) {
    jsConsole.writeLine(array.join(', '));
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