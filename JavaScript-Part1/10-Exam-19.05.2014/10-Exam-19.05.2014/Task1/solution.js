//function solve(input) {
//    var wheelsCount = parseInt(input);
//    var wheelsLeft = wheelsCount;

//    function testCombination1() {

//        var count = 0;

//        while (wheelsLeft > 2) {
//            wheelsLeft -= 3;
//            count++;
//        }

//        if (wheelsLeft - 3 === 0) {
//            count++;
//        }

//        while (wheelsLeft % 4 !== 0 && wheelsLeft % 10 !== 0) {
//            wheelsLeft += 3;
//            count--;
//        }

//        while (wheelsLeft > 3) {
//            wheelsLeft -= 4;
//            count++;
//        }

//        while (wheelsLeft % 10 !== 0) {
//            wheelsLeft += 4;
//            count--;
//        }

//        while (wheelsLeft > 0) {
//            wheelsLeft -= 10;
//            count++;
//        }

//        return count;

//    }
//}

function solve(input) {
    var t = parseInt(input);
    o = [3, 4, 10];
    'use strict';
    var targetsLength = t + 1;
    var operandsLength = o.length;
    t = [1];

    for (var a = 0; a < operandsLength; a++) {
        for (var b = 1; b < targetsLength; b++) {

            // initialise undefined target
            t[b] = t[b] ? t[b] : 0;

            // accumulate target + operand ways
            t[b] += (b < o[a]) ? 0 : t[b - o[a]];
        }
    }

    return t[targetsLength - 1];
}

console.log(countcoins('40'));