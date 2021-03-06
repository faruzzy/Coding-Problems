/*--MEDIAN

  Write a function that finds the median of a given array of integers.
  If the array has an odd number of integers, return the middle item 
  from the sorted array. If the array has an even number of integers, 
  return the average of the middle two items from the sorted array.

  For example: median([1, 3, 5]) returns 3
*/

function median(arr) {
	if (arr.length % 2 !== 0)
		return arr[Math.floor(arr.length / 2)];
	else 
		let middleIndex = Math.floor(arr.length / 2);
		return ( (arr[middleIndex - 1] + arr[middleIndex]) / 2 );
}

