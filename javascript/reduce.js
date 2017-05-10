/*--REDUCE

	Return the sum of all the elements in an array
	plus an optional intial value.

	For example: reduce([1, 2, 3], 10) returns 16
*/

function reduce(arr, intial) {
	var sum = 0;
	for (var i = 0; i < arr.length; i++)
		sum += arr[i];

	return sum + intial;
}

function sum(arr, init) {
	return arr.reduce((acc, i) => acc + i, init);
}

let arr = [1, 2, 3];
console.log('reduce: ', reduce(arr, 10));
console.log('sum: ', sum(arr, 10));

