function QuadricEquation(args) {
    var a = +args[0], b = +args[1], c = +args[2], x1 = 0, x2 = 0;

    var D = b * b - 4 * a * c;
    if (D < 0) {
        return 'no real roots';
    } else if (D == 0) {
        x1 = ((b) + Math.sqrt(D)) / (2 * a);
        console.log('x1=x2=' + x1.toFixed(2));
    }
    else {
        x1 = ((b) + Math.sqrt(D)) / (2 * a);
        x2 = ((b) - Math.sqrt(D)) / (2 * a);
        console.log('x1=' + Math.min(x1, x2).toFixed(2) + '; x2=' + Math.max(x1, x2).toFixed(2));
    }
}