var text = document.getElementById('text');
text.title="new text"
console.log(text.title);

text.style.color ="red";
text.style.backgroundColor ="black";


text.innerHTML = "New<br>string";

document.getElementById('text').style.color = "white";

var spans = document.getElementsByTagName('span');
for(var i=0; i <spans.length; i++){
  console.log(spans[i].innerHTML);
}

var spans2 = document.getElementsByClassName('simple-text');
for(var i=0; i <spans2.length; i++){
  console.log(spans2[i].innerHTML);
}


function checkForm(el) {


  var name = el.name.value;
  var pass = el.pass.value;
  var repass = el.repass.value;
  var state = el.state.value;

  var fail = "";

if(name == "" || pass == "" || state == "")
fail = "заповніть всі поля";
else if(name.length <= 1 || name.length > 50)
fail = "введіть коректне ім'я";
else if(pass != repass)
fail = "паролі не співпадають";
else if(pass.split("&").length > 1)
fail = "не коректний пароль";

if(fail != "") {
document.getElementById('error').innerHTML = fail;

  return false;
} else {
   alert("всі дані коректно заповненні");
window.location.replace("https://www.google.com.ua/search?q=" + name  );
 }
return false;
}
