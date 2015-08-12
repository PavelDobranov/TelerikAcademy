/*
Problem 1. Increase array members
Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
Print the obtained array on the console.
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
      var arrayLength = 20,
        coefficient = 5,
        array = [],
        index;

      for (index = 0; index < arrayLength; index++) {
        array.push(index * coefficient);
      }

      printArray(array);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function printArray(array) {
    jsConsole.writeLine('Array: [' + array.join(', ') + ']');
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