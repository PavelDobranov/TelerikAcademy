/*
Problem 7. Parse URL
Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
Return the elements in a JSON object.
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
      var url = jsConsole.readText('#url'),
        result = paresUrl(url);

      jsConsole.writeLine(JSON.stringify(result));
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function paresUrl(url) {
    var urlObj = {},
      index = 0,
      length = url.indexOf(':');

    urlObj.protocol = url.substr(index, length);
    index = length + 3;
    length = url.indexOf('/', index) - index;
    urlObj.server = url.substr(index, length);

    index = url.lastIndexOf(urlObj.server) + urlObj.server.length;
    length = url.length - index;
    urlObj.resource = url.substr(index, length);

    return urlObj;
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