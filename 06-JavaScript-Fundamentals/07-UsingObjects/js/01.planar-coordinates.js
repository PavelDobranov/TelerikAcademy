// Problem 1. Planar coordinates
// - Write functions for working with shapes in standard Planar coordinate system.
//    - Points are represented by coordinates P(X, Y)
//    - Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
// - Calculate the distance between two points.
// - Check if three segment lines can form a triangle.

(function() {
  'use strict';

  var jsConsole = javaScriptConsole.createInstance('.js-console'),
    distanceSolveButton = document.querySelector('#points-distance .btn-solve'),
    triangleSooveButton = document.querySelector('#form-triangle .btn-solve'),
    clearButton = document.querySelector('.btn-clear');

  distanceSolveButton.addEventListener('click', distanceBetweenPoints);
  triangleSooveButton.addEventListener('click', formTriangle);
  clearButton.addEventListener('click', clearForm);

  function distanceBetweenPoints() {
    var firstPointX,
      firstPointY,
      secondPointX,
      secondPointY,
      firstPoint,
      secondPoint,
      line;

    try {
      firstPointX = jsConsole.readFloat('#fpoint-x');
      firstPointY = jsConsole.readFloat('#fpoint-y');
      secondPointX = jsConsole.readFloat('#spoint-x');
      secondPointY = jsConsole.readFloat('#spoint-y');

    } catch (e) {
      jsConsole.writeLine(e.message);
    }

    firstPoint = new Point(firstPointX, firstPointY);
    secondPoint = new Point(secondPointX, secondPointY);
    line = new Line(firstPoint, secondPoint);

    jsConsole.writeLine('Distance : ' + line.length().toFixed(3));
  }

  function formTriangle() {
    var linesInput = document.querySelectorAll('#form-triangle input.short'),
      lines = [],
      firstPointX,
      firstPointY,
      secondPointX,
      secondPointY,
      firstPoint,
      secondPoint;

    try {
      for (var i = 0; i < linesInput.length; i += 4) {
        firstPointX = jsConsole.readFloat('#' + linesInput[i].id);
        firstPointY = jsConsole.readFloat('#' + linesInput[i + 1].id);
        secondPointX = jsConsole.readFloat('#' + linesInput[i + 2].id);
        secondPointY = jsConsole.readFloat('#' + linesInput[i + 3].id);

        firstPoint = new Point(firstPointX, firstPointY);
        secondPoint = new Point(secondPointX, secondPointY);

        lines.push(new Line(firstPoint, secondPoint));
      }
    } catch (e) {
      jsConsole.writeLine(e.message);
    }

    jsConsole.writeLine('Can form a triangle? : ' + canFormTriangle(lines));
  }

  function canFormTriangle(lines) {
    return (lines[0].length() + lines[1].length() > lines[2].length()) &&
      (lines[0].length() + lines[2].length() > lines[1].length()) &&
      (lines[1].length() + lines[2].length() > lines[0].length());
  }

  function Point(x, y) {
    this.x = x;
    this.y = y;
  }

  function Line(firstPoint, secondPoint) {
    this.firstPoint = firstPoint;
    this.secondPoint = secondPoint;
  }

  Line.prototype.length = function() {
    return Math.sqrt((this.firstPoint.x - this.secondPoint.x) *
      (this.firstPoint.x - this.secondPoint.x) +
      (this.firstPoint.y - this.secondPoint.y) *
      (this.firstPoint.y - this.secondPoint.y));
  };

  function clearForm() {
    var inputElements = document.querySelectorAll('.input-container > input');

    for (var element = 0; element < inputElements.length; element += 1) {
      inputElements[element].value = '';
    }

    jsConsole.clear();
  }
}());
