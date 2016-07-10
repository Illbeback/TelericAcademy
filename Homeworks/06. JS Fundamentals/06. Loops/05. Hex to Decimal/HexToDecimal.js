function HexToDecimal(args) {
    var hex = args[0], decimal = 0, hexDigits = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'];
    for(var i = hex.length - 1; i >= 0; i -= 1) {
        decimal += hexDigits.indexOf(hex[i]) * Math.pow(16, hex.length - i - 1);
    }
    
    console.log(decimal);
}