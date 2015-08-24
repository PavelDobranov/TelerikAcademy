/*
Task-2
Create a function that:
  * Takes an array of students
    - Each student has a firstName, lastName and age properties
  * finds the students whose age is between 18 and 24
  * prints  the fullName of found students, sorted lexicographically ascending
    - fullName is the concatenation of firstName, ' ' (empty space) and lastName
  * Use underscore.js for all operations
*/

function solve() {
  'use strict';

  var CONSTS = {
    minValidAge: 18,
    maxValidAge: 24
  };

  function getStudentFullName(student) {
    return student.firstName + ' ' + student.lastName;
  }

  return function(students) {
    _.chain(students)
      .filter(function(student) {
        return CONSTS.minValidAge <= student.age && student.age <= CONSTS.maxValidAge;
      })
      .sortBy(function(student) {
        return getStudentFullName(student);
      })
      .each(function(student) {
        console.log(getStudentFullName(student));
      });
  };
}

module.exports = solve;