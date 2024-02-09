const ConsoleAnimation = () =>{
    console.clear();
    var r=((Math.random()*1000) % 255);
    var g =((Math.random()*1000) % 255);
    var b = ((Math.random()*1000) % 255);

    var br=((Math.random()*1000) % 255);
    var bg =((Math.random()*1000) % 255);
    var bb = ((Math.random()*1000) % 255);

    var css = `
    color:rgb(${r},${g},${b});
    font-size:73px;
    font-weight:600;  
    font-family: cursive;
    border-bottom:12px solid rgb(${br},${bg},${bb});
    `

    console.log("%cDers 6 ya hosgeldiniz",css)
}
setInterval(c=>{
    ConsoleAnimation()
},500)