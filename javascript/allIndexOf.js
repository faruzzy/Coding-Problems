function allIndexOf(arr, val) {
	var allIndexes = [];
	for (var i = 0; i < arr.length; i++)
		if(arr[i] === val)
			allIndexes.push(i);

	return allIndexes;
}

if (!Array.prototype.allIndexOf) {
	Object.defineProperty(Array.prototype, 'allIndexOf', {
		enumerable: false,
		configurable: true,
		writable: true,
		value: function(predicate) {

		}
	});
}
