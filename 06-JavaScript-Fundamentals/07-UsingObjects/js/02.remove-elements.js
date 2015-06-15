// Problem 2. Reverse number
// Write a function that reverses the digits of given decimal number.

(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('.js-console'),
    solveButton = document.querySelector('.btn-solve'),
    clearButton = document.querySelector('.btn-clear');

  solveButton.addEventListener('click', solve);
  clearButton.addEventListener('click', clearForm);

  function solve() {
    var array = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'],
      element;

    try {
      element = jsConsole.readText('#element');
    } catch (e) {
      jsConsole.writeLine(e.message);
    }

    if (isNaN(element)) {
      array.remove(element.replace(/'|"/g, ''));
    } else {
      array.remove(+element);
    }

    jsConsole.writeLine('Result : ' + JSON.stringify(array));
  }

  Array.prototype.remove = function(element) {
    while (this.indexOf(element) >= 0) {
      this.splice(this.indexOf(element), 1);
    }

    return this;
  };

  function clearForm() {
    var inputElements = document.querySelectorAll('.input-container > input');

    for (var element = 0; element < inputElements.length; element += 1) {
      inputElements[element].value = '';
    }

    jsConsole.clear();
  }
}());
