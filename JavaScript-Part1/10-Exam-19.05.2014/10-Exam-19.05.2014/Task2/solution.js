function solve(args) {
    var rowsAndCols = args[0].split(" ");
    var rows = parseInt(rowsAndCols[0]);
    var cols = parseInt(rowsAndCols[1]);

    //fill the matrix
    var field = [],
        moves = [],
        number = 1,
        currentCol = 0,
        currentRow = 0,
        sum = 1;

    for (var i = 0; i < rows; i++) {
        field[i] = [];
        number = Math.pow(2, i);
        for (var j = 0; j < cols; j++) {
            field[i][j] = number;
            number++;
        }
    }

    //copy the moves
    for (i = 1; i < args.length; i++) {
        var move = args[i].split(" ");
        moves.push(move);
    }

    while (true) {
        var rowMove = calculateRowOrCol(moves[currentRow][currentCol][0]);
        var colMove = calculateRowOrCol(moves[currentRow][currentCol][1]);
        currentRow += rowMove;
        currentCol += colMove;

            if (field[currentRow] === undefined || field[currentRow][currentCol] === undefined) {
                return "successed with " + sum;
            }

            if (field[currentRow][currentCol] === 0) {
                return "failed at (" + currentRow + ", " + currentCol + ")";
            }

            sum += field[currentRow][currentCol];
            field[currentRow][currentCol] = 0;
    //    }
    }

    function calculateRowOrCol(letter) {
        switch (letter) {
            case "u":
                return -1;
            case "d":
                return 1;
            case "l":
                return -1;
            case "r":
                return 1;
        }
    }
}