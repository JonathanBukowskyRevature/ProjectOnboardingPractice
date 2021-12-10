

function createMeanFunc(meanFunc) {
    function doIt(numbers, precision) {
        var mean = meanFunc(numbers);
        return Number.parseFloat(mean.toFixed(precision));
    }
    return doIt;
}

function arithmeticMean(xs) {
    var sum = 0;
    for (var i = 0; i < xs.length; i++) {
        sum += xs[i];
    }
    return sum / xs.length;
}
Math.avg = createMeanFunc(arithmeticMean);

function quadraticMean(xs) {
    var ys = xs.map(x => x * x);
    var yavg = arithmeticMean(ys);
    return Math.sqrt(yavg);
}
Math.qAvg = createMeanFunc(quadraticMean);

function harmonicMean(xs) {
    var sum = 0;
    for (var i = 0; i < xs.length; i++) {
        sum += 1 / xs[i];
    }
    return xs.length / sum;
}
Math.hAvg = createMeanFunc(harmonicMean);

function geometricMean(xs) {
    var prod = 1;
    for (var i = 0; i < xs.length; i++) {
        prod *= xs[i];
    }
    return Math.pow(prod, 1 / xs.length);
}
Math.gAvg = createMeanFunc(geometricMean);


function tune(freqs) {
    var correct = [329.63, 246.94, 196.00, 146.83, 110.00, 82.41];
    var result = [];
    for (var i = 0; i < correct.length; i++) {
        var diff = Math.abs(freqs[i] - correct[i]);// * 100 / freqs[i];
        if (freqs[i] == 0) {
            result.push(" - ");
        } else if (diff < 1) {
            result.push("OK");
        } else if (freqs[i] > correct[i]) {
            if (diff > 2) {
                result.push("•<<");
            } else {
                result.push("•<");
            }
        } else {
            if (diff > 2) {
                result.push(">>•");
            } else {
                result.push(">•");
            }
        }
    }
    return result;
}

// run tests

/*
<p>Math.avg([3,5,7]) -> <span id="avg-value"></span></p>
<p>Math.qAvg([3,5,7], 1) -> <span id="qavg-value"></span></p>
<p>Math.hAvg([3,5,7], 1) -> <span id="havg-value"></span></p>
<p>Math.gAvg([3,5,7], 1) -> <span id="gavg-value"></span></p>
*/
var avgElem = document.getElementById("avg-value");
var qavgElem = document.getElementById("qavg-value");
var havgElem = document.getElementById("havg-value");
var gavgElem = document.getElementById("gavg-value");

avgElem.innerHTML = Math.avg([3, 5, 7]);
qavgElem.innerHTML = Math.qAvg([3, 5, 7], 1);
havgElem.innerHTML = Math.hAvg([3, 5, 7], 1);
gavgElem.innerHTML = Math.gAvg([3, 5, 7], 1);


var tune1 = document.getElementById("tune-1");
var tune2 = document.getElementById("tune-2");
var tune3 = document.getElementById("tune-3");

tune1.innerHTML = tune([0, 246.94, 0, 0, 0, 80]);
tune2.innerHTML = tune([329, 246, 195, 146, 111, 82]);
tune3.innerHTML = tune([329.63, 246.94, 196, 146.83, 110, 82.41]);