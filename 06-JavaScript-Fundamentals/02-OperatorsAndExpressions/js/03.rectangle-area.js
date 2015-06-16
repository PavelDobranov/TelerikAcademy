// Problem 3. Rectangle area
// Write an expression that calculates rectangle’s area by given width and height.

(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('.js-console'),
    solveButton = document.querySelector('.btn-solve'),
    clearButton = document.querySelector('.btn-clear');

  solveButton.addEventListener('click', solve);
  clearButton.addEventListener('click', clearForm);

  function solve() {
    try {
      var width = jsConsole.readFloat('#width'),
        height = jsConsole.readFloat('#height');

      if (width < 0 || height < 0) {
        jsConsole.writeLine('Invalid input!');
      } else {
        jsConsole.writeLine('Area : ' + calculateArea(width, height));
      }
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function calculateArea(width, height) {
    return (width * height);
  }

  function clearForm() {
    var inputElements = document.querySelectorAll('.input-container > input'),
      element,
      len;

    for (element = 0, len = inputElements.length; element < len; element += 1) {
      inputElements[element].value = '';
    }

    jsConsole.clear();
  }
}());