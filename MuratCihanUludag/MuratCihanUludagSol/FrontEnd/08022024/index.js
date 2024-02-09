document.body.innerHTML = ` 
<div>
<header id="Baslik">
  <div class="w3-container">
      <h1>
         <b>YURT DIŞI TURLARI </b>
      </h1>
      <!-- Menümüz -->
  <div class="w3-section w3-bottombar">
         <a class="w3-button w3-black" href="Index.html">ANASAYFA </a>
         <a class="w3-button w3-white" href="Yilbasi.html">YILBAŞI TURLARI </a>
         <a class="w3-button w3-white" href="Seker.html">SEKER BAYRAMI TURLARI </a>
         <a class="w3-button w3-white" href="Kurban.html">KURBAN BAYRAMI TURLARI </a>
         <a class="w3-button w3-blue" href="Hesaplama.html">FİYAT HESAPLA </a>
  </div>
  </div>
</header>
<!-- Ana yılbaşındaki tur/lar olacak -->
<div class="w3-third w3-container w3-margin-bottom">
<img src="./Resimler/alaska.jpg" alt="Alaska" style="width: 100%;" class="w3-hover-opacity">
<div class="w3-container w3-white">
  <!-- Tur ile ilgili açıklamaların olduğu bölüm -->
   <p><b>Alaska</b></p>
   <p>Balık ve Huzur! <br>Sessizlik! </p>
</div>
</div>

<div class="w3-third w3-container w3-margin-bottom">
  <img src="./Resimler/kahve.jpg" alt="Brezilya" style="width: 100%;" class="w3-hover-opacity">
  <div class="w3-container w3-white">
    <!-- Tur ile ilgili açıklamaların olduğu bölüm -->
     <p><b>Brezilya</b></p>
     <p>Karnaval! <br>kahve! </p>
  </div>
  </div>

  <div class="w3-third w3-container w3-margin-bottom">
      <img src="./Resimler/boz.jpg" alt="Brezilya" style="width: 100%;" class="w3-hover-opacity">
      <div class="w3-container w3-white">
        <!-- Tur ile ilgili açıklamaların olduğu bölüm -->
         <p><b>Kanada-Montreal</b></p>
         <p>Vahşi Doğa! <br>Kar! </p>
      </div>
      </div>
<div class="w3-center">
  <div class="w3-bar">
      <a href="" class="w3-bar-item w3-button w3-hover-black"> « </a>
      <a href="" class="w3-bar-item w3-button w3-hover-black"> 1 </a>
      <a href="" class="w3-bar-item w3-button w3-hover-black"> 2</a>
      <a href="" class="w3-bar-item w3-button w3-hover-black"> 3 </a>
      <a href="" class="w3-bar-item w3-button w3-hover-black"> 4 </a>
      <a href="" class="w3-bar-item w3-button w3-hover-black"> 5 </a>
      <a href="" class="w3-bar-item w3-button w3-hover-black"> » </a>
  </div>

 </div>
</div>`;

function header (index,Yilbasi,seker,kurban){
    return `        
    <header id="Baslik">
        <div class="w3-container">
            <h1>
               <b>YURT DIŞI TURLARI </b>
            </h1>
            <!-- Menümüz -->
            <div class="w3-section w3-bottombar">
               <a class="w3-button w3-${index}" href="Index.html">ANASAYFA </a>
               <a class="w3-button w3-${Yilbasi}" href="Yilbasi.html">YILBAŞI TURLARI </a>
               <a class="w3-button w3-${seker}" href="Seker.html">SEKER BAYRAMI TURLARI </a>
               <a class="w3-button w3-${kurban}" href="Kurban.html">KURBAN BAYRAMI TURLARI </a>
               <a class="w3-button w3-blue" href="Hesaplama.html">FİYAT HESAPLA </a>
            </div>
        </div>
  </header>`
}

