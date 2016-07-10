function Multiplication(args) {
    var a = +args[0];
    var b = +args[1];
    var c = +args[2];
    var negativeNumbers = 0;
    if (!a || !b || !c) {
        console.log('0');
        return;
    }

    if (a < 0) {
        negativeNumbers += 1;
    }
    if (b < 0) {
        negativeNumbers += 1;
    }
    if (c < 0) {
        negativeNumbers += 1;
    }

    if (negativeNumbers % 2) {
        console.log('-');
    } else {
        console.log('+');
    }
}