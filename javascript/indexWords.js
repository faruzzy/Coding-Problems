/*--INDEX WORDS

  Write a function that takes an array containing a list of words
  and returns an object mapping out the first letter of each word
  to an array of the words starting with that letter.

  For example: indexWords(["apple", "car", "cat"]) returns {a: ["apple"], c: ["car", "cat"]}
*/

function indexWords(arr) {
	let obj = {};
	for (let i in arr) {
		let ch = arr[i].substring(0, 1);
		if (!obj[ch])
			obj[ch] = [];

		obj[ch].push(arr[i]);
	}

	return obj;
}
