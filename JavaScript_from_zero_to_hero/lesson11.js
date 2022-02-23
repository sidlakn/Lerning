var counter = 0;

function onClickButton(el) {
counter++;
el.innerHTML = "ви натиснули на кнопку: " + counter;
// el.style.background = "black";
// el.style.color = "white";

el.style.cssText = "border-radius: 5px; border: 0; font-size: 20px;";

}

function onInput(el) {
  if(el.value == "hello"){

    alert("і тобі привіт");
  }
  console.log(el.value);

}
