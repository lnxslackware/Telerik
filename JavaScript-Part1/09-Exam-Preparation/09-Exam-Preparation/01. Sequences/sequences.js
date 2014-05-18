function Solve(params) {
    var arr = params;
    arr.shift();
    var count = 1;
    for (var i = 1; i < arr.length; i++) {
        if (parseInt(arr[i]) < parseInt(arr[i-1])) {
            count++;
        }
    }

    return count;
}