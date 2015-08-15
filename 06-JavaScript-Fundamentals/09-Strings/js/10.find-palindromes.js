/*
Problem 10. Find palindromes
Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
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
        result = findPalindromes(text);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function findPalindromes(text) {
    var words = text.split(/[\s.,;!?()]/),
      word,
      len,
      currentWord;

    for (word = 0, len = words.length; word < len; word++) {
      currentWord = words[word].trim();

      if (currentWord.length > 1 && isPalindrome(currentWord)) {
        jsConsole.writeLine(currentWord);
      }
    }
  }

  function isPalindrome(word) {
    var letter,
      len;

    for (letter = 1, len = word.length; letter <= len / 2; letter++) {
      if (word[letter - 1].toLowerCase() !== word[len - letter].toLowerCase()) {
        return false;
      }
    }

    return true;
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