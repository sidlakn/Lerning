function info(word) {
  console.log(word + "!");
  console.log("!");
  console.log("привітики");
}

function summa(a, b) {
  var res = a + b;
  info(res);
}

// summa(5, 7);

function summa2(arr) {
  var sum = 0;
   for(var i= 0; i <arr.length; i++){
     sum += arr[i];
   }
     return sum;

 }
//
var array = [6, 8, 1];
var array_2 = [6, 8, 1, 7];
var array_3 = [6, 8, 1, 90];
//
var res = summa2(array);
summa2(array_2);
summa2(array_3);
// console.log("результат" + res);
// var res2 = summa2(array_2);
// console.log(res2);
// var res3 = summa2(array_3);
// console.log(res3);

var num = 10;
var num2 = 10;

function info2() {
  var num = 20;
  console.log(num);
}
info2();
 console.log(num);
