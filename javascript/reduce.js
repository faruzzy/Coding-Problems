/*--REDUCE

	Return the sum of all the elements in an array
	plus an optional intial value.

	For example: reduce([1, 2, 3], 10) returns 16
*/

function reduce(arr, intial) {
	var sum;
	for (var i = 0; i < arr.length; i++)
		sum += arr[i];

	return sum + intial;
}

