(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('#js-console'),
    peopleContainer = document.getElementById("people"),
    peopleOfAgeButton = document.getElementById("btn-people-of-age"),
    underagePeopleButton = document.getElementById("btn-underage-people"),
    averagefemalesAgeButton = document.getElementById("btn-average-age-of-females"),
    youngestPersonButton = document.getElementById("btn-youngest-person"),
    groupPeopleButton = document.getElementById("btn-group-people"),
    people,
    buffer,
    paragraph;

  peopleOfAgeButton.addEventListener('click', peopleOfAge);
  underagePeopleButton.addEventListener('click', underagePeople);
  averagefemalesAgeButton.addEventListener('click', averageAgeOfFemales);
  youngestPersonButton.addEventListener('click', youngestPerson);
  groupPeopleButton.addEventListener('click', groupPeople);

  /* Problem 1. Make person
  Write a function for creating persons.
  Each person must have firstname, lastname, age and gender (true is female, false is male)
  Generate an array with ten person with different names, ages and genders */

  function Person(fname, lname, age, gender) {
    this.firstName = fname;
    this.lastName = lname;
    this.age = age;
    this.gender = gender ? 'female' : 'male';
  }

  Person.prototype.toString = function() {
    return this.firstName + ' ' + this.lastName + ', age: ' + this.age + ', gender: ' + this.gender;
  };

  people = [
    new Person('Atanas', 'Kolev', 24, false),
    new Person('Georgi', 'Ivanov', 26, false),
    new Person('Albena', 'Mihailova', 25, true),
    new Person('Mihaela', 'Dimitrova', 12, true),
    new Person('Ivan', 'Stefanov', 40, false),
    new Person('Stefan', 'Ganev', 14, false),
    new Person('Aneta', 'Yordanova', 29, true),
    new Person('Mihail', 'Simeonov', 16, false),
    new Person('Pavel', 'Georgiev', 56, false),
    new Person('Gergana', 'Stoyanova', 33, true)
  ];

  buffer = document.createDocumentFragment();
  paragraph = document.createElement('p');

  people.forEach(function(person) {
    paragraph.innerHTML = person.toString();
    buffer.appendChild(paragraph.cloneNode(true));
  });

  peopleContainer.appendChild(buffer);

  /* Problem 2. People of age
  Write a function that checks if an array of person contains only people of age (with age 18 or greater)
  Use only array methods and no regular loops (for, while) */

  function peopleOfAge() {
    var minValidAge = 18,
      result = people.filter(function(person) {
        return person.age >= minValidAge;
      });

    jsConsole.clear();
    jsConsole.writeLine('Persons with age ' + minValidAge + ' or greater: ');
    printPeople(result);
  }

  /* Problem 3. Underage people
  Write a function that prints all underaged persons of an array of person
  Use Array#filter and Array#forEach
  Use only array methods and no regular loops (for, while) */

  function underagePeople() {
    var maxValidAge = 17,
      result = people.filter(function(person) {
        return person.age <= maxValidAge;
      });

    jsConsole.clear();
    jsConsole.writeLine('Underaged persons:');
    printPeople(result);
  }

  /*
  Problem 4. Average age of females
  Write a function that calculates the average age of all females, extracted from an array of persons
  Use Array#filter
  Use only array methods and no regular loops (for, while)
  */

  function averageAgeOfFemales() {
    var females = people.filter(function(person) {
        return person.gender === 'female';
      }),
      result = 0;

    females.forEach(function(female) {
      result += female.age / females.length;
    });

    jsConsole.clear();
    jsConsole.writeLine('Average age of all females: ' + result);
  }

  /* Problem 5. Youngest person
  Write a function that finds the youngest male person in a given array of people and prints his full name
  Use only array methods and no regular loops (for, while)
  Use Array#find */

  function youngestPerson() {
    var result = people
      .sort(function(a, b) {
        return a.age - b.age;
      }).find(function(person) {
        return person.gender === 'male';
      });

    jsConsole.clear();
    jsConsole.writeLine('Youngest male person:');
    jsConsole.writeLine(' - ' + result);
  }

  /* Problem 6. Group people
  Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
  Use Array#reduce
  Use only array methods and no regular loops (for, while) */

  function groupPeople() {
    var groups,
      group;

    groups = people.reduce(function(group, person) {
      var letter = person.firstName[0];

      if (group[letter]) {
        group[letter].push(person);
      } else {
        group[letter] = [person];
      }

      return group;
    }, {});

    jsConsole.clear();

    for (group in groups) {
      jsConsole.writeLine('[ ' + group + ' ] :');
      printPeople(groups[group]);
    }
  }

  /* Helper function */

  function printPeople(people) {
    people.forEach(function(person) {
      jsConsole.writeLine(' - ' + person);
    });
  }
}());