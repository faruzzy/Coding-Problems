//works like call function
Function.prototype.myCall = function(scope) {
	'use strict';
	let args = Array.prototype.slice.call(arguments, 1);
	let fn = this;
	return function() {
		return fn.apply(scope, args);
    };
};
