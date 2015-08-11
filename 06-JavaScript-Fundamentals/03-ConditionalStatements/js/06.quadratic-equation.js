/*
Problem 6. Quadratic equation
Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
Calculates and prints its real roots.
*/

(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('.js-console'),
    solveButton = document.querySelector('.btn-solve'),
    clearButton = document.querySelector('.btn-clear'),
    inputElements = document.querySelectorAll('.input-container input');

  solveButton.addEventListener('click', solve);
  clearButton.addEventListener('click', clearForm);

  function solve() {
    try {
      var coefficients = [],
        element,
        len,
        coefficient,
        result;

      for (element = 0, len = inputElements.length; element < len; element++) {
        coefficient = jsConsole.readFloat(inputElements[element]);
        coefficients.push(coefficient);
      }

      solveQuadraticEquation(coefficients);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function solveQuadraticEquation(coefficients) {
    var aCoefficient = coefficients[0],
      bCoefficient = coefficients[1],
      cCoefficient = coefficients[2],
      discriminant = (bCoefficient * bCoefficient) - (4 * aCoefficient * cCoefficient),
      root1,
      root2;

    if (discriminant > 0) {
      root1 = (-bCoefficient - Math.sqrt(discriminant)) / (2 * aCoefficient);
      root2 = (-bCoefficient + Math.sqrt(discriminant)) / (2 * aCoefficient);
      jsConsole.writeLine('x1 = ' + root1.toFixed(2) + ' ; ' + 'x2 = ' + root2.toFixed(2));
    } else if (discriminant < 0) {
      jsConsole.writeLine('no real roots');
    } else {
      root1 = -bCoefficient / (2 * aCoefficient);
      jsConsole.writeLine('x1 = x2 = ' + root1.toFixed(2));
    }
  }

  function clearForm() {
    var element,
      len;

    for (element = 0, len = inputElements.length; element < len; element++) {
      inputElements[element].value = '';
    }

    jsConsole.clear();
  }
}());