function getAllNestedDivsWithQuerySelector() {
    var nestedDivs = document.querySelectorAll('div > div');

    for (var i = 0, len = nestedDivs.length; i < len; i++) {
        nestedDivs[i].style.color = 'red';
    }
}

function getAllNestedDivsWithGetElement() {
    var divs = document.getElementsByTagName('div');

    for (var i = 0, len = divs.length; i < len; i++) {
        if (divs[i].parentNode instanceof HTMLDivElement) {
            divs[i].style.color = 'green';
        }
    }
}