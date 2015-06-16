function solve() {
    resetConsole();

    var inputElements = document.getElementsByClassName('input');
    var pointCoords = [];
    var circleCoords = [0, 0];
    var circleRadius = 5;
    var rectangleTop = 1;
    var rectangleLeft = -1;
    var rectangleWidth = 6;
    var rectangleHeight = 2;
    var isWithinCircle;
    var isOutOfRectangle;
    var validInput = true;

    for (var input = 0; input < inputElements.length; input++) {
        var currInput = inputElements[input].value;

        if (isValidFloatInput(currInput)) {
            pointCoords[input] = parseFloat(currInput);
        }
        else {
            validInput = false;
            printInvalidInput(currInput);
            break;
        }
    }

    if (validInput) {
        var result = isWithinCircleOutOfRectangle();
        printResult(result);
    }

    function isWithinCircleOutOfRectangle() {
        var xDelta = pointCoords[0] - circleCoords[0];
        var yDelta = pointCoords[1] - circleCoords[1];

        isWithinCircle = (xDelta * xDelta) + (yDelta * yDelta) < circleRadius * circleRadius;

        var rectangleRight = rectangleLeft + rectangleWidth;
        var rectangleBottom = rectangleTop - rectangleHeight;

        isOutOfRectangle = pointCoords[0] < rectangleLeft ||
            pointCoords[0] > rectangleRight ||
            pointCoords[1] > rectangleTop ||
            pointCoords[1] < rectangleBottom;

        return isWithinCircle && isOutOfRectangle;
    }

    function printResult(result) {
        jsConsole.writeLine('Is the point within the circle ? : ' + isWithinCircle);
        jsConsole.writeLine('Is the point out of the rectangle ? : ' + isOutOfRectangle);
        jsConsole.writeLine('Final result : ' + result);
    }
}

function isValidFloatInput(input) {
    return !(isNaN(input) || input === '');
}

function printInvalidInput(input) {
    if (input === '') {
        jsConsole.writeLine('Please fill all fields');
    }
    else {
        jsConsole.writeLine('Invalid Input : ' + input);
        jsConsole.writeLine('Must be a number');
    }
}

function resetConsole() {
    jsConsole.clear();
}