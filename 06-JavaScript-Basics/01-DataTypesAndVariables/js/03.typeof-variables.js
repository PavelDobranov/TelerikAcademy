// Problem 3. Typeof variables
// Try typeof on all variables you created.

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

    jsConsole.writeLine('typeof(' + intLiteral + ') => ' + typeof intLiteral);
    jsConsole.writeLine('typeof(' + floatLiteral + ') => ' + typeof floatLiteral);
    jsConsole.writeLine('typeof("' + strLiteral + '") => ' + typeof strLiteral);
    jsConsole.writeLine('typeof(' + boolLiteral + ') => ' + typeof boolLiteral);
    jsConsole.writeLine('typeof(' + JSON.stringify(arrLiteral) + ') => ' + typeof arrLiteral);
    jsConsole.writeLine('typeof(' + JSON.stringify(objLiteral) + ') => ' + typeof objLiteral);
    jsConsole.writeLine('typeof(' + funcLiteral + ') => ' + typeof funcLiteral);
  }

  function clearForm() {
    jsConsole.clear();
  }
}());