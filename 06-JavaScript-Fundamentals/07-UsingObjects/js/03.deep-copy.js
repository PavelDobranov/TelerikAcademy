// Problem 3. Deep copy
// Write a function that makes a deep copy of an object.
// The function should work for both primitive and reference types.

(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('.js-console'),
    solveButton = document.querySelector('.btn-solve'),
    clearButton = document.querySelector('.btn-clear');

  solveButton.addEventListener('click', solve);
  clearButton.addEventListener('click', clearForm);

  function solve() {
    var pesho = {
        firstName: 'Pesho',
        lastName: 'Ivanov',
        marks: [3, 6, 6, 5],
        contact: {
          email: 'pesho.ivanov@gmail.com',
          tel: '123456789'
        }
      },
      clonedPesho = clone(pesho);

    jsConsole.write('Pesho : ');
    printObject(pesho);
    jsConsole.writeLine();

    jsConsole.write('Cloned Pesho : ');
    printObject(clonedPesho);
    jsConsole.writeLine();

    clonedPesho.lastName = 'Simeonov';
    clonedPesho.marks.push(2);
    clonedPesho.contact.email = 'pesho.simeonov@gmail.com';
    clonedPesho.contact.tel = '987654321';

    jsConsole.writeLine('----------------------------------------------------');
    jsConsole.writeLine('After changing the properties of the cloned object :');
    jsConsole.writeLine('----------------------------------------------------');
    jsConsole.writeLine();

    jsConsole.write('Pesho : ');
    printObject(pesho);
    jsConsole.writeLine();

    jsConsole.write('Cloned Pesho : ');
    printObject(clonedPesho);
    jsConsole.writeLine();
  }

  function clone(obj) {
    if (obj === null || typeof obj !== 'object') {
      return obj;
    }

    var cloned = obj.constructor();

    for (var prop in obj) {
      cloned[prop] = clone(obj[prop]);
    }

    return cloned;
  }

  function printObject(obj) {
    jsConsole.writeLine(JSON.stringify(obj));
  }

  function clearForm() {
    var inputElements = document.querySelectorAll('.input-container > input');

    for (var element = 0; element < inputElements.length; element += 1) {
      inputElements[element].value = '';
    }

    jsConsole.clear();
  }
}());
