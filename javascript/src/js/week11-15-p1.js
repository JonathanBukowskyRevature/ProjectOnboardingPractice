/*
1) Write two functions:

- One to retrieve all unique substrings that start and end with a vowel.
- One to retrieve all unique substrings that start and end with a consonant.
The resulting array should be sorted in lexicographic ascending order (same order as a dictionary).
*/

function createSubstrings(chars, str) {
    let substrings = [];
    let indices = [];
    [...str].forEach((c, i) => {
        if (chars.includes(c)) {
            indices.push(i);
        }
    });
    for (let i = 0; i < indices.length; i++) {
        for (let j = i; j < indices.length; j++) {
            let left = indices[i];
            let right = indices[j];
            substrings.push(str.substring(left, right + 1));
        }
    }
    substrings.sort();
    let unique = new Set(substrings);
    return Array.from(unique);

}

function getVowelSubstrings(str) {
    let vowels = ['a', 'e', 'i', 'o', 'u'];
    return createSubstrings(vowels, str);
}

function getConsonantSubstrings(str) {
    let consonants = ['b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z'];
    return createSubstrings(consonants, str);
}

function displayArray(arr) {
    return "[" + arr.map(n => '"' + n + '"').join(", ") + "]";
}

function testVowelSubstrings() {
    // vacuum to test that 'u' doesn't show up twice
    console.log(getVowelSubstrings("vacuum"));
    let v1 = document.getElementById('getVowelSubstrings1');
    v1.innerHTML = displayArray(getVowelSubstrings('apple'));

    let v2 = document.getElementById('getVowelSubstrings2');
    v2.innerHTML = displayArray(getVowelSubstrings('hmm'));

    let c1 = document.getElementById('getConsonantSubstrings1');
    c1.innerHTML = displayArray(getConsonantSubstrings('aviation'));

    let c2 = document.getElementById('getConsonantSubstrings2');
    c2.innerHTML = displayArray(getConsonantSubstrings('motor'));
}

testVowelSubstrings();