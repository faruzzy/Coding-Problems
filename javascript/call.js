Function.prototype.myCall = function(scope) {
	'use strict';
	var args = [].slice.call(arguments, 1);
	var fn = this;
	return function() {
		return fn.apply(scope, args);
    };
};
