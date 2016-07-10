function PointInACircle(args) {
    var x = args[0];
    var y = args[1];
    var radius= 2;
    var distance = Math.sqrt(x * x + y * y);
    if (distance <= radius) {
        console.log('yes', distance.toFixed(2));
    }
    else{
        console.log('no', distance.toFixed(2));
    }
}