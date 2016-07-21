const fs = require('fs');

const [, ...output] = fs.readFileSync('large.in', 'utf8')
	.trim()
	.split('\n');

const result = output.map(x => x.split(' ')
		.reverse()
		.join(' '));

result.forEach(x => {
	fs.appendFile('result.txt', `${x} \n`);
});

