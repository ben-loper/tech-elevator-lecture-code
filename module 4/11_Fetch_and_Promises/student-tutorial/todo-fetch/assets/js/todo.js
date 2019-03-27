

document.addEventListener('DOMContentLoaded', () => {

    fetch('data.json')
    .then((response) => {
        return response.json();
    })
    .then((jsonObjects) => {
        const todoList = document.querySelector('ul');

        jsonObjects.forEach(jsonObject => {
            const liNode = document.createElement('li');
            liNode.innerText = jsonObject[`task`];
            
            checkMarkNode = document.createElement('i');
            checkMarkNode.classList.add('far');
            checkMarkNode.classList.add('fa-check-circle');

            liNode.insertAdjacentElement('beforeend', checkMarkNode);

            if(jsonObject[`completed`]){
                liNode.classList.add(`todo-completed`);
                checkMarkNode.classList.add('completed');
            }

            todoList.insertAdjacentElement('beforeend', liNode);
        });
    })
});