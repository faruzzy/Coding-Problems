const fs = require('fs');

const [, ...lines] = fs.readFileSync('large.in', 'utf8').trim().split('\n');
const output = lines.map(line => line.split(' ').reverse().join(' ')); 

const fd = fs.openSync('result.txt', 'a');

output.forEach((x, index) => {
	fs.writeSync(fd, `Case #${index + 1}: ${x}\n`);
});

fs.closeSync(fd);
