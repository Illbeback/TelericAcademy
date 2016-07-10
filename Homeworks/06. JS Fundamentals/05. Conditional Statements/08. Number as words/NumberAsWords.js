function NumberAsWords(args) {
    var number = +args[0], result = "";

    switch (number % 10) {
        case 0:
            result = 'zero';
            break;
        case 1:
            result = 'one';
            break;
        case 2:
            result = 'two';
            break;
        case 3:
            result = 'three';
            break;
        case 4:
            result = 'four';
            break;
        case 5:
            result = 'five';
            break;
        case 6:
            result = 'six';
            break;
        case 7:
            result = 'seven';
            break;
        case 8:
            result = 'eight';
            break;
        case 9:
            result = 'nine';
            break;
    }

    if (number > 9) {
        if (((number % 100) | 0) < 20) {
            switch (number % 100) {
                case 0:
                    result = "";
                    break;
                case 10:
                    result = 'ten';
                    break;
                case 11:
                    result = 'eleven';
                    break;
                case 12:
                    result = 'twelve';
                    break;
                case 13:
                    result = 'thirteen';
                    break;
                case 14:
                    result = 'fourteen';
                    break;
                case 15:
                    result = 'fivteen';
                    break;
                case 16:
                    result = 'sixteen';
                    break;
                case 17:
                    result = 'seventeen';
                    break;
                case 18:
                    result = 'eighteen';
                    break;
                case 19:
                    result = 'nineteen';
                    break;
            }
        } else {
            switch (((number % 100) / 10) | 0) {
                case 0:
                    result = "";
                    break;
                case 1:
                    result = "";
                    break;
                case 2:
                    result = 'twenty ' + result;
                    break;
                case 3:
                    result = 'thirty ' + result;
                    break;
                case 4:
                    result = 'fourty ' + result;
                    break;
                case 5:
                    result = 'fifty ' + result;
                    break;
                case 6:
                    result = 'sixty ' + result;
                    break;
                case 7:
                    result = 'seventy ' + result;
                    break;
                case 8:
                    result = 'eighty ' + result;
                    break;
                case 9:
                    result = 'ninety ' + result;
                    break;
            }
        }
        if (number > 99) {
            var and = "";
            if (result !== "") {
                and = 'and ';
            }
            switch ((number / 100) | 0) {
                case 0:
                    result = "";
                    break;
                case 1:
                    result = 'one hundred ' + and + result;
                    break;
                case 2:
                    result = 'two hundred ' + and + result;
                    break;
                case 3:
                    result = 'three hundred ' + and + result;
                    break;
                case 4:
                    result = 'four hundred ' + and + result;
                    break;
                case 5:
                    result = 'five hundred ' + and + result;
                    break;
                case 6:
                    result = 'six hundred ' + and + result;
                    break;
                case 7:
                    result = 'seven hundred ' + and + result;
                    break;
                case 8:
                    result = 'eight hundred ' + and + result;
                    break;
                case 9:
                    result = 'nine hundred ' + and + result;
                    break;
            }
        }
    }
    result = result[0].toUpperCase() + result.substr(1);
    console.log(result);
}