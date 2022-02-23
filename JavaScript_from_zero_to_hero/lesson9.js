alert(" яка класна погода сьогодні");
 var data = confirm("чайок зробили?");
if(data) {
  alert("ви молодець");
} else {
  alert("не пасує");
}

var data2 = prompt("вкажіть скільки вам років");
console.log(data2 , 20);

var person = null;
if(confirm("ви точно впевненні?")) {
  person = prompt("введіть ваше ім'я");
  alert("привіт, " + person);
} else {
  alert("ви натиснула відміна");
}
