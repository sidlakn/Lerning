for(var i = 0; i <= 10; i++) {
console.log(i);
}
for(var i = 100; i > 5; i/= 2) {
console.log(i);
}

while (j < 10) {
console.log(j);
j++;
}
var j = 1000;
while (j > 100) {
console.log(j);
j -= 100;
}

// var isHasCar = true;
// while (isHasCar) {
// console.log(isHasCar);
// }


  var x = 100;
  do{
    console.log(x);

  } while (x < 50);
    for(var i = 10; i <=20; i +=2) {
if(i > 15)
     break;

     console.log(i);
    }


for(var i = 10000; i <=20; i++) {
if(i % 2 == 0)
      continue;

      console.log(i);
    }


  var arr = [5, 7, 3, 8, 91, "stroka"];

for(var i=0; i<arr.length; i++){
arr[i] *=2;

   // console.log("елемент " + (i + 1) ": ", +arr[i]);
   console.log( (i + 1),arr[i]);
}
