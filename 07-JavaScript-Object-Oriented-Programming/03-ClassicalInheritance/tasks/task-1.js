// Task Description
// Create a function constructor for Person. Each Person must have:
// 1) Properties 'firstname', 'lastname' and 'age'
//    * Firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
//    * Age must always be a number in the range 0 150
//      - The setter of age can receive a convertible-to-number value
//    * If any of the above is not met, throw Error
// 2) Property 'fullname'
//    * The getter returns a string in the format 'FIRST_NAME LAST_NAME'
//    * The setter receives a string is the format 'FIRST_NAME LAST_NAME'
//      - It must parse it and set 'firstname' and 'lastname'
// 3) Method 'introduce()' that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
// 4) All methods and properties must be attached to the prototype of the Person
// 5) All methods and property setters must return this, if they are not supposed to return other value
//    * Enables method-chaining

function solve() {
  'use strict';

  var Person = (function() {
    var CONSTS = {
      NAME_MIN_LENGTH: 3,
      NAME_MAX_LENGTH: 20,
      MIN_AGE: 0,
      MAX_AGE: 150
    };

    function Person(firstname, lastname, age) {
      this.firstname = firstname;
      this.lastname = lastname;
      this.age = age;
    }

    Object.defineProperty(Person.prototype, 'firstname', {
      get: function() {
        return this._firstname;
      },
      set: function(value) {
        validateName(value, 'First name');
        this._firstname = value;

        return this;
      }
    });

    Object.defineProperty(Person.prototype, 'lastname', {
      get: function() {
        return this._lastname;
      },
      set: function(value) {
        validateName(value, 'Last name');
        this._lastname = value;

        return this;
      }
    });

    Object.defineProperty(Person.prototype, 'age', {
      get: function() {
        return this._age;
      },
      set: function(value) {
        if (!isInRange(+value, CONSTS.MIN_AGE, CONSTS.MAX_AGE)) {
          throw new Error('age must always be a number in the range ' + CONSTS.MIN_AGE + ' - ' + CONSTS.MAX_AGE + '!');
        }

        this._age = +value;

        return this;
      }
    });

    Object.defineProperty(Person.prototype, 'fullname', {
      get: function() {
        return this.firstname + ' ' + this.lastname;
      },
      set: function(value) {
        this.firstname = value.substr(0, value.indexOf(' '));
        this.lastname = value.substr(value.indexOf(' ') + 1);

        return this;
      }
    });

    Person.prototype.introduce = function() {
      return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
    };

    function validateName(name, propName) {
      if (typeof name !== 'string') {
        throw new Error(propName + ' must be a string!');
      }

      if (!containOnlylatinLetters(name)) {
        throw new Error(propName + ' must contain only latin letters!');
      }

      if (!isInRange(name.length, CONSTS.NAME_MIN_LENGTH, CONSTS.NAME_MAX_LENGTH)) {
        throw new Error(propName + ' must be a string between ' + CONSTS.NAME_MIN_LENGTH + ' and ' + CONSTS.NAME_MAX_LENGTH + ' characters!');
      }
    }

    function containOnlylatinLetters(name) {
      return /^[a-zA-Z]*$/.test(name);
    }

    function isInRange(number, min, max) {
      return number >= min && number <= max;
    }

    return Person;
  }());

  return Person;
}

module.exports = solve;