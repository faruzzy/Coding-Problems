/*-- FACTORS

	Write a function that returns an array 
	containing all of the factors of a number.

	For example: factors(10) returns [1, 2, 5, 10]
*/

function factors(num) {
	let array = [];
	for (let i = 1; i <= num; i++)
		if (num % i === 0)
			array.push(i);

	return array;
}
