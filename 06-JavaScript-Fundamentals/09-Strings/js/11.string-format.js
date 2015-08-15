/*
Problem 11. String format
Write a function that formats a string using placeholders.
The function should work with up to 30 placeholders and all types.
*/

(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('.js-console'),
    solveButton = document.querySelector('.btn-solve'),
    clearButton = document.querySelector('.btn-clear');

  solveButton.addEventListener('click', solve);
  clearButton.addEventListener('click', clearForm);

  function solve() {
    var format = '{0}, {1}, {0} text {2}',
      result = stringFormat(format, 1, 'Pesho', 'Gosho');

    jsConsole.writeLine(result);
  }

  function stringFormat() {
    var iParametersCount,
      result,
      regex,
      pattern,
      maxPlaceholders = 30,
      i;

    if (arguments.length === 1) {
      return arguments[0];
    } else if (arguments.length > maxPlaceholders + 1) {
      return 'The function works with up to 30 placeholders';
    } else {
      iParametersCount = arguments.length - 1;
      result = arguments[0];

      for (i = 0; i < iParametersCount; i++) {
        pattern = '\\{' + i + '\\}';
        regex = new RegExp(pattern, 'g');
        result = result.replace(regex, arguments[parseInt(i) + 1]);
      }

      return result;
    }
  }

  function clearForm() {
    jsConsole.clear();
  }
}());