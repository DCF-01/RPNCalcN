let btn = document.querySelectorAll('li');
let dataElements = document.querySelectorAll('.d-contain')

btn.forEach(x => {
    x.addEventListener('click', e => fetchData(e))
})

function fetchData(event){
    fetch(`${window.location.origin}/home/calc?op=${encodeURIComponent(event.target.innerHTML)}`)
        .then((response) => response.json())
        .then((data) => {
            /*for(let i = 0; i < 4; i++){
                dataElements[i].innerHTML = data.result[i].length !== 0 ? data.result[i] : 0;
            }*/
            
            dataElements[3].innerHTML = data.result[0].length !== 0 ? data.result[0] : 0;
            dataElements[2].innerHTML = data.result[1].length !== 0 ? data.result[1] : 0;
            dataElements[1].innerHTML = data.result[2].length !== 0 ? data.result[2] : 0;
            dataElements[0].innerHTML = data.result[3].length !== 0 ? data.result[3] : 0;
        });
}