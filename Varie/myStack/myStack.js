// require('./tools.js')();

// classe (ECMA6)
module.exports = class Stack extends Array {
    constructor(limit) {
        super();
        console.log('costruttore')
        if (limit) {
            this._limit = limit;
        } else {

            this._limit = 3;
        }

    }
    get limit() {
        return this._limit;
    }

    set limit(value) {
        this._limit = value;
    }


    pop() {
        if (!this.isempty()) {
            console.log('in posizione ' + (this.length-1) + ' vedo  ' + this[this.length-1] + '\n')

            return super.pop();
        } else {
            console.log('la pila è vuota\n');
        }

    }
    push(item) {
        if (!this.isfull()) {
            console.log('--inserisco ' + item + ' in posizione ' + this.length + '\n')
            super.push(item);
            
        } else {
            console.log('la pila è piena, non posso farlo\n');
        }

    }
    isempty() {
        return (this.length == 0)
    }
    isfull() {
        
        return (this.length == this.limit)
    }
    peek() {
        console.log(this.length-1);
        return super[this.length-1 ];
    }
}


// var s = new Stack;
// console.log(s);
// console.log(s.isfull())
// s.push(1);
// console.log(s.isfull())
// s.push(2);
// console.log(s.isfull())
// s.push(3);
// console.log(s.isfull())
// s.push(4);
// console.log(s.isfull())
// s.limit++
// console.log(s.isfull())

// s.push(5);
// console.log(s.isfull())
// //console.log(s.isempty())
// console.log(s.peek())
// console.log(s.peek())
// console.log(s.peek())
// console.log(s.peek())
// console.log(s.peek())
// console.log(s.peek())
// console.log(s.peek())
// console.log(s.pop());
// console.log(s.isempty())
// console.log(s.pop());
// console.log(s.isempty())

// console.log(s.pop());
// console.log(s.pop());
// console.log(s.pop());
// console.log(s.pop());
// console.log(s.pop());
// console.log(s.pop());
// console.log(s.pop());
// s.limit=5
// s.push(0)
// s.push(1)
// s.push(2)
// s.push(3)
// s.push(4)
// s.push(5)
// s.limit++
// s.push(5)
// s.pop()
// s.pop()
// s.pop()
// s.pop()
// s.pop()
// s.pop()

// s.pop()
// s.push(0)
// s.push(1)
// s.push(2)
// s.peek()
// s.peek()
// s.peek()
// s.peek()



