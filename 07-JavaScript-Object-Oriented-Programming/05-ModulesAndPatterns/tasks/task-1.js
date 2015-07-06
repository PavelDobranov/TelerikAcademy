// Task Description
// Create a module for a Telerik Academy course:
//  1. The course has a title and presentations
//    * Each presentation also has a title
//    * There is a homework for each presentation
//  2. There is a set of students listed for the course
//    * Each student has firstname, lastname and an ID
//      - IDs must be unique integer numbers which are at least 1
//  3. Each student can submit a homework for each presentation in the course
//  4. Create method init()
//    * Accepts a string - course title
//    * Accepts an array of strings - presentation titles
//    * Throws if there is an invalid title
//      - Titles do not start or end with spaces
//      - Titles do not have consecutive spaces
//      - Titles have at least one character
//    * Throws if there are no presentations
//  5. Create method addStudent() which lists a student for the course
//    * Accepts a string in the format 'Firstname Lastname'
//    * Throws if any of the names are not valid
//      - Names start with an upper case letter
//      - All other symbols in the name (if any) are lowercase letters
//    * Generates a unique student ID and returns it
//  6. Create method getAllStudents() that returns an array of students in the format:
//    * { firstname: 'string', lastname: 'string', id: StudentID }
//  7. Create method submitHomework()
//    * Accepts studentID and homeworkID
//      - homeworkID 1 is for the first presentation
//      - homeworkID 2 is for the second one
//      - ...
//    * Throws if any of the IDs are invalid
//  8. Create method pushExamResults()
//    * Accepts an array of items in the format {StudentID: ..., score: ...}
//      - StudentIDs which are not listed get 0 points
//    * Throw if there is an invalid StudentID
//    * Throw if same StudentID is given more than once ( he tried to cheat (: )
//    * Throw if Score is not a number
//  9. Create method getTopStudents() which returns an array of the top 10 performing students
//    * Array must be sorted from best to worst
//    * If there are less than 10, return them all
//    * The final score that is used to calculate the top performing students is done as follows:
//      - 75% of the exam result
//      - 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course

function solve() {
  'use strict';

  if (!Array.prototype.find) {
    Array.prototype.find = function(predicate) {
      if (this === null) {
        throw new TypeError('Array.prototype.find called on null or undefined');
      }
      if (typeof predicate !== 'function') {
        throw new TypeError('predicate must be a function');
      }
      var list = Object(this);
      var length = list.length >>> 0;
      var thisArg = arguments[1];
      var value;

      for (var i = 0; i < length; i++) {
        value = list[i];
        if (predicate.call(thisArg, value, i, list)) {
          return value;
        }
      }
      return undefined;
    };
  }

  var Course = {
    init: function(title, presentations) {
      this.title = title;
      this.presentations = presentations;
      this._students = [];
      this._homeworks = [];
      this._examResults = [];

      return this;
    },
    addStudent: function(name) {
      var names = parseFullName(name);
      var student = {
        firstname: names.firstname,
        lastname: names.lastname,
        id: this._students.length + 1
      };

      this._students.push(student);

      return student.id;
    },
    getAllStudents: function() {
      return this._students;
    },
    submitHomework: function(studentID, homeworkID) {
      var isValidStudentID = this._students.some(function(student) {
        return student.id === studentID;
      });

      if (!isValidStudentID) {
        throw new Error('Invalid student ID!');
      }

      var isValidHomeworkID = homeworkID > 0 && homeworkID <= this._presentations.length;

      if (!isValidHomeworkID) {
        throw new Error('Invalid homework ID!');
      }

      this._homeworks.push({
        studentID: studentID,
        homeworkID: homeworkID
      });

      return this;
    },
    pushExamResults: function(results) {
      var self = this;

      if (results === null || !Array.isArray(results)) {
        throw new Error('Results must be an array!');
      }

      var invalidScore = results.some(function(result) {
        return isNaN(result.score);
      });

      if (invalidScore) {
        throw new Error('Results contains invalid score!');
      }

      var invalidStudentID = results.some(function(result) {
        return isNaN(result.StudentID) || result.StudentID <= 0 || result.StudentID > self._students.length;
      });

      if (invalidStudentID) {
        throw new Error('Results contains invalid studentID!');
      }

      results.sort(function(a, b) {
        return a.StudentID - b.StudentID;
      });

      for (var result = 1; result < results.length; result += 1) {
        if (results[result].StudentID === results[result - 1].StudentID) {
          throw new Error('StudentID: ' + results[result].StudentID + ' is given more than once!');
        }
      }

      this._examResults = results;

      return this;
    },
    getTopStudents: function() {
      var scoredStudents = this._students.map(function(student) {
        var submittedHomeworks = this._homeworks.filter(function(homework) {
          return homework.studentID === student.id;
        }).length;

        var homeworkScores = 0.25 * (submittedHomeworks / this.presentations.length);
        var examScores = 0;

        var examResult = this._examResults.find(function(result) {
          return result.StudentID === student.id;
        });

        if (!!examResult) {
          examScores = 0.75 * examResult.scores;
        }

        student.scores = homeworkScores + examScores;

        return student;
      });

      scoredStudents.sort(function(a, b) {
        return a.scores < b.scores;
      });

      return scoredStudents.filter(function(student) {
        return student.id <= 10;
      });
    }
  };

  Object.defineProperty(Course, 'title', {
    get: function() {
      return Course._title;
    },
    set: function(title) {
      validateTitle(title);
      Course._title = title;

      return Course;
    }
  });

  Object.defineProperty(Course, 'presentations', {
    get: function() {
      return Course._presentations.slice();
    },
    set: function(presentations) {
      if (!presentations.length) {
        throw new Error('Presentations array cannot be empty!');
      }

      Course._presentations = presentations.map(function(presentation) {
        validateTitle(presentation);
        return presentation;
      });

      return Course;
    }
  });

  return Course;

  function validateTitle(title) {
    if (title === '') {
      throw new Error('Title must contain at least one character!');
    }

    if (title.trim() !== title) {
      throw new Error('Title cannot start or end with spaces!');
    }

    if (title.indexOf('  ') > 0) {
      throw new Error('Title cannot contain consecutive spaces!');
    }
  }

  function parseFullName(fullname) {
    if (typeof fullname !== 'string') {
      throw new Error('Student name must be a string!');
    }

    var names = fullname.split(' ');

    if (names.length !== 2) {
      throw new Error('Student name must be in the format: "Firstname Lastname"!');
    }

    if (!startWithUppercaseLetter(names[0])) {
      throw new Error('First name must start with an upper case letter!');
    }

    if (!startWithUppercaseLetter(names[1])) {
      throw new Error('Last name must start with an upper case letter!');
    }

    return {
      firstname: names[0],
      lastname: names[1]
    };
  }

  function startWithUppercaseLetter(word) {
    return word[0].charCodeAt(0) >= 65 && word[0].charCodeAt(0) <= 90;
  }
}

module.exports = solve;