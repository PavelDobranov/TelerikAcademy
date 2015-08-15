/*
Problem 2. Correct brackets
Write a JavaScript function to check if in a given expression the brackets are put correctly.
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
      var expression = jsConsole.readText('#expression'),
        result = checkBrackets(expression);

      jsConsole.writeLine('Is correct ? : ' + result);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function checkBrackets(expression) {
    var openBracketChar = '(',
      closeBracketChar = ')',
      openBrackets = 0,
      ch,
      len;

    for (ch = 0, len = expression.length; ch < len; ch++) {
      if (expression[ch] === openBracketChar) {
        openBrackets += 1;
      }

      if (expression[ch] === closeBracketChar) {
        if (openBrackets === 0) {
          return false;
        }

        openBrackets -= 1;
      }
    }

    return openBrackets === 0;
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