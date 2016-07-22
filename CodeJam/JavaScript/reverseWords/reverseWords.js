const fs = require('fs');

const [, ...output] = fs.readFileSync('large.in', 'utf8')
	.trim()
	.split('\n');

const result = output.map(x => x.split(' ')
		.reverse()
		.join(' '));

const fd = fs.openSync('result.txt', 'a');
result.forEach((x, index) => {
	fs.writeSync(fd, `Case #${index + 1}: ${x}\n`);
});

fs.closeSync(fd);
