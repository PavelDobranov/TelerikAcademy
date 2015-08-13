/*
Problem 4. Has property
Write a function that checks if a given object contains a given property.
*/

(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('.js-console'),
    solveButton = document.querySelector('.btn-solve'),
    clearButton = document.querySelector('.btn-clear');

  solveButton.addEventListener('click', solve);
  clearButton.addEventListener('click', clearForm);

  function solve() {
    var obj = {
        firstName: 'Gosho',
        lastName: 'Petrov',
        age: 32
      },
      property;

    try {
      property = jsConsole.readText('#property');
    } catch (e) {
      jsConsole.writeLine(e.message);
    }

    jsConsole.writeLine('Result : ' + hasProperty(obj, property));
  }

  function hasProperty(obj, property) {
    return obj.hasOwnProperty(property);
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