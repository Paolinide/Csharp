var Queue = require('./myQueue')
var stack = require('./myStack');
var q = new Queue;
var q1 = new Queue(10);
for (let index = 0; index < 11; index++) {
    q.enqueue(index);
    q1.enqueue(index);
}
for (let index = 0; index < 5; index++) {
    q.dequeue();
    q1.dequeue();
}

for (let index = 0; index < 11; index++) {
    q.enqueue(index);
    q1.enqueue(index);
}
