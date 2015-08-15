/*
Problem 8. Replace tags
Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
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
        result = replaceAnchorTags(text);

      jsConsole.writeLine(result);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function replaceAnchorTags(text) {
    var openTagStart,
      urlQuoteEnd;

    while (text.indexOf('<a') !== -1) {
      openTagStart = text.indexOf('<a');
      text = text.replace('<a href="', '[URL=').replace('</a>', '[/URL]');
      urlQuoteEnd = text.indexOf('">', openTagStart);
      text = text.replaceAt(urlQuoteEnd, '\b]');
    }

    return text;
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

  String.prototype.replaceAt = function(index, character) {
    return this.substr(0, index) + character + this.substr(index + character.length);
  };

  String.prototype.htmlEscape = function() {
    return this.replace(/</g, '&lt;').replace(/>/g, '&gt;');
  };
}());