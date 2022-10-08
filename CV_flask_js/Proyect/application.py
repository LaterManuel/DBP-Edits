import email
from flask import Flask, render_template, request

app = Flask(__name__)

@app.route("/")
def index():
    return render_template("form.html")
@app.route("/hello", methods=["POST"])
def hello():
    name= request.form.get("name")
    number= request.form.get("number")
    email= request.form.get("email")
    location= request.form.get("location")
    user=request.form.get("userL")
    perfil=request.form.get("dataperfil")
    nacion=request.form.get("nacionalidad")
    test=request.form.getlist("lenguages")
    ingles=request.form.get("ingles")
    date=request.form.get("date")
    apt=request.form.get("dataAp")
    listapt=[]
    start=0
    texto=""
    for i in apt:
        texto=texto+i
        if i==".":
            listapt.append(texto)
            texto=""
    
    return render_template("index.html",nombre=name,numero=number,correo=email,ubicacion=location,usuarioL=user,perfil=perfil,nacion=nacion,test=test,ingles=ingles,longitud=len(test),fecha=date,apt=apt,longapt=len(listapt),listapt=listapt)
    