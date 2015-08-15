/*
Problem 9. Extract e-mails
Write a function for extracting all email addresses from given text.
All sub-strings that match the format @… should be recognized as emails.
Return the emails as array of strings.
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
        result = extractEmailsFromText(text);

      jsConsole.writeLine(result);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function extractEmailsFromText(text) {
    var regex = new RegExp('\\b[A-Za-z0-9\\._-]+@[A-Za-z0-9\\._-]+\\.[A-Za-z0-9\\._-]+\\b', 'g');
    return text.match(regex);
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