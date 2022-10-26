// let urunler =[];
// urunler[0]='Samsung S21';
// urunler[1]='IPhone 12';
// urunler[123]='Bilgisayar'

// let urunler=['IPhone 13', 'IPhone XR','Dell X5'];
// let fiyatlar=[150000,15600,45000];
// let renkler=['gold','gri','lacivert'];

// urunler.forEach((urun, i)=>{
//     console.log(urun, fiyatlar[i], renkler[i]);
// });


// console.log(urunler);
// console.log(fiyatlar);
// console.log(renkler);


// let urun1 =[];
// urun1[0]='IPhone 13';
// urun1[1]=25000;
// urun1[2]='gold';
// urun1[3]=true;

// let urun2 =['Dell X5', '45000','Sarı',false];
// let urun3 =['Samsung S22', '35000','kırmızı',true];

// let urunler=[urun1, urun2, urun3]
// console.log(urun1, typeof urun1);
// console.log(urun2, typeof urun2);
// console.log(urun3, typeof urun3);
// console.log(urunler, typeof urunler);

// let urun1='IPhone 13, 25000, yeşil, true';
// let urun1Dizi=urun1.split(',');
// console.log(urun1Dizi, typeof urun1Dizi);

let ogrenciler=['Cemre','Melahat','Sema','Hasancan'];
let sonuc;
// sonuc=ogrenciler.length;
// sonuc=ogrenciler;
// sonuc=ogrenciler.toString();
// sonuc=ogrenciler.join('/');

ogrenciler[4]='Serhat';
ogrenciler.push('Aylin');
ogrenciler.pop();

sonuc=ogrenciler.push('Aylin');
sonuc=ogrenciler.pop();

sonuc=ogrenciler.unshift('Aylin');

console.log(ogrenciler);
console.log(sonuc);
