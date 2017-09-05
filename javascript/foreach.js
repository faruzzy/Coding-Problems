Array.prototype.foreach = function(fn) {
	for (let i = 0; i < len; i++)
		fn(this[i], i, this);
};
