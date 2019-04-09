var assert = require('assert');
module.exports = class Queue extends Array {
    constructor(limit=5) {
        super();
        console.log('costruttoreCoda')
        if (limit) {
            this._limit = limit;
        } else {

            this._limit = 5;
        }
        this._indexOfFirst = -1;
        this._indexOfLast = -1;
        this._howMany = 0;
    }

    get limit() {
        return this._limit;
    }

    set limit(value) {
        this._limit = value;
    }

    moveIndex(index) {
        assert(index>=-1 && index <=this._limit)
        console.log((index + 1) % this._limit);
        return (index + 1) % this._limit;

    }
    enqueue(item) {
        // ogni volta che inserisco modifico indece dell'ultimo, quello appena inswerito
        if (!this.isfull()) {
            // se la coda è vuota devo anche 
            if (this.isempty()) {
                this._indexOfFirst = 0;
            }
            this._indexOfLast = this.moveIndex(this._indexOfLast);
            super[this._indexOfLast] = item;
            console.log('messo  ' + item);
            this._howMany++;
        } else {
            console.log('la coda è piena')
        }
    }
    dequeue() {
        // ogni volta che tolgo modifico l'indice del primo, cioè il prossimo da prelevare
        if (!this.isempty()) {
            var r = this[this._indexOfFirst];
            
            if (--this._howMany==0) {
                this._indexOfFirst = -1;
                this._indexOfLast = -1;
                console.log('svuotata....' );
                
            } else {
                this._indexOfFirst = this.moveIndex(this._indexOfFirst);

            }
            console.log('preso  ' + r);
            return r;
        } else {
            console.log('la coda è vuota')
        }

    }
    isfull() {
        return this._howMany == this._limit
    }
    isempty() {

        return (!this._howMany)
    }


}

// q = new Queue;
// console.log('---vuota= ' + q.isempty());
// console.log('----piena= ' + q.isfull());

// q.enqueue(0);
// console.log('vuota= ' + q.isempty());
// console.log('piena= ' + q.isfull());
// q.enqueue(1);
// console.log('vuota= ' + q.isempty());
// console.log('piena= ' + q.isfull());
// q.enqueue(2);
// console.log('vuota= ' + q.isempty());
// console.log('piena= ' + q.isfull());
// q.enqueue(3);
// console.log('vuota= ' + q.isempty());
// console.log('piena= ' + q.isfull());
// q.enqueue(4);
// console.log('vuota= ' + q.isempty());
// console.log('piena= ' + q.isfull());
// console.log('primo dequeue  ' + q.dequeue());
// console.log('vuota= ' + q.isempty());
// console.log('piena= ' + q.isfull());
// q.dequeue();
// console.log('vuota= ' + q.isempty());
// console.log('piena= ' + q.isfull());
// q.dequeue();
// console.log('vuota= ' + q.isempty());
// console.log('piena= ' + q.isfull());
// q.dequeue();
// console.log('vuota= ' + q.isempty());
// console.log('piena= ' + q.isfull());
// q.dequeue();
// console.log('vuota= ' + q.isempty());
// console.log('piena= ' + q.isfull());
// q.dequeue();
// console.log('vuota= ' + q.isempty());
// console.log('piena= ' + q.isfull());
// q.dequeue();
// console.log('vuota= ' + q.isempty());
// console.log('piena= ' + q.isfull());
// q.dequeue();
// console.log('vuota= ' + q.isempty());
// console.log('piena= ' + q.isfull());
// q.dequeue();
// console.log('vuota= ' + q.isempty());
// console.log('piena= ' + q.isfull());
