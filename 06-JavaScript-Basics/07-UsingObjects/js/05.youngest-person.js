// Problem 5. Youngest person
// Write a function that finds the youngest person in a given array of people and prints his/hers full name
// Each person has properties firstname, lastname and age.

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
        age: 32
      }, {
        firstName: 'Milena',
        lastName: 'Georgieva',
        age: 22
      }, {
        firstName: 'Stefan',
        lastName: 'Petrov',
        age: 25
      }, {
        firstName: 'Ivelina',
        lastName: 'Koleva',
        age: 28
      }],
      result = findYoungest(people);

    jsConsole.writeLine('Youngest : ' + JSON.stringify(result));
  }

  function findYoungest(people) {
    var youngest = people[0];

    for (var index = 1; index < people.length; index += 1) {
      if (people[index].age < youngest.age) {
        youngest = people[index];
      }
    }

    return youngest;
  }

  function clearForm() {
    var inputElements = document.querySelectorAll('.input-container > input');

    for (var element = 0; element < inputElements.length; element += 1) {
      inputElements[element].value = '';
    }

    jsConsole.clear();
  }
}());
