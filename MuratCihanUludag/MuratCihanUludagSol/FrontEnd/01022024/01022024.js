document.addEventListener("change", () => {
  let number1 = document.getElementById("number-1");
  let number2 = document.getElementById("number-2");
  let result = document.getElementsByTagName("p")[0];

  if (Number(number1.value) > Number(number2.value))
    result.innerText = "Sayi 1 buyuktur";
  else if (Number(number1.value) === Number(number2.value))
    result.innerText = "Sayilar esit";
  else result.innerText = "Sayi 2 buyuktur";
});

let backgroundChange = document.getElementById("backgorun-change");

backgroundChange.addEventListener("click", () => {
  let r = Math.floor(Math.random() * 256);
  let g = Math.floor(Math.random() * 256);
  let b = Math.floor(Math.random() * 256);

  document.body.style = `background: rgb(${r}, ${g}, ${b});`;
});

let xEksen = document.getElementById("x");
let yEksen = document.getElementById("y");

window.addEventListener("mousemove",(e)=>{
    xEksen.innerText = e.clientX;
    yEksen.innerText = e.clientY;
})

let text= document.querySelector("#text-custom");
let btn2 = document.getElementById("ara");
let inputAra = document.getElementById("input-ara");

btn2.addEventListener("click",()=>{

    let regex = new RegExp((inputAra.value).trim(),"gi")
    let orjinalText = text.innerText;
    
    const coloredText = orjinalText.replace(regex,c=>`<mark>${c}</mark>`)
    text.innerHTML = coloredText;
    alert(orjinalText.match(regex).length);
})
