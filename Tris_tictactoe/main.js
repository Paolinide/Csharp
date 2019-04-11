var origBoard;
const huPlayer = 'O';
const aiPlayer = 'X';
var nextPlayer = 'X';
var movesLeft = 9;
const winCombos = [
    [0, 1, 2],
    [3, 4, 5],
    [6, 7, 8],
    [0, 3, 6],
    [1, 4, 7],
    [2, 5, 8],
    [0, 4, 8],
    [6, 4, 2]
]

const celle = document.querySelectorAll('.cell');
startGame();

function startGame() {
    document.querySelector(".endgame").style.display = "none";
    origBoard = Array.from(Array(9).keys());
    celle.forEach(cella => {
        cella.innerText = '';
        cella.style.removeProperty('background-color');
        //cella.addEventListener('click', turnClick, false);
    });
    movesLeft = 9;
}
function Player() {
    let player = nextPlayer;
    if (nextPlayer == 'X') nextPlayer = 'O';
    else nextPlayer = 'X';
    return player;
}

function turnClick(squareId) {
    if (movesLeft > 0) {
        if (origBoard[squareId] == squareId) {
            turn(squareId, Player());
            movesLeft--;
        }
    } else {
        startGame();
    }
}

function turn(squareId, player) {
    origBoard[squareId] = player;
    document.getElementById(squareId).innerText = player;
    let gameWon = checkWin(origBoard, player);
    if (gameWon) gameOver(gameWon);
}

function checkWin(board, player) {
    let plays = board.reduce((a, e, i) =>
        (e === player) ? a.concat(i) : a, []);
    let gameWon = null;
    for (let [index, win] of winCombos.entries()) {
        if (win.every(elem => plays.indexOf(elem) > -1)) {
            gameWon = { index: index, player: player };
            movesLeft = 0;
            break;
        }
    }
    return gameWon;
}

function gameOver(gameWon) {
    for (let index of winCombos[gameWon.index]) {
        document.getElementById(index).style.backgroundColor =
            gameWon.player == huPlayer ? "green" : "red";
    }
    for (var i = 0; i < celle.length; i++) {
        celle[i].removeEventListener('click', turnClick, false);
    }
}