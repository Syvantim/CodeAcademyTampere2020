var readlineSync = require('readline-sync');
var generate = require('project-name-generator');

var userName = readlineSync.question('May I have your name?'):
console.log('Hi ' + userName + '!');

console.log(generate().dashed)



