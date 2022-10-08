document.addEventListener('DOMContentLoaded',()=>{
    var socket = io();
    socket.on('connect', function() {
        document.querySelectorAll("button").forEach(button =>{
            button.onclick =() => {
                const vote = button.dataset.vote;
                socket.emit('send',{"vote":vote});
            };
        } )
    });
})

