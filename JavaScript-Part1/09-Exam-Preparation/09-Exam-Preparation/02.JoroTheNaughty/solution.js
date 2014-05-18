function Solve(args) {
    var field = [];
    var n = parseInt(args[0][0]),
    m = parseInt(args[0][1]);

    for (var i = 0; i < n; i++) {
        field.push([]);
        for (var j = 1 + (i * m) ; j <= m * (i + 1) ; j++) {
            field[i].push(j);
        }
    }

    var sumOfNumbers = field[parseInt(args[1][0])][parseInt(args[1][1])];
    field[parseInt(args[1][0])][parseInt(args[1][1])] = 0;
    var numberOfJumps = 0;
    var currentPosition = [parseInt(args[1][0]), parseInt(args[1][1])];

    for (i = 2; i < args.length; i++) {
        args[i][0] = parseInt(args[i][0]);
        args[i][1] = parseInt(args[i][1]);
    }

    while (true) {

        for (i = 2; i < args.length; i++) {
            numberOfJumps++;
            var currentRow = currentPosition[0] + args[i][0];
            var currentCol = currentPosition[1] + args[i][1];

            if (currentRow >= n || currentRow < 0 || currentCol >= m || currentCol < 0) {
                return "escaped " + sumOfNumbers;
            }

            if (field[currentRow][currentCol] === 0) {
                return "caught " + numberOfJumps;
            }

            sumOfNumbers += field[currentRow][currentCol];
            field[currentRow][currentCol] = 0;
            currentPosition[0] = currentRow;
            currentPosition[1] = currentCol;
        }
    }
}

var arr = [
            ['6', '7', '3'],
            ['0', '0'],
            ['2', '2'],
            ['-2', '2'],
            ['3', '-1']
];

//var arr2 = [
//            ['500', '500', '1'],
//            ['0', '0'],
//            ['1', '1']
//];

console.log(Solve(arr));