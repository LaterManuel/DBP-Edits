from socket import socket
from flask import Flask, render_template
from flask_socketio import SocketIO

app = Flask(__name__)
app.config['SECRET_KEY'] = 'secret!'
socketio = SocketIO(app)

@app.route("/")
def index():
    return render_template("index.html")
@socketio.on('send')
def handle_message(data):
    print(data)
    #selection = data["vote"]
    #emit("announce", {"selection": selection}, broadcast=True)
if __name__ == '__main__':
    socketio.run(app)