var counter = 0;

var id = setInterval(my_func, 1000);

// var counter2 = 0;
function my_func() {
  counter++;
  console.log("Counter:" + counter);

  if(counter == 3)
  clearInterval(id);

}


setInterval(function() {
  counter++;
console.log("пройшло секунд: " + counter);
}, 1000);


setTimeout(function () {
  
  console.log("Timer is Working");
}, 2000);
