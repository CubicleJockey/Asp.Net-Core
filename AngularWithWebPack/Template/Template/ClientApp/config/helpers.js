const path = require('path');
const root = path.resolve(__dirname, '..');

function Root() {
    const args = Array.prototype.slice.call(arguments, 0);
    return path.join.apply(path, [root].concat(args));
}
exports.root = Root;