function dinamikPage(href) {
  switch (href) {
    case "Index.html":
      document.body.innerHTML = ` 
        <div>
        ${header("black","white","white","white")}
        <!-- Ana yılbaşındaki tur/lar olacak -->
        <div class="w3-third w3-container w3-margin-bottom">
        <img src="./Resimler/alaska.jpg" alt="Alaska" style="width: 100%;" class="w3-hover-opacity">
        <div class="w3-container w3-white">
          <!-- Tur ile ilgili açıklamaların olduğu bölüm -->
           <p><b>Alaska</b></p>
           <p>Balık ve Huzur! <br>Sessizlik! </p>
        </div>
        </div>
        
        <div class="w3-third w3-container w3-margin-bottom">
          <img src="./Resimler/kahve.jpg" alt="Brezilya" style="width: 100%;" class="w3-hover-opacity">
          <div class="w3-container w3-white">
            <!-- Tur ile ilgili açıklamaların olduğu bölüm -->
             <p><b>Brezilya</b></p>
             <p>Karnaval! <br>kahve! </p>
          </div>
          </div>
        
          <div class="w3-third w3-container w3-margin-bottom">
              <img src="./Resimler/boz.jpg" alt="Brezilya" style="width: 100%;" class="w3-hover-opacity">
              <div class="w3-container w3-white">
                <!-- Tur ile ilgili açıklamaların olduğu bölüm -->
                 <p><b>Kanada-Montreal</b></p>
                 <p>Vahşi Doğa! <br>Kar! </p>
              </div>
              </div>
        <div class="w3-center">
          <div class="w3-bar">
              <a href="" class="w3-bar-item w3-button w3-hover-black"> « </a>
              <a href="" class="w3-bar-item w3-button w3-hover-black"> 1 </a>
              <a href="" class="w3-bar-item w3-button w3-hover-black"> 2</a>
              <a href="" class="w3-bar-item w3-button w3-hover-black"> 3 </a>
              <a href="" class="w3-bar-item w3-button w3-hover-black"> 4 </a>
              <a href="" class="w3-bar-item w3-button w3-hover-black"> 5 </a>
              <a href="" class="w3-bar-item w3-button w3-hover-black"> » </a>
          </div>
        
         </div>
        </div>`;
      break;
    case "Yilbasi.html":
      document.body.innerHTML = ` 
        <div>
        ${header("white","black","white","white")}
        <!-- Ana yılbaşındaki tur/lar olacak -->
        <div class="w3-third w3-container w3-margin-bottom">
        <img src="./Resimler/alaska.jpg" alt="Alaska" style="width: 100%;" class="w3-hover-opacity">
        <div class="w3-container w3-white">
          <!-- Tur ile ilgili açıklamaların olduğu bölüm -->
           <p><b>Alaska</b></p>
           <p>Balık ve Huzur! <br>Sessizlik! </p>
        </div>
        </div>
        
        <div class="w3-third w3-container w3-margin-bottom">
          <img src="./Resimler/norvec.jpg" alt="Brezilya" style="width: 100%;" class="w3-hover-opacity">
          <div class="w3-container w3-white">
            <!-- Tur ile ilgili açıklamaların olduğu bölüm -->
             <p><b>Brezilya</b></p>
             <p>Karnaval! <br>kahve! </p>
          </div>
          </div>
        
          <div class="w3-third w3-container w3-margin-bottom">
              <img src="./Resimler/boz.jpg" alt="Brezilya" style="width: 100%;" class="w3-hover-opacity">
              <div class="w3-container w3-white">
                <!-- Tur ile ilgili açıklamaların olduğu bölüm -->
                 <p><b>Kanada-Montreal</b></p>
                 <p>Vahşi Doğa! <br>Kar! </p>
              </div>
              </div>
        <div class="w3-center">
          <div class="w3-bar">
              <a href="" class="w3-bar-item w3-button w3-hover-black"> « </a>
              <a href="" class="w3-bar-item w3-button w3-hover-black"> 1 </a>
              <a href="" class="w3-bar-item w3-button w3-hover-black"> 2</a>
              <a href="" class="w3-bar-item w3-button w3-hover-black"> 3 </a>
              <a href="" class="w3-bar-item w3-button w3-hover-black"> 4 </a>
              <a href="" class="w3-bar-item w3-button w3-hover-black"> 5 </a>
              <a href="" class="w3-bar-item w3-button w3-hover-black"> » </a>
          </div>
        
         </div>
        </div>`;
      break;
    case "Seker.html":
      document.body.innerHTML = ` 
        <div>
        ${header("white","white","black","white")}
        <!-- Ana yılbaşındaki tur/lar olacak -->
        <div class="w3-third w3-container w3-margin-bottom">
        <img src="./Resimler/norvec.jpg" alt="Alaska" style="width: 100%;" class="w3-hover-opacity">
        <div class="w3-container w3-white">
          <!-- Tur ile ilgili açıklamaların olduğu bölüm -->
           <p><b>Alaska</b></p>
           <p>Balık ve Huzur! <br>Sessizlik! </p>
        </div>
        </div>
        
        <div class="w3-third w3-container w3-margin-bottom">
          <img src="./Resimler/lights.jpg" alt="Brezilya" style="width: 100%;" class="w3-hover-opacity">
          <div class="w3-container w3-white">
            <!-- Tur ile ilgili açıklamaların olduğu bölüm -->
             <p><b>Brezilya</b></p>
             <p>Karnaval! <br>kahve! </p>
          </div>
          </div>
        
          <div class="w3-third w3-container w3-margin-bottom">
              <img src="./Resimler/boz.jpg" alt="Brezilya" style="width: 100%;" class="w3-hover-opacity">
              <div class="w3-container w3-white">
                <!-- Tur ile ilgili açıklamaların olduğu bölüm -->
                 <p><b>Kanada-Montreal</b></p>
                 <p>Vahşi Doğa! <br>Kar! </p>
              </div>
              </div>
        <div class="w3-center">
          <div class="w3-bar">
              <a href="" class="w3-bar-item w3-button w3-hover-black"> « </a>
              <a href="" class="w3-bar-item w3-button w3-hover-black"> 1 </a>
              <a href="" class="w3-bar-item w3-button w3-hover-black"> 2</a>
              <a href="" class="w3-bar-item w3-button w3-hover-black"> 3 </a>
              <a href="" class="w3-bar-item w3-button w3-hover-black"> 4 </a>
              <a href="" class="w3-bar-item w3-button w3-hover-black"> 5 </a>
              <a href="" class="w3-bar-item w3-button w3-hover-black"> » </a>
          </div>
        
         </div>
        </div>`;
      break;
    case "Kurban.html":
      document.body.innerHTML = ` 
        <div>
        ${header("white","white","white","black")}
        <!-- Ana yılbaşındaki tur/lar olacak -->
        <div class="w3-third w3-container w3-margin-bottom">
        <img src="./Resimler/alaska.jpg" alt="Alaska" style="width: 100%;" class="w3-hover-opacity">
        <div class="w3-container w3-white">
          <!-- Tur ile ilgili açıklamaların olduğu bölüm -->
           <p><b>Alaska</b></p>
           <p>Balık ve Huzur! <br>Sessizlik! </p>
        </div>
        </div>
        
        <div class="w3-third w3-container w3-margin-bottom">
          <img src="./Resimler/kahve.jpg" alt="Brezilya" style="width: 100%;" class="w3-hover-opacity">
          <div class="w3-container w3-white">
            <!-- Tur ile ilgili açıklamaların olduğu bölüm -->
             <p><b>Brezilya</b></p>
             <p>Karnaval! <br>kahve! </p>
          </div>
          </div>
        
          <div class="w3-third w3-container w3-margin-bottom">
              <img src="./Resimler/waterfalls.jpg" alt="Brezilya" style="width: 100%;" class="w3-hover-opacity">
              <div class="w3-container w3-white">
                <!-- Tur ile ilgili açıklamaların olduğu bölüm -->
                 <p><b>Kanada-Montreal</b></p>
                 <p>Vahşi Doğa! <br>Kar! </p>
              </div>
              </div>
        <div class="w3-center">
          <div class="w3-bar">
              <a href="" class="w3-bar-item w3-button w3-hover-black"> « </a>
              <a href="" class="w3-bar-item w3-button w3-hover-black"> 1 </a>
              <a href="" class="w3-bar-item w3-button w3-hover-black"> 2</a>
              <a href="" class="w3-bar-item w3-button w3-hover-black"> 3 </a>
              <a href="" class="w3-bar-item w3-button w3-hover-black"> 4 </a>
              <a href="" class="w3-bar-item w3-button w3-hover-black"> 5 </a>
              <a href="" class="w3-bar-item w3-button w3-hover-black"> » </a>
          </div>
        
         </div>
        </div>`;
      break;
    case "Hesaplama.html":
      document.body.innerHTML = ` 
          <!-- İçerik -->
          `;
      break;
    default:
      break;
  }
}

var links;

function LinkAdd() {
  links = document.querySelectorAll(".w3-section.w3-bottombar a");
  console.log(links)
  links.forEach((link) => {
    link.addEventListener("click", (e) => {
      e.preventDefault();
      let href = link.getAttribute("href");
      dinamikPage(href);
      LinkAdd();
    });
  });
}
LinkAdd();
