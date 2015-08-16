/*
Problem 2. HTML binding
Write a function that puts the value of an object into the content/attributes of HTML tags.
Add the function to the String.prototype
*/

(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('.js-console'),
    solveButton = document.querySelector('.btn-solve'),
    clearButton = document.querySelector('.btn-clear');

  solveButton.addEventListener('click', solve);
  clearButton.addEventListener('click', clearForm);

  function solve() {
    var firstString = '<div data-bind-content="name"></div>',
      secondString = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></a>',
      firstResult = firstString.bind(firstString, {
        name: 'Steven'
      }),
      secondResult = secondString.bind(secondString, {
        name: 'Elena',
        link: 'http://telerikacademy.com'
      });

      jsConsole.writeLine(firstResult.htmlEscape());
      jsConsole.writeLine('Example 2 output:');
      jsConsole.writeLine(secondResult.htmlEscape());
  }

  if (!String.prototype.bind) {
    String.prototype.bind = function(str, obj) {
      var pattern = /<[A-z0-9"\s\-=\/]+>/g,
        patternName = /data-bind-content="name"/,
        patternLink = /data-bind-href="link"/,
        patternClass = /data-bind-class="name"/,
        result;

      if (patternName.test(this)) {
        result = this.match(pattern).join(obj.name);
      }

      if (patternLink.test(this)) {
        result = result.replace('>', ' href=' + '"' + obj.link + '">');
      }

      if (patternClass.test(this)) {
        result = result.replace('>', ' class=' + '"' + obj.name + '">');
      }

      return result;
    };
  }

  String.prototype.htmlEscape = function() {
    return this.replace(/</g, '&lt;').replace(/>/g, '&gt;');
  };

  function clearForm() {
    jsConsole.clear();
  }
}());