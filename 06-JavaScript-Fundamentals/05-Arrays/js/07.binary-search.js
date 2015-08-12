/*
Problem 7. Binary search
Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.
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
      var array = jsConsole.readLine('#array'),
        key = parseInt(keyInput, 10),
        minIndex,
        maxIndex,
        result;

      array.sort(function(a, b) {
        return a - b;
      });

      jsConsole.write('Sorted array : ');
      printArray(array);

      minIndex = 0;
      maxIndex = array.length - 1;
      result = binarySearch(array, key, minIndex, maxIndex);
      jsConsole.writeLine('Key index : ' + result);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function binarySearch(array, key, minIndex, maxIndex) {
    if (maxIndex < minIndex) {
      return -1;
    } else {
      var midIndex = minIndex + Math.floor((maxIndex - minIndex) / 2);

      if (array[midIndex] > key) {
        return binarySearch(array, key, minIndex, midIndex - 1);
      } else if (array[midIndex] < key) {
        return binarySearch(array, key, midIndex + 1, maxIndex);
      } else {
        return midIndex;
      }
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