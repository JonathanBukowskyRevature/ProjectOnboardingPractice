/*
Problem 1
This robot roams around a 2D grid. It starts at (0, 0) facing North.
After each time it moves, the robot rotates 90 degrees clockwise.
Given the amount the robot has moved each time, you have to calculate the robot's final position.
*/

function trackRobot() {
    throw new Error("test error");
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

/*
Problem 2
Given an amount of money (in cents $ to make it simpler) and a productNumber,
the vending machine should output the correct product name and give back the correct amount of change.

The coins used for the change are the following: [500, 200, 100, 50, 20, 10]
*/

coins = [500, 200, 100, 50, 20, 10];

function vendingMachine(products, money, productNumber) {
    if (productNumber <= 0 || productNumber > products.length) {
        return 'Enter a valid product number';
    } else if (money < products[productNumber - 1].cost) {
        return 'Not enough money for this product';
    }
    let product = products[productNumber - 1];
    money = money - product.cost;
    let change = [];
    for (let coin of coins) {
        if (coin > money) {
            continue;
        }
        while (money >= coin) {
            money -= coin;
            change.push(coin);
        }
    }
    return { product: product.name, change: change };
}

var testProducts = [
    { name: 'Coke', cost: 100 },
    { name: 'Fanta', cost: 100 },
    { name: 'Pepsi', cost: 150 },
    { name: 'Root Beer', cost: 200 },
    { name: 'Chocolate bar', cost: 100 },
    { name: 'Reeses cups', cost: 250 },
    { name: 'Crackers', cost: 120 },
]

function main() {
    try {
        var test1 = trackRobot(20, 30, 10, 40);
        console.log(test1, test1[0] == -10 && test1[1] == 10 ? 'Correct' : 'Incorrect');
    }
    catch (error) {
        console.log(error);
    }

    var test2 = trackRobot();
    console.log(test2, test2[0] == 0 && test2[1] == 0 ? 'Correct' : 'Incorrect');

    var test3 = trackRobot(-10, 20, 10);
    console.log(test3, test3[0] == 20 && test3[1] == -20 ? 'Correct' : 'Incorrect');

    var vmTest1 = vendingMachine(testProducts, 200, 7);
    console.log(vmTest1, vmTest1.product == 'Crackers'
        && vmTest1.change.length == 3
        && vmTest1.change[0] == 50
        && vmTest1.change[1] == 20
        && vmTest1.change[2] == 10 ? 'Correct' : 'Incorrect'
    );

    var vmTest2 = vendingMachine(testProducts, 500, 0);
    console.log(vmTest2, vmTest2 == 'Enter a valid product number' ? 'Correct' : 'Incorrect');

    var vmTest3 = vendingMachine(testProducts, 200, 6);
    console.log(vmTest3, vmTest3 == 'Not enough money for this product' ? 'Correct' : 'Incorrect');

    var vmTest4 = vendingMachine(testProducts, 250, 6);
    console.log(vmTest4, vmTest4.product == 'Reeses cups' && vmTest4.change.length == 0 ? 'Correct' : 'Incorrect');
}

main();