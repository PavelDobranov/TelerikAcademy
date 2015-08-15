/*
Problem 1. Reverse string
Write a JavaScript function that reverses a string and returns it.
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
      var str = jsConsole.readText('#string'),
        result = reverseString(str);

      jsConsole.writeLine('Result : ' + result);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function reverseString(str) {
    var result = '',
      ch,
      len;

    for (ch = 0, len = str.length; ch < len; ch++) {
      result = str[ch] + result;
    }

    return result;
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