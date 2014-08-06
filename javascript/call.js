//works like call function
Function.prototype.myCall = function(scope) {
	'use strict';
	var args = Array.prototype.slice.call(arguments, 1);
	var fn = this;
	return function() {
		return fn.apply(scope, args);
    };
};
