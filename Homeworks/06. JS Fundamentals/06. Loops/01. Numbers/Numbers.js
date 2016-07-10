function Numbers(args) {
    var number = +args[0], result = '';

    for (var i = 1; i <= number; i+= 1) {
		result += i + ' ';
    }

    console.log(result);
}