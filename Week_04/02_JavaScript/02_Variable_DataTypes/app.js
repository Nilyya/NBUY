/*
EcmaScript
Değişkenler tanımlanırken üç farklı keyword kullanılabilir.
1)var
2)let
3)const(sabit)

-ES6 ile birlikte artık modern JavaScript tabiri kullanılmaya başlanmıştır. Bu süreçte let ve const kullanın,
var kullanmaktan kaçının.
-JS'te değişken tanılanırken Tip belirlenmez.
-Bu değişkenin tipi olmadığı anlamına gelmez.
-JS motoru bir değişkene değer ataması esnasında o değere göre tipi belirler.
-Eğer henüz bir değişkene değer atanmamışsa undefined olarak belirlenir.

*/

// let yas= 20;
// console.log(yas);
// let ad='geç kalan Sema';
// let soyad='Geç kalan Harun';
// console.log(ad);
// console.log(soyad);
// console.log(ad,soyad);

// let firstName='Serhat';
// let lastName='Kaya';
// console.log(firstName+''+lastName);


// let sayi1=15;
// let sayi2=25;
// let sayi3=35;

// let s1=15, s2=45, s3=55;
// let say1=25,
//     say2=55,
//     say3=48;


// let durum=true;

// sayi1=125;
// console.log(sayi1);

// let toplam=0;
// toplam=toplam + say1;
// const benimDogumYilim=1975;
// console.log('Benim doğum yılım:'+ benimDogumYilim);

/*
bildiğiniz değişken isimlendirme yöntemlerini burada da kullanabiliriz Değişkenler genellikle camelCase ile isimlendiririz
-Değişken isimler harf, rakam, $ ve_ olabilir.
-Değişken isimleri rakamla başlayamaz.
-Reserved Keyword'ler Değişken adı olarak kullanılamaz.

-Const sabit değerleri tutmak için kullanılır. Genellikle tamamen büyük harfle isimlendiririr.

*/
// const PI_SAYISI=3.14;
// const _PI_SAYISI=3.14;

// const RENK_1='Sarı';
// const RENK_2='Mavi';

//Data Types

//1-number
// let sayi1 = 100;
// console.log(sayi1);
// console.log(typeof sayi1);
// console.log(typeof(sayi1));

// let sayi2=17.5;
// console.log(sayi2, typeof sayi2);

// let sayi3= 25/0;
// console.log(sayi3, typeof(sayi3));

// let sayi4= 'okul'/25;
// console.log(sayi4, typeof(sayi4));

// let sayi5=56132146565484515465166484984589999999999999999999999999999999999999999951874n;
// console.log(sayi5, typeof(sayi5));

// let sayi6=sayi5*999999999999999999999999999999999999999999999999999n;
// console.log(sayi6, typeof(sayi6));

//string
/*
string ifadeler 3 faklı şekilde ifade edilebilir
1)Tek tırnakla('')
2)Çift tırnakla("")
3)Backticks(``)
*/

// let ad='"Engin"';
// let soyad='\'Niyazi\'';
// let adSoyad=ad + " " + soyad;
// console.log(adSoyad);

// let adres='Halitağa Mah.\n\tSütlü Nuriye Sok. Candaş Ap. No:21\n\tBeşiktaş';
// console.log(adres);

// let adSoyad= 'Aylin Aydemir';
// let yas=28;
// let kanGrubu='0Rh+';
// let kilo=59;
// let cinsiyet='Kadın';

// console.log('Sayın'+adSoyad+ ' '+ yas+ 'yaşınız.\nKilo:'+ kilo+'\nKan Grubu:'+kanGrubu+'\nCinsiyet'+cinsiyet+'\n\n\n');


// console.log(`Sayın ${adSoyad}, ${yas} yaşınız.
// Kilo:${kilo}
// `);

//Boolean
// let durum=true;
// console.log(durum ,typeof(durum));
// let ad='Halil';
// console.log(ad, typeof(ad));

//null,undefined
// let yas;
// yas=null;
// yas=12/0;
// console.log(yas, typeof(yas));

//JS CHAR diye bir tip yoktur!

//Convert data types
// let durum= false;
// console.log(durum, typeof durum);

// let metin='Durumunuz'+ durum+'şeklindedir.';
// console.log(metin, typeof metin);

// let drumMetin = String(durum);
// console.log(durumMetin, typeof durumMetin);

// let sayi= 25;
// let metin2= sayi+'yaşındasınız.';
// console.log(metin2, typeof metin2);
// let sayiMetin= String(sayi);
// console.log(sayiMetin, typeof sayiMetin);

// let metinSayi='455';
// console.log(metinSayi, typeof metinSayi);
// let metinSayiNumber= Number(metinSayi);
// console.log(metinSayıNumber, typeof metinSayıNumber);

// let sayiMetin='    455      ';
// console.log(sayiMetin, typeof sayiMetin);
// let sayi=Number(sayiMetin);
// console.log(sayi, typeof sayi);
//number-->2 üzeri 53-1

// let sayi= 1254n;
// console.log(sayi, typeof sayi);

// console.log(Number(true));
// console.log(Number(false));

// console.log(Boolean(0));
// console.log(Boolean(1));
// console.log(Boolean('0'));

let a;
// a='' + 1 +0; console.log(a,typeof a);
// a='' -1+ 0;console.log(a,typeof a);
// a=true+false;console.log(a,typeof a);
// a=6/'3';console.log(a,typeof a);
// a= 4+5+'px';console.log(a,typeof a);
// a='$'+4+5;console.log(a,typeof a);
// a='$'+(4+5);console.log(a,typeof a);
// a='4px'-2;console.log(a,typeof a);
// a='   -9   '+5;console.log(a,typeof a);
// a=null+1;console.log(a,typeof a);
// a=undefined+1;console.log(a,typeof a);