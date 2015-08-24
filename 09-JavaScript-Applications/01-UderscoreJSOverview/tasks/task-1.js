/*
Task-1
Create a function that:
  * Takes an array of students
    - Each student has a firstName and lastName properties
  * Finds all students whose firstName is before their lastName alphabetically
  * Then sorts them in descending order by fullName
    - fullName is the concatenation of firstName, ' ' (empty space) and lastName
  * Then prints them to the console
  * Use underscore.js for all operations
*/

function solve() {
  'use strict';

  function getStudentFullName(student) {
    return student.firstName + ' ' + student.lastName;
  }

  return function(students) {
    _.chain(students)
      .filter(function(student) {
        return student.firstName < student.lastName;
      })
      .sortBy(function(student) {
        return getStudentFullName(student);
      })
      .reverse()
      .each(function(student) {
        console.log(getStudentFullName(student));
      });
  };
}

module.exports = solve;