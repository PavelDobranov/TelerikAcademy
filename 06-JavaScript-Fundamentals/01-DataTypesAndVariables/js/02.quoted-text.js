// Problem 2. Quoted text
// Create a string variable with quoted text in it.
// For example: `'How you doin'?', Joey said'.

(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('.js-console'),
    solveButton = document.querySelector('.btn-solve'),
    clearButton = document.querySelector('.btn-clear');

  solveButton.addEventListener('click', solve);
  clearButton.addEventListener('click', clearForm);

  function solve() {
    var quotedText = "'How you doin'?', Pesho said.";

    jsConsole.writeLine(quotedText);
  }

  function clearForm() {
    jsConsole.clear();
  }
}());