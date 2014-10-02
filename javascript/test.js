var Cart = {
	items: [1, 4, 3],
	click: function() {
		console.log(items);
	}
};

var button = document.querySelector('button');
//button.addEventListener('click', Cart.click);
//button.addEventListener('click', function() { Cart.onClick() });
button.addEventListener('click', function() { return Cart.onClick.apply(Cart, arguments); });

//console.log(button);
