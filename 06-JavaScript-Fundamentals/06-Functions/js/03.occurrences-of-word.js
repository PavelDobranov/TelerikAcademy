/*
Problem 3. Occurrences of word
Write a function that finds all the occurrences of word in a text.
The search can be case sensitive or case insensitive.
Use function overloading.
*/

(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('.js-console'),
    solveButton = document.querySelector('.btn-solve'),
    clearButton = document.querySelector('.btn-clear');

  solveButton.addEventListener('click', solve);
  clearButton.addEventListener('click', clearForm);

  function solve() {
    try {
      var text = jsConsole.readText('#text'),
        word = jsConsole.readText('#word'),
        ignoreCase = document.getElementById('ignore-case').checked,
        result = countWordOccurrence(text, word, ignoreCase);

      jsConsole.writeLine('Result : ' + result);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function countWordOccurrence(text, word, ignoreCase) {
    var pattern = '\\b' + word + '\\b',
      flags = ignoreCase ? 'gi' : 'g',
      regExp = new RegExp(pattern, flags),
      wordsCollection = text.match(regExp);

    if (wordsCollection) {
      return wordsCollection.length;
    }

    return 0;
  }

  function clearForm() {
    var inputElements = document.querySelectorAll('.input-container input');

    for (var element = 0; element < inputElements.length; element++) {
      inputElements[element].value = '';
    }

    jsConsole.clear();
  }
}());