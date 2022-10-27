// function selamVer() {
//     console.log('Merhaba JS');
// }

// selamVer();
// function selamVer(isim='Dünya') {
//     console.log('Merhaba ' + isim);
// }
// selamVer('Engin');
// selamVer('Zeynep');
// selamVer();

// function yasHesapla(dogumYili) {
//      return new Date().getFullYear()-dogumYili
// }
//  console.log( yasHesapla(1975));
//  let yas = yasHesapla(2000);
//  if (yas<30) {
//     console.log('Yaşınız uygun');
//  }else{
//     console.log('Çok gençsin');
//  }

//Bir tutar bilgisi alıp, bu tutarın kdv sini hesaplayalım
// function kdvHesapla(tutar) {
//     let sonuc=tutar*0.18;
//     sonuc=sonuc.toFixed(2);
//     return sonuc;
// }
// console.log(kdvHesapla(117));

// function kdvHesapla() {
//  for (let i = 0; i < arguments.length; i++) {
//    console.log(arguments[i]*0.18);
  
//  } 
// }

// kdvHesapla(100, 200, 1000);
//Kendisine gönderilecek tutar bilgilerini kullanarak kdvleri hesaplayıp, geriye hesaplanmış kdv'leri içinde barındıran bir dizi döndüren 
function kdvHesapla() {
        let sonuc=[];
        let kdv=0;
        for (let i = 0; i < arguments.length; i++) {
            kdv=arguments[i]*0.18;
            kdv=kdv.toFixed(2);
            sonuc.push(kdv);
            
        }
        return sonuc;
}
console.log(kdvHesapla(100,450,7800));