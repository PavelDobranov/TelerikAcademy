function solve() {
    resetConsole();

    var input = document.getElementById('num').value;

    if (isValidIntInput(input)) {
        var number = parseInt(input);
        var result = isPrime(number);
        printResult(result);
    }
    else {
        printInvalidInput(input);
    }
}

function isPrime(number) {
    var start = 2;

    while (start <= Math.sqrt(number)) {
        if (number % start++ < 1) {
            return false;
        }
    }

    return number > 1;
}

function printResult(result) {
    jsConsole.writeLine('Is prime ? : ' + result);
}

function isValidIntInput(input) {
    return !(isNaN(input) || input % 1 !== 0 || input === '');
}

function printInvalidInput(input) {
    if (input === '') {
        jsConsole.writeLine('Please fill the field');
    }
    else {
        jsConsole.writeLine('Invalid Input : ' + input);
        jsConsole.writeLine('Must be an integer');
    }
}

function resetConsole() {
    jsConsole.clear();
}