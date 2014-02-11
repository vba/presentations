

interface IAnimal {
	walk(): void;
}

class Eagle implements IAnimal {
	name: string;

	constructor(name: string) {
	    this.name = name;
	}
	walk(): void {
		console.log("[Eagle] I'm an eagle and I can walk ...");
	}
	public canFly(): boolean {
	    return true;
	}
}

var eagle: Eagle = new Eagle("Bobby");
eagle.walk();

if (eagle.canFly()) {
	console.log("Mom, I can fly, I guess");
}