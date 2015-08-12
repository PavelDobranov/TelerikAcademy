/*
Problem 1. Numbers
Write a script that prints all the numbers from 1 to N.
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
      var number = jsConsole.readInteger('#number'),
        rangeStart = 1;

      printNumbersInRange(rangeStart, number);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function printNumbersInRange(start, end) {
    while (true) {

      jsConsole.writeLine(start);

      if (start < end) {
        start++;
      } else if (start > end) {
        start--;
      } else {
        break;
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