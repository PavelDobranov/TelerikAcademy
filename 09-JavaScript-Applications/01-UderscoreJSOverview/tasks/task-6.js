/*
Task-6
Create a function that:
  * Takes a collection of books
    - Each book has propeties title and author
      - author is an object that has properties firstName and lastName
  * finds the most popular author (the author with biggest number of books)
  * prints the author to the console
    - if there is more than one author print them all sorted in ascending order by fullname
      - fullname is the concatenation of firstName, ' ' (empty space) and lastName
  * Use underscore.js for all operations
*/

function solve() {
  'use strict';

  return function(books) {
    var res = _.chain(books)
      .groupBy(function(book) {
        return book.author.firstName + ' ' + book.author.lastName;
      })
      .max(function(group) {
        return group.length;
      })
      .value();
  };
}

module.exports = solve;