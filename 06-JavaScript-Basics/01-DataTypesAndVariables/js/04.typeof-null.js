// Problem 4. Typeof null
// Create null, undefined variables and try typeof on them.

(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('.js-console'),
    solveButton = document.querySelector('.btn-solve'),
    clearButton = document.querySelector('.btn-clear');

  solveButton.addEventListener('click', solve);
  clearButton.addEventListener('click', clearForm);

  function solve() {
    var nullVar = null,
      undefVar;

    jsConsole.writeLine('typeof(' + nullVar + ') => ' + typeof nullVar);
    jsConsole.writeLine('typeof(' + undefVar + ') => ' + typeof undefVar);
  }

  function clearForm() {
    jsConsole.clear();
  }
}());