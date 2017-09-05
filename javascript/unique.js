/*--UNIQUE
 	Write a function that takes an array and returns
 	a new sorted array containig all of the unique elements
 	of the original array.

 	For example: unique([1, 2, 2, 3]) returns [1, 2, 3];
 */

 function unique(arr) {
 	let n = arr.length;
 	for (let i = 0; i < n; i++)
 		for (let j = i + 1; j < n; j++)
 			if (arr[i] === arr[j])
 				arr.splice(j, 1);

 	return arr;
 }
