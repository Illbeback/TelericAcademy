function MatrixOfNumbers(args) {
    var number = +args[0], result = '';

    for(var r = 1; r <= number; r += 1) {
        for(var c = r; c < r + number; c += 1) {
            result += c + ' ';
        }
        console.log(result);
        result = '';
    }
}