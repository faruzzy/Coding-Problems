Array.prototype.foreach = function(fn) {
	var len = this.length,
		i = 0;

	for(i; i < len; i++)
		fn(this[i], i, this);
};
