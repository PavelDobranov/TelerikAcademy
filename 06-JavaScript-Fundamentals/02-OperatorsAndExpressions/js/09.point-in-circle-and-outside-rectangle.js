/*
Problem 9. Point in Circle and outside Rectangle
Write an expression that checks for given point P(x, y)
if it is within the circle K( (1,1), 3)
and out of the rectangle R(top=1, left=-1, width=6, height=2).
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
          x: 1,
          y: 1,
          radius: 3
        },
        rectangle = {
          top: 1,
          left: -1,
          width: 6,
          height: 2
        },
        point = {
          x: pointX,
          y: pointY
        },
        inCircle = isInCircle(point, circle),
        outOfRectangle = isOutOfRectangle(point, rectangle),
        result = inCircle && outOfRectangle;

      jsConsole.writeLine('Is in circle and outside rectangle ? : ' + result);
    } catch (e) {
      jsConsole.writeLine(e.message);
    }
  }

  function isInCircle(point, circle) {
    var xDelta = point.x - circle.x,
      yDelta = point.y - circle.y;

    return (xDelta * xDelta) + (yDelta * yDelta) <= circle.radius * circle.radius;
  }

  function isOutOfRectangle(point, rectangle) {
    var rectangleBottom = rectangle.top - rectangle.height,
      rectangleRight = rectangle.left + rectangle.width;

    return point.x < rectangle.left || point.x > rectangleRight || point.y > rectangle.top || point.y < rectangleBottom;
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