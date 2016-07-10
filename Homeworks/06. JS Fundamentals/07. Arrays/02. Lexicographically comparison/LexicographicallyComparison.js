function LexComparison (args) {
	var arr = args[0].split('\n'),
	first = String(arr[0]),
	second = String(arr[1]);
	
	if (first < second)
	{
		console.log('<');
	}
	else if (first == second)
	{
		console.log('=');
	}
	else
	{
		console.log('>');
	}
}