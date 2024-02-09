var a, b, c;
a = 3;
b = 4;
c = 5;
var enBuyuk = Math.max(a, b, c);

if (a === b && a === c)
  console.log(`%cUc sayida essittir`, "font-size:22px;color:blue;");
else console.log(`%c${enBuyuk}`, "font-size:22px;color:orange;");

let n = 100;
let toplamSayi = (n * (n + 1)) / 2;

console.log(toplamSayi);

for (let i = 1; i < 21; i++) {
  if (i % 3 == 0) console.log(`3 e bolunebilen = ${i}`);
  if (i % 5 === 0) console.log(`5 e bolunebilen = ${i}`);
}
var rastgele;
for (let i = 0; i < 11; i++) {
  rastgele = (Math.random() * 10).toFixed();
  console.log(rastgele);
}

var rastgeleDizi = [];

while (rastgeleDizi.length < 10) {
    let random = Math.floor(Math.random() * 10) + 1;
    if (!rastgeleDizi.includes(random)) rastgeleDizi.push(random);
}
console.log(rastgeleDizi);

function isMonoton(dizi) {
    for (let i = 0; i < dizi.length; i++) {
        if (dizi[i]< dizi[i-1]) return false
    }
    return true
}

console.log(`Monoton mu = ${isMonoton(rastgeleDizi)}`)

const AritmatikOrt = (dizi) => {
    var enBuyuk = Math.max(...dizi);
    var enKucuk = Math.min(...dizi);

    var enBuyukIndex = dizi.indexOf(enBuyuk);
    if (enBuyukIndex !== -1) dizi.splice(enBuyukIndex, 1);

    var enKucukIndex = dizi.indexOf(enKucuk);
    if (enKucukIndex !== -1) dizi.splice(enKucukIndex, 1);

    console.log(`En buyuk ve en kucuk elaminin cikmis hali : ${dizi}`);

    let toplam = dizi.reduce((acc, curr) => acc + curr, 0);
    let ortalama = toplam / dizi.length
    return ortalama;
}

console.log(AritmatikOrt(rastgeleDizi));


const  Words = (text) => {
    console.log(text.split(/\s+/))
}
Words("merhaba   Dunya asdasd    asdasd lorem ipsum")