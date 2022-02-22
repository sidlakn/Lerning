// var date = new Date();
//
// console.log(date.getFullYear());
// console.log(date.getMonth() + 1);
// console.log(date.getDate());
// console.log(date.getHours());
// console.log(date.getMinutes());
// console.log(date.getSeconds());
//
// date.setHours(23);
// date.setMinutes(23);
//
// console.log("час: " +  date.getHours() + ":" + date.getMinutes());
//
//
// var arr = [8, 90, 5, 7, 0, 8, 9];
// console.log(arr.length);
// console.log(arr.join(", "));
// console.log(arr.sort());
//
// var stroka = arr.reverse().join(", ");
//
// console.log(stroka.split(", "));
//
// console.log(arr.reverse().join(", "));


class Person {
  constructor(name, age, happiness) {
    this.name = name;
    this.age = age;
    this.happiness = happiness;
  }

info() {
  console.log("людина: " + this.name + ". вік " + this.age);
}

}

var alex = new Person('Alex' , 45, true);
var bob = new Person('Bob' , 25, false);
alex.name = 'alex2';
alex.info();
bob.info();

// console.log(alex.name + ":" + alex.age + ":" + alex.happiness);
// console.log(bob.name);
