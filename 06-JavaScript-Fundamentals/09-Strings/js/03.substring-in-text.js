/*
Problem 3. Sub-string in text
Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
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
      var substring = jsConsole.readText('#substring'),
        text = jsConsole.readText('#text'),
        result = countSubstringInText(substring, text);

      jsConsole.writeLine('Result: ' + result);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function countSubstringInText(substring, text) {
    substring = substring.toLowerCase();
    text = text.toLowerCase();

    return (text.split(substring).length) - 1;
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