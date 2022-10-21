document.addEventListener('DOMContentLoaded' , () => {
    document.querySelector('#submitbutton').disabled = true;
    let input = document.querySelector(".form-control");
    let button = document.querySelector("#submitbutton");
    button.disabled = true;
    input.addEventListener("change", stateHandle);
    function stateHandle() {
        if(document.querySelector(".form-control").value === "") {
            button.disabled = true;
        } else {
            button.disabled = false;
        }
    };
        
});