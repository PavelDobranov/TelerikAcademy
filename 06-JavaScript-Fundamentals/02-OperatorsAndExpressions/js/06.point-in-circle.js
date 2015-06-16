function solve() {
    resetConsole();

    var inputElements = document.getElementsByClassName('input');
    var pointCoords = [];
    var circleCoords = [0, 0];
    var circleRadius = 5;
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
        var result = isWithinCircle(pointCoords, circleCoords, circleRadius);
        printResult(pointCoords, circleCoords, circleRadius, result);
    }
}

function isWithinCircle(pointCoords, circleCoords, circleRadius) {
    var xDelta = pointCoords[0] - circleCoords[0];
    var yDelta = pointCoords[1] - circleCoords[1];

    return (xDelta * xDelta) + (yDelta * yDelta) <= circleRadius * circleRadius;
}

function printResult(pointCoords, circleCoords, circleRadius, result) {
    jsConsole.writeLine('Point (' + pointCoords[0] + ', ' + pointCoords[1] +
        ') is within a circle ((' + circleCoords[0] + ', ' + circleCoords[1] +
        '), ' + circleRadius + ') ? : ' + result);
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