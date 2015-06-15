// Problem 1. JavaScript literals
// Assign all the possible JavaScript literals to different variables.

(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('.js-console'),
    solveButton = document.querySelector('.btn-solve'),
    clearButton = document.querySelector('.btn-clear');

  solveButton.addEventListener('click', solve);
  clearButton.addEventListener('click', clearForm);

  function solve() {
    var intLiteral = 7,
      floatLiteral = 3.7,
      strLiteral = 'Just another string',
      boolLiteral = true,
      arrLiteral = [2, 4, 5, 6, 3, 9],
      objLiteral = {
        name: 'John',
        age: 25
      },
      funcLiteral = function() {
        console.log('Hello world!');
      };

    jsConsole.writeLine('Integer : ' + intLiteral);
    jsConsole.writeLine('Floating number : ' + floatLiteral);
    jsConsole.writeLine('String : "' + strLiteral + '"');
    jsConsole.writeLine('Boolean : ' + boolLiteral);
    jsConsole.writeLine('Array : ' + JSON.stringify(arrLiteral));
    jsConsole.writeLine('Object : ' + JSON.stringify(objLiteral));
    jsConsole.writeLine('Function : ' + funcLiteral);
  }

  function clearForm() {
    jsConsole.clear();
  }
}());