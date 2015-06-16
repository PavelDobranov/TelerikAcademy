function solve() {
    resetConsole();

    var inputElements = document.getElementsByClassName('input');
    var dimensions = [];
    var validInput = true;

    for (var input = 0; input < inputElements.length; input++) {
        var currInput = inputElements[input].value;

        if (isValidFloatInput(currInput)) {
            dimensions[input] = parseFloat(currInput);
        }
        else {
            validInput = false;
            printInvalidInput(currInput);
            break;
        }
    }

    if (validInput) {
        var sideA = dimensions[0];
        var sideB = dimensions[1];
        var height = dimensions[2];
        var area = calculateArea(sideA, sideB, height);

        printResult(area.toFixed(2));
    }
}

function calculateArea(sideA, sideB, height) {
    return (height * (sideA + sideB)) / 2;
}

function printResult(result) {
    jsConsole.writeLine('Area : ' + result + ' mm<sup>2</sup>');
}

function isValidFloatInput(input) {
    if (isNaN(input) || input === '') {
        return false;
    }

    return input > 0;
}

function printInvalidInput(input) {
    if (input === '') {
        jsConsole.writeLine('Please fill all fields');
    }
    else {
        jsConsole.writeLine('Invalid Input : ' + input);
        jsConsole.writeLine('Must be a positive number');
    }
}

function resetConsole() {
    jsConsole.clear();
}