var number = 15;
var isHasHouse = true;

if(number == 5 && isHasHouse == true) {
  console.log("Ok");
} else if(number < 10) {
console.log("yes");
} else if(number == 7) {
console.log("7");
} else if(number >= 15) {
  console.log(">=15");
}else {
  console.log("error;");
}

var stroka = "word";
switch(stroka) {
  case "4":
   console.log("змінна зі значенням 4");
  break;
  case "45":
   console.log("змінна зі значенням 45");
  break;
  case "word":
   console.log("змінна зі значенням word");
  break;
  default:
  console.log("Default");
  break;
}
