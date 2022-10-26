let ders= 'Bahçeşehir Üniversitesi Wissen Akademie Iğdır';
let sonuc;

sonuc= ders.toLocaleLowerCase();
sonuc=ders.toLowerCase();
sonuc=ders.toUpperCase();
sonuc=ders.toLocaleUpperCase();

sonuc=ders.length;
sonuc=ders[0];
sonuc=ders[29];
sonuc=ders[44];

sonuc= ders.slice(0,10);
sonuc=ders.slice(10);

sonuc=ders.substring(0,10);
sonuc=ders.substring(20,5);
sonuc=ders.substring(20,25);
sonuc=ders.substring(25,20);

sonuc=ders.replace('Iğdır','Istanbul');
sonuc=ders.replace(' ','-');

sonuc=ders.trim();
sonuc=ders.trimStart();
sonuc=ders.trimEnd();

sonuc=ders.indexOf('A');
sonuc=ders.toLocaleUpperCase().indexOf('A');

sonuc=ders.split(' ');
//console.log(sonuc[3]);

//Kullanıcının girdiği bir cümlenin kaç sözcükten oluştuğunu bulunuz.
// let cumle= prompt('Lütfen cümle giriniz:');
// let sozcukDizisi= cumle.split('');
// console.log(sozcukDizisi.length);

sonuc=ders.includes('Akademie');
sonuc=ders.startsWith('H');
sonuc=ders.endsWith('r'); 
console.log(ders);
console.log(sonuc);
