function PrimeCheck(args) {
    var number = args[0];
    if (number >= 2) {
        for (var i = 2; i <= Math.sqrt(number); i += 1) {
            if (number % i == 0) {
                console.log(false);
                return;
            }
        }
        console.log(true);
        return;
    }
    else {
        console.log(false);
    }
}