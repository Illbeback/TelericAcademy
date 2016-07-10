function solve(args) {
    var number = args[0];
    var mask = 1 << 3;
    console.log((number & mask) >> 3);
}