/*
Problem 4. Lexicographically smallest
Write a script that finds the lexicographically smallest and largest property in document,
window and navigator objects.
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
      var objectElements = document.getElementById('objects'),
        selectedElement = objectElements.options[objectElements.selectedIndex].value,
        selectedObject,
        smallest,
        largest;

      if (selectedElement === 'document') {
        selectedObject = document;
      } else if (selectedElement === 'window') {
        selectedObject = window;
      } else {
        selectedObject = navigator;
      }

      smallest = getLexicographicallySmallest(selectedObject);
      largest = getLexicographicallyLargest(selectedObject);

      printResult(selectedElement, smallest, largest);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function getLexicographicallySmallest(obj) {
    var smallest,
      property;

    for (property in obj) {
      if (!smallest || (property.toLowerCase() < smallest.toLowerCase())) {
        smallest = property;
      }
    }

    return smallest;
  }

  function getLexicographicallyLargest(obj) {
    var largest,
      property;

    for (property in obj) {
      if (!largest || (property.toLowerCase() > largest.toLowerCase())) {
        largest = property;
      }
    }

    return largest;
  }

  function printResult(selectedObject, smallest, largest) {
    jsConsole.writeLine('Lexicographically smallest property in ' + selectedObject + ' :');
    jsConsole.writeLine(smallest);
    jsConsole.writeLine('');
    jsConsole.writeLine('Lexicographically largest property in ' + selectedObject + ' :');
    jsConsole.writeLine(largest);
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