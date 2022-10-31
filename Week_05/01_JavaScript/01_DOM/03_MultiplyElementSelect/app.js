let sonuc;
//getElementByClassName
sonuc= document.getElementsByClassName('card-header');
sonuc= document.getElementsByClassName('task');
sonuc= document.getElementsByClassName('task')[0].innerText;
sonuc= document.getElementsByClassName('task')[2].innerText;
sonuc= document.getElementsByClassName('task');
// for (let i = 0; i < sonuc.length; i++) {
//     console.log(sonuc[i].innerText);    
// }
let taskList= document.getElementsByClassName('task');

// for (const task of taskList) {
//     task.color='red';
//     task.fontSize='60px';
//     task.innerText='ITEM';
// }
let taskList2 = document.getElementById('task-list-2');//Geriye tek bir eleman döndürür,yukardan aşağı ilk karşılaştığını
// sonuc=taskList2.getElementsByClassName('task');
sonuc= taskList2.getElementsByTagName('li');

sonuc= document.querySelectorAll('#task-list-2 li');//Geriye birden çok sonuç döndürür.
for (const task of sonuc){
task.style.backgroundColor='navy';

}
console.log(sonuc);