//Prompt aracılığı ile kullanıcıdan bir saniye değeri alın. Örneğin 1500. Ardından bu girilen değerin kaç dakika, kaç saniye olduğunu hesaplayıp konsola düzgün bir şekilde yazdırın.
//Örnek sonuç: 
//Girilen değer: 1270
//Sonuç: 21 dakika 10 saniye


let saniye=parseInt(prompt ('Saniye:'));

let dakika=parseInt(saniye / 60);
saniye = saniye % 60;
console.log(dakika+' '+'dakika'+ saniye+ 'saniye');

