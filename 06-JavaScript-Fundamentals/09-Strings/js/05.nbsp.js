/*
Problem 5. nbsp
Write a function that replaces non breaking white-spaces in a text with &nbsp;
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
      var text = jsConsole.readText('#text'),
        result = replaceWhiteSpaces(text);

      jsConsole.writeLine(result);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function replaceWhiteSpaces(text) {
    return text.split(' ').join('&amp;nbsp;');
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