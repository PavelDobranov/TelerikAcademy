/* globals describe, it */

var Person = require('../tasks/task-1')(),
  expect = require('chai').expect;

describe('Tests for Classical Inheritance in JavaScript', function() {
  describe('"Task 1"', function() {
    var CONSTS = {
      VALID: {
        FIRSTNAME: 'Firsttest',
        LASTNAME: 'Lasttest',
        FULLNAME: 'full test',
        AGE: 5
      },
      INVALID: {
        FIRSTNAME: {
          SHORT: 'Ff',
          LONG: 'F' + (new Array(21).join('f'))
        },
        LASTNAME: {
          SHORT: 'Ll',
          LONG: 'L' + (new Array(21).join('l'))
        },
        AGE: {
          SMALLER: -1,
          LARGER: 151
        }
      }
    };

    it('expect Person function constructor to exist', function() {
      expect(Person).to.exist;
    });

    it('expect Person to be a function', function() {
      expect(Person).to.be.a('function');
    });

    it('expect new Person object with valid firstname, lastname and age to set them', function() {
      var person = new Person(CONSTS.VALID.FIRSTNAME, CONSTS.VALID.LASTNAME, CONSTS.VALID.AGE);

      expect(person.firstname).to.equal(CONSTS.VALID.FIRSTNAME);
      expect(person.lastname).to.equal(CONSTS.VALID.LASTNAME);
      expect(person.age).to.equal(CONSTS.VALID.AGE);
    });

    it('expect new Person object with valid firstname, lastname to set them have fullname', function() {
      var person = new Person(CONSTS.VALID.FIRSTNAME, CONSTS.VALID.LASTNAME, CONSTS.VALID.AGE);

      expect(person.firstname).to.equal(CONSTS.VALID.FIRSTNAME);
      expect(person.lastname).to.equal(CONSTS.VALID.LASTNAME);
      expect(person.fullname).to.equal(CONSTS.VALID.FIRSTNAME + ' ' + CONSTS.VALID.LASTNAME);
    });

    it('expect new Person with short fistname to throw error', function() {
      function test() {
        new Person(CONSTS.INVALID.FIRSTNAME.SHORT, CONSTS.VALID.LASTNAME, CONSTS.VALID.AGE);
      }

      expect(test).to.throw();
    });

    it('expect new Person with long fistname to throw error', function() {
      function test() {
        new Person(CONSTS.INVALID.FIRSTNAME.LONG, CONSTS.VALID.LASTNAME, CONSTS.VALID.AGE);
      }

      expect(test).to.throw();
    });

    it('expect new Person with short lastname to throw error', function() {
      function test() {
        new Person(CONSTS.VALID.FIRSTNAME, CONSTS.INVALID.LASTNAME.SHORT, CONSTS.VALID.AGE);
      }

      expect(test).to.throw();
    });

    it('expect new Person with long lastname to throw error', function() {
      function test() {
        new Person(CONSTS.VALID.FIRSTNAME, CONSTS.INVALID.LASTNAME.LONG, CONSTS.VALID.AGE);
      }

      expect(test).to.throw();
    });

    it('expect new Person with age ' + CONSTS.INVALID.AGE.SMALLER + ' to throw error', function() {
      function test() {
        new Person(CONSTS.VALID.FIRSTNAME, CONSTS.VALID.LASTNAME, CONSTS.INVALID.AGE.SMALLER);
      }

      expect(test).to.throw();
    });

    it('expect new Person with age ' + CONSTS.INVALID.AGE.LARGER + ' to throw error', function() {
      function test() {
        new Person(CONSTS.VALID.FIRSTNAME, CONSTS.VALID.LASTNAME, CONSTS.INVALID.AGE.LARGER);
      }

      expect(test).to.throw();
    });

    it('expect person, with valid firstname, lastname and age, to return correct introduce', function() {
      var expected = 'Hello! My name is ' + CONSTS.VALID.FIRSTNAME + ' ' + CONSTS.VALID.LASTNAME + ' and I am ' + CONSTS.VALID.AGE + '-years-old',
        actual = (new Person(CONSTS.VALID.FIRSTNAME, CONSTS.VALID.LASTNAME, CONSTS.VALID.AGE)).introduce();

      expect(actual).to.equal(expected);
    });

    it('expect introduce to be attached to prototype', function() {
      expect(Person.prototype).to.has.property('introduce');
    });

    it('expect introduce to be attached to prototype', function() {
      expect(Person.prototype).to.has.property('introduce');
    });

    it('expect fullname setter to set firstname and lastname', function() {
      var person = new Person(CONSTS.VALID.FIRSTNAME, CONSTS.VALID.LASTNAME, CONSTS.VALID.AGE),
        old = { firstname: person.firstname, lastname: person.lastname };

      person.fullname = person.fullname + 'z';

      expect(person.firstname).to.equal(old.firstname);
      expect(person.lastname).to.equal(old.lastname + 'z');
    });
  });
});