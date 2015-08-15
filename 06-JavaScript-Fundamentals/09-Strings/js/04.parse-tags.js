/*
You are given a text. Write a function that changes the text in all regions:
  - <upcase>text</upcase> to uppercase.
  - <lowcase>text</lowcase> to lowercase
  - <mixcase>text</mixcase> to mix casing(random)
Regions can be nested
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
        result = parseTags(text);

      jsConsole.writeLine(result);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function parseTags(text) {
    var tagNames = ['mixcase', 'upcase', 'lowcase'],
      result = text,
      tag,
      tagNamesLength,
      openTag,
      closeTag,
      splitedByOpenTag,
      i,
      splitedLength,
      splitedByCloseTag;

    for (tag = 0, tagNamesLength = tagNames.length; tag < tagNamesLength; tag++) {
      openTag = '<' + tagNames[tag] + '>';
      closeTag = '</' + tagNames[tag] + '>';
      splitedByOpenTag = result.split(openTag);

      for (i = 0, splitedLength = splitedByOpenTag.length; i < splitedLength; i++) {
        if (splitedByOpenTag[i].indexOf(closeTag) >= 0) {
          splitedByCloseTag = splitedByOpenTag[i].split(closeTag);

          switch (tagNames[tag]) {
            case 'mixcase':
              splitedByCloseTag[0] = toMixCase(splitedByCloseTag[0]);
              break;
            case 'upcase':
              splitedByCloseTag[0] = splitedByCloseTag[0].toUpperCase();
              break;
            case 'lowcase':
              splitedByCloseTag[0] = splitedByCloseTag[0].toLowerCase();
              break;
          }

          splitedByOpenTag[i] = splitedByCloseTag.join('');
        }
      }

      result = splitedByOpenTag.join('');
    }

    return result;
  }

  function toMixCase(text) {
    var result = '',
      letter,
      len,
      random;

    for (letter = 0, len = text.length; letter < len; letter++) {
      random = parseInt(Math.random() * 2);

      if (random === 0) {
        result += text[letter].toUpperCase();
      } else {
        result += text[letter].toLowerCase();
      }
    }

    return result;
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