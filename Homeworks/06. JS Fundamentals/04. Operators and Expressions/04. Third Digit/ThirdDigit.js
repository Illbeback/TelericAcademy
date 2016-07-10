function thirdDigitIs7(number) {
    var thirdDigit = Math.floor(number / 100) % 10;
    if (thirdDigit == 7){
    	console.log(true)
    }
    else {
    	console.log("false " + thirdDigit)
    }
}