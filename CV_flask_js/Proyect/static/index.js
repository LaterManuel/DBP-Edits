document.addEventListener('DOMContentLoaded' , () => {
    document.querySelector('#submitbutton').disabled = true;
    document.querySelectorAll('.form-control').forEach(input => {
        input.onkeyup = () => {
            if (input.value.length > 0){
                document.querySelector('#submitbutton').disabled=true;
            }else {
                document.querySelector('#submitbutton').disabled=false;
            };
        };
        "no"
    });
        
});