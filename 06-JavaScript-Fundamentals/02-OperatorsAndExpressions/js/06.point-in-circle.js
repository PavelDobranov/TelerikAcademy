/*
Problem 6. Point in Circle
Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5).
{0,0} is the centre and 5 is the radius.
*/

(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('.js-console'),
    solveButton = document.querySelector('.btn-solve'),
    clearButton = document.querySelector('.btn-clear');

  solveButton.addEventListener('click', solve);
  clearButton.addEventListener('click', clearForm);

  function solve() {
    try {
      var pointX = jsConsole.readFloat('#point-x'),
        pointY = jsConsole.readFloat('#point-y'),
        circle = {
          x: 0,
          y: 0,
          radius: 5
        },
        point = {
          x: pointX,
          y: pointY
        };

      var result = isInCircle(point, circle);

      jsConsole.writeLine('Is point P(' + point.x + ', ' + point.y + ') within a circle K({ ' + circle.x + ', ' + circle.y + '}, ' + circle.radius + ') ? : ' + result);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function isInCircle(point, circle) {
    var xDelta = point.x - circle.x,
      yDelta = point.y - circle.y;

    return (xDelta * xDelta) + (yDelta * yDelta) <= circle.radius * circle.radius;
  }

  function clearForm() {
    var inputElements = document.querySelectorAll('.input-container input'),
      element,
      len;

    for (element = 0, len = inputElements.length; element < len; element++) {
      inputElements[element].value = '';
    }

    jsConsole.clear();
  }
}());