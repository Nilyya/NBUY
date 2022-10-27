//while
// let i=0;
// while (i<10) {
//     i++;
//     console.log(i+ '.JavaScript');    
// }

//do while
// let i=0;
//  do {
//     i++;
//     console.log(i+'.JS');
//  } while (i<10);

// for (let i = 0; i < 10; i++) {
//     console.log(i+'.JavaScript');    
// }

//1-10 arasındaki sayıları toplayıp consola yazdırın.
// let toplam=0;
// let i=1;
// while (i<=10) {
//     toplam +=i;
//     i++;
// }
// console.log('While ile toplam:' + toplam);

// let toplam2 =0;
// for (let i = 1; i <= 10; i++) {
//    toplam2 +=i;
    
// }
// console.log('For ile:' + toplam2);

//Kullanıcının gireceği üç sayının toplamını for kullanarak

//let sayi= [prompt('Lütfen sayı giriniz:'),prompt('Lütfen sayı giriniz:'),prompt('Lütfen sayı giriniz:')];
// toplam=0;
// let girilenSayi;
// for (let i = 1; i <= 3; i++) {
//     girilenSayi=Number(prompt(i+'.sayi:'));
//     toplam+=girilenSayi;
    
// }
// console.log('Toplam:'+toplam);14

// let toplam=0;
// let girilenSayi;
// let i=1;
// do {
//     girilenSayi=Number(prompt(i + '.sayı:'));
//     toplam += girilenSayi;
//     i++;
// } while (girilenSayi != 0);
// console.log('Toplam:'+ toplam);

// let toplam=0;
// let girilenSayilar=[];
// let i=0;
// do {
//     girilenSayilar[i]=Number(prompt(i+1 + '.sayı:'));
//     toplam += girilenSayilar[i];
//     i++;
// } while (girilenSayilar[i-1] != 0);
// girilenSayilar.pop();
// console.log('Toplam:'+ toplam);
// for (let i = 0; i < girilenSayilar.length; i++) {
//    console.log(i+' '+'Sayı:\t'+ girilenSayilar[i]);  
// }




let sayilar= [];
let i=0;
do {
    sayi=Number(prompt(i+ 1 + '.sayı:'));
    i++;   
} while (sayilar[i-1] !=0);
sayilar.pop();
let sonucDizi= [];
let cevap = prompt=('Tek mi çift mi?');
if (cevap.toLocaleLowerCase()=='tek') {
    tur='tek';
for (let i = 0; i < array.length; i++) {
   if (sayilar[i] %2===1) {
    sonucDizi.push(sayilar[i]);
    toplam += sayilar[i];    
}    
}
}
else if (cevap.toLocaleLowerCase()=='çift') {
    tur='cift';
    for (let i = 0; i < array.length; i++) {
        if (sayilar[i] %2===0) {
         sonucDizi.push(sayilar[i]); 
         toplam += sayilar[i];   
     }      
    }
} 
else{
    console.log('Lütfen "Tek" ya da "Çift" yaz! ');
}
console.log(sayilar);
console.log(tur +'Sayılar' +sonucDizi);