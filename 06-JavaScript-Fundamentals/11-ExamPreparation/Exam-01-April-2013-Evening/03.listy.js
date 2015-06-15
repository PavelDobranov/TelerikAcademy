function solve(params) {
  var lines = params.map(function (line, index) {
    if (index !== params.length - 1) {
      return line.substr(line.indexOf('def ') + 'def '.length).trim();
    } else {
      return line.trim();
    }
  });

  var scope = {};
  var parsedLines = parseLines(lines);
  var lastLine = parsedLines[parsedLines.length - 1];

  if (lastLine.name !== '') {
    console.log(calculateValue(lastLine.name, lastLine.sequence));
  } else {
    console.log(lastLine.sequence[0]);
  }

  function parseLines(lines) {
    var result = lines.map(function (line) {
      var splitedline = line.split('[');
      var nameAndOperator = getNameAndOperator(splitedline[0]);
      var sequence = getLineSequence(splitedline[1]);
      var value;

      if (nameAndOperator.operator) {
        value = calculateValue(nameAndOperator.operator, sequence);
      } else {
        value = sequence;
      }

      scope[nameAndOperator.name] = value;

      return {
        name: nameAndOperator.name,
        operator: nameAndOperator.operator,
        sequence: sequence,
        value: value
      };
    });

    return result;
  }

  function getNameAndOperator(input) {
    var trimmedInput = input.trim();
    var name;
    var operator;

    if (trimmedInput.indexOf(' ') > 0) {
      name = trimmedInput.substr(0, trimmedInput.indexOf(' '));
      operator = trimmedInput.substr(trimmedInput.lastIndexOf(' ') + 1);
    } else {
      name = trimmedInput;
    }

    return {
      name: name,
      operator: operator
    };
  }

  function getLineSequence(input) {
    var elements = input
      .substr(0, input.length - 1)
      .trim()
      .split(',');

    var newSequence = [];

    for (var element = 0; element < elements.length; element += 1) {
      var currElement = elements[element].trim();

      if (!isFinite(currElement)) {
        if (scope[currElement] instanceof Array) {
          Array.prototype.push.apply(newSequence, scope[currElement]);
        } else {
          newSequence.push(scope[currElement]);
        }
      } else {
        newSequence.push(Number(currElement));
      }
    }

    return newSequence;
  }

  function calculateValue(operator, sequence) {
    switch (operator) {
      case 'min':
        return sequence.reduce(function (p, v) {
          return (p < v ? p : v);
        });
      case 'max':
        return sequence.reduce(function (p, v) {
          return (p > v ? p : v);
        });
      case 'sum':
        return sequence.reduce(function (a, b) {
          return a + b;
        }, 0);
      case 'avg':
        var sum = sequence.reduce(function (a, b) {
          return a + b;
        }, 0);

        return Math.floor(sum / sequence.length);
    }
  }
}