/*
Problem 2. Lexicographically comparison
Write a script that compares two char arrays lexicographically (letter by letter).
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
      var firstString = jsConsole.readText('#first-str'),
        secondString = jsConsole.readText('#second-str'),
        firstStringLength,
        secondStringLength,
        result,
        letter;

      if (firstString !== '' && secondString !== '') {
        firstStringLength = firstString.length;
        secondStringLength = secondString.length;

        for (letter = 0; letter < Math.min(firstStringLength, secondStringLength); letter++) {
          if (firstString[letter] < secondString[letter]) {
            result = firstString + ' < ' + secondString;
            break;
          }
          if (firstString[letter] > secondString[letter]) {
            result = secondString + ' < ' + firstString;
            break;
          }
        }

        if (!result) {
          if (firstStringLength < secondStringLength) {
            result = firstString + ' < ' + secondString;
          } else if (firstStringLength > secondStringLength) {
            result = secondString + ' < ' + firstString;
          } else {
            result = firstString + ' = ' + secondString;
          }
        }

        jsConsole.writeLine(result);
      }
    } catch (e) {
      jsConsole.writeLine(e.message);
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