/*
Problem 6. Extract text from HTML
Write a function that extracts the content of a html page given as text.
The function should return anything that is in a tag, without the tags.
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
        result = extractContentFromHtml(text);

      jsConsole.writeLine(result);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function extractContentFromHtml(text) {
    var resultCollection = text.match(new RegExp('>(.*?)<', 'g')),
      content,
      len,
      result = '';

    for (content = 0, len = resultCollection.length; content < len; content++) {
      if (resultCollection[content].length > 2) {
        result += resultCollection[content].replace('>', '').replace('<', ' ');
      }
    }

    return result.trim();
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