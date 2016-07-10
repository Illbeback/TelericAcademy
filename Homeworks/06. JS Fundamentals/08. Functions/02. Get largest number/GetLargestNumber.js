function GetMax(nums) {
    
    var numbers = nums[0].split(' ');

    return Compare(numbers[0], Compare(numbers[1], numbers[2]));

	function Compare(numOne, numTwo) {
	return Math.max(numOne, numTwo);
	}
}