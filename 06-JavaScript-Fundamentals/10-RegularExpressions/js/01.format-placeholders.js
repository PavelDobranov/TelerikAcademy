/*
Problem 1. Format with placeholders
Write a function that formats a string. The function should have placeholders, as shown in the example
Add the function to the String.prototype
*/

(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('.js-console'),
    solveButton = document.querySelector('.btn-solve'),
    clearButton = document.querySelector('.btn-clear');

  solveButton.addEventListener('click', solve);
  clearButton.addEventListener('click', clearForm);

  function solve() {
    var firstOption = {
        name: 'John'
      },
      secondOption = {
        name: 'John',
        age: 13
      },
      firtsString = 'Hello, there! Are you #{name}?',
      secondString = 'My name is #{name} and I am #{age}-years-old';

    jsConsole.writeLine('Example 1 output:');
    jsConsole.writeLine(firtsString.format(firstOption));
    jsConsole.writeLine('Example 2 output:');
    jsConsole.writeLine(secondString.format(secondOption));
  }

  if (!String.prototype.format) {
    String.prototype.format = function(options) {
      var pattern,
        result = this,
        prop;

      for (prop in options) {
        pattern = new RegExp('\#\{' + prop + '\}');
        result = result.replace(pattern, options[prop]);
      }

      return result;
    };
  }

  function clearForm() {
    jsConsole.clear();
  }
}());