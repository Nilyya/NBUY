'use strict';
let btnAdd = document.getElementById('btnAddNewTask');
let txtTaskName = document.getElementById('txtTaskName');
btnAdd.addEventListener('click', newTask);
txtTaskName.addEventListener('keypress', function(event){
    if (event.key=='Enter') {
        event.preventDefault();
        btnAdd.click();
    }
});

let notListesi=[
    { 'id': 1, 'notAdi': 'Not 1' },
    { 'id': 2, 'notAdi': 'Not 2' }, 
]
let ul = document.getElementById('task-list');
for (const not of notListesi) {
    let li = `
    <li class="task list-group-item">
    <div class="form-check">
        <label for="${not.id}">${not.notAdi}</label> 
        <div>           
        <button id="check" ><i class="fa-solid fa-square-check"></i></button>
        <button id="delete"><i class="fa-solid fa-trash-can"></i></button>
        </div> 
    </div>
   
</li>
    `;
    ul.insertAdjacentHTML('beforeend',li);
}


let plus = document.querySelector('#btnAddNewTask');
btnAdd.addEventListener('click', newTask);
function newTask(event){
    event.preventDefault();
    event.target.classList.add();
    event.target.style.display='none';
    console.log(event.target);
}
function newTask(event) {
    event.preventDefault();
    if (isFull(txtTaskName.value)) {
        if (!isEditMode) {            
            let id;
            if (notListesi.length == 0) {
                id = 1;
            } else {
                id = notListesi[notListesi.length - 1].id + 1;
            }
            notListesi.push(
                {
                    'id': id,
                    'notAdi': notAdi ,                    
                }
            );
        } 
    }
}   

function removeTask(id){
    let deleteId;
    for (const not in notListesi) {
      if (notListesi[notIndex].id==id) {
        deleteId=notIndex;
      }
    };
 notListesi.splice(deleteId,1)
 displayTasks();
}
function saveLocal() {
    localStorage.setItem('notListesi', JSON.stringify(gorevListesi));
}

displayTasks('all');