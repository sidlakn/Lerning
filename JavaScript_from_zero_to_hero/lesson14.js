var date = new Date();

console.log(date.getFullYear());
console.log(date.getMonth() + 1);
console.log(date.getDate());
console.log(date.getHours());
console.log(date.getMinutes());
console.log(date.getSeconds());

date.setHours(23);
date.setMinutes(23);

console.log("час: " +  date.getHours() + ":" + date.getMinutes());


var arr = [8, 90, 5, 7, 0, 8, 9];
console.log(arr.length);
console.log(arr.join(", "));
console.log(arr.sort());

var stroka = arr.reverse().join(", ");

console.log(stroka.split(", "));
var and = "привітики всім друзяки";
console.log(and.split(" "));

console.log(arr.reverse().join(", "));


class Charachter {
  constructor(name, age, happiness, brain) {
    this.name = name;
    this.age = age;
    this.happiness = happiness;
    this.brain = brain;
  }

info() {
  console.log("людина: " + this.name + ". вік " + this.age + " мозок: " + this.brain);
}

}

var alex = new Charachter('Alex' , 45, true, false);
var bob = new Charachter('Bob' , 25, false, true);
alex.name = 'alex';
alex.info();
bob.info();

console.log(alex.name + ":" + alex.age + ":" + alex.happiness);
console.log(bob.name);
