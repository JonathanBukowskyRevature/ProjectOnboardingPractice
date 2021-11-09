/*
Problem 1
This robot roams around a 2D grid. It starts at (0, 0) facing North.
After each time it moves, the robot rotates 90 degrees clockwise.
Given the amount the robot has moved each time, you have to calculate the robot's final position.
*/

function trackRobot() {
    var curX = 0;
    var curY = 0;
    for (var i = 0; i < arguments.length; i++) {
        var move = arguments[i];
        switch (i % 4) {
            case 0:
                curY += move;
                break;
            case 1:
                curX += move;
                break;
            case 2:
                curY -= move;
                break;
            case 3:
                curX -= move;
                break;
        }
    }
    return [curX, curY];
}

function main() {
    var test1 = trackRobot(20, 30, 10, 40);
    console.log(test1, test1[0] == -10 && test1[1] == 10 ? 'Correct' : 'Incorrect');

    var test2 = trackRobot();
    console.log(test2, test2[0] == 0 && test2[1] == 0 ? 'Correct' : 'Incorrect');

    var test3 = trackRobot(-10, 20, 10);
    console.log(test3, test3[0] == 20 && test3[1] == -20 ? 'Correct' : 'Incorrect');
}

main();