/*
Problem 8. Trapezoid area
Write an expression that calculates trapezoid's area by given sides a and b and height h.
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
      var sideA = jsConsole.readFloat('#side-a'),
        sideB = jsConsole.readFloat('#side-b'),
        height = jsConsole.readFloat('#height-h'),
        area = calculateTrapezoidArea(sideA, sideB, height);

      jsConsole.writeLine('Trapezoid area: ' + area.toFixed(3));
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function calculateTrapezoidArea(sideA, sideB, height) {
    return (height * (sideA + sideB)) / 2;
  }

  function clearForm() {
    var inputElements = document.querySelectorAll('.input-container > input'),
      element,
      len;

    for (element = 0, len = inputElements.length; element < len; element++) {
      inputElements[element].value = '';
    }

    jsConsole.clear();
  }
}());