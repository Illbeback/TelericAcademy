function Exchange(args) {
    var a = +args[0];
    var b = +args[1];
    var c = +args[2];
    var d = +args[3];
    var e = +args[4];
    var f = Math.max(a, b);
    var g = Math.max(c, d);
    var h = Math.max(f, g);
    var y = Math.max(h, e);
	console.log(y)
}