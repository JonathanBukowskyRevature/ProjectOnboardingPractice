/*
2) Write a function redundant that takes in a string 'str' and returns a function that returns 'str'.
*/

function redundant(str) {
    return () => str;
}

function testRedundant() {
    let r1 = document.getElementById("redundant1");
    const f1 = redundant("apple");
    r1.innerHTML = 'f1() --> "' + f1() + '"';

    let r2 = document.getElementById("redundant2");
    const f2 = redundant("pear");
    r2.innerHTML = 'f2() --> "' + f2() + '"';

    let r3 = document.getElementById("redundant3");
    const f3 = redundant("");
    r3.innerHTML = 'f3() --> "' + f3() + '"';
}

testRedundant();