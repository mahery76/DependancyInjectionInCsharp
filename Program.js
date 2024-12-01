class Hammer {
    use() {
        console.log("Hammer is used");
    }
}

class Saw {
    use() {
        console.log("Saw is used");
    }
}

class Builder {
    constructor() {
        this._hammer = new Hammer(); // builder is responsible for creating its dependencies
        this._saw = new Saw();
    }

    buildHouse() {
        this._hammer.use();
        this._saw.use();
        console.log("House is built");
    }
}

class Program {
    static main() {
    
    }
}

// Simulate the Main method call
Program.main();