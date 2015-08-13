/*
Problem 4. Number of elements
Write a function to count the number of div elements on the web page
*/

(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('.js-console'),
    solveButton = document.querySelector('.btn-solve'),
    clearButton = document.querySelector('.btn-clear');

  solveButton.addEventListener('click', solve);
  clearButton.addEventListener('click', clearForm);

  function solve() {
    var divElements = document.querySelectorAll('div');

    jsConsole.writeLine('Result : ' + divElements.length);

    addHighlights(divElements);
  }

  function addHighlights(elements) {
    for (var element = 0; element < elements.length; element += 1) {
      elements[element].classList.add('highlited');
    }
  }

  function removeHighlights(elements) {
    for (var element = 0; element < elements.length; element += 1) {
      elements[element].classList.remove('highlited');
    }
  }

  function clearForm() {
    var inputElements = document.querySelectorAll('.input-container input'),
      divElements = document.querySelectorAll('div');

    for (var element = 0; element < inputElements.length; element++) {
      inputElements[element].value = '';
    }

    jsConsole.clear();
    removeHighlights(divElements);
  }
}());