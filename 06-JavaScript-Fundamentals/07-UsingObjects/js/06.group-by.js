/*
Problem 6. Larger than neighbours
Write a function that checks if the element at given position in given array of integers
is bigger than its two neighbours (when such exist).
*/

(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('.js-console'),
    solveButton = document.querySelector('.btn-solve'),
    clearButton = document.querySelector('.btn-clear');

  solveButton.addEventListener('click', solve);
  clearButton.addEventListener('click', clearForm);

  function solve() {
    var people = [{
        firstName: 'Georgi',
        lastName: 'Petrov',
        age: 31
      }, {
        firstName: 'Milena',
        lastName: 'Georgieva',
        age: 22
      }, {
        firstName: 'Stefan',
        lastName: 'Petrov',
        age: 22
      }, {
        firstName: 'Ivelina',
        lastName: 'Georgieva',
        age: 31
      }, {
        firstName: 'Milena',
        lastName: 'Atanasova',
        age: 25
      }, {
        firstName: 'Georgi',
        lastName: 'Kolev',
        age: 22
      }],
      property = jsConsole.readText('#property'),
      result = group(people, property);

    printResult(property, result);
  }

  function printResult(property, groupedArray) {
    var group,
      key,
      person;

    jsConsole.writeLine('Grouped by : ' + property);
    jsConsole.writeLine();

    for (key in groupedArray) {
      jsConsole.writeLine(key + ' :');

      group = groupedArray[key];

      for (person in group) {
        jsConsole.writeLine('- ' + JSON.stringify(group[person]));
      }
    }
  }

  function group(array, property) {
    var result = {},
      item,
      key;

    for (item in array) {
      if (!result.hasOwnProperty(array[item][property])) {
        key = array[item][property];

        result[array[item][property]] = array.filter(filterBy(property, key));
      }
    }

    return result;
  }

  function filterBy(prop, key) {
    return function(item) {
      return item[prop] === key;
    };
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