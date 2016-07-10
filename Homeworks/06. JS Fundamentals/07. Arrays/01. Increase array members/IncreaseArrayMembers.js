function IncreaseArrayMembers (args){
    var number = +args[0]; 
    var arr = [];

    for (var i = 0; i < number; i+= 1) {
		arr[i] = +(i * 5);
		console.log(arr[i]);
    }
}