/*
Problem 12. Generate list
Write a function that creates a HTML <ul> using a template for every HTML <li>.
The source of the list should be an array of elements.
Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.
*/

(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('.js-console'),
    solveButton = document.querySelector('.btn-solve'),
    clearButton = document.querySelector('.btn-clear');

  solveButton.addEventListener('click', solve);
  clearButton.addEventListener('click', clearForm);

  function solve() {
    clearForm();

    var people = [{
        name: "Pesho",
        age: 14
      }, {
        name: "Ivan",
        age: 19
      }, {
        name: "Georgi",
        age: 34
      }, {
        name: "Stefan",
        age: 18
      }],
      divPeople = document.getElementById('list-item'),
      template = divPeople.innerHTML,
      peopleList = generateList(people, template);

    divPeople.innerHTML = peopleList;
    jsConsole.writeLine(peopleList.htmlEscape());
  }

  function generateList(collection, template) {
    var props = [],
      peopleList = [],
      liContent,
      prop,
      len,
      item;

    peopleList.push('<ul>');

    for (prop in collection[0]) {
      props.push(prop);
    }

    for (item = 0, len = collection.length; item < len; item++) {
      peopleList.push('<li>');
      liContent = template;

      for (prop in collection[0]) {
        liContent = liContent.replace(new RegExp('\\-{' + prop + '\\}-', 'g'), collection[item][prop]);
      }

      peopleList.push(liContent);
      peopleList.push('</li>');
    }

    peopleList.push('</ul>');

    return peopleList.join('');
  }

  String.prototype.htmlEscape = function() {
    return this.replace(/</g, '&lt;').replace(/>/g, '&gt;');
  };

  function clearForm() {
    document.getElementById('list-item').innerHTML = '<strong>-{name}-</strong> <span>-{age}-</span>';
    jsConsole.clear();
  }
}());