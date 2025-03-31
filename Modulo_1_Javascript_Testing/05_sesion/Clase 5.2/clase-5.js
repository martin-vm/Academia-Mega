/*
const titulo = document.getElementById("titulo");
const parrafos = document.getElementsByClassName("mensaje");
const botones = document.getElementsByTagName("button");

const primerParrafo = document.querySelector(".mensaje");
const todosLosParrafos = document.querySelectorAll(".mensaje");

titulo.textContent = "Bienvenidos a mi página web";
titulo.style.color = "blue"

primerParrafo.innerHTML = "<strong>Texto en Negritas</strong>";*/

document.getElementById("cambiarTexto").addEventListener("click",function(){
    document.getElementById("titulo").textContent = "Texto cambiado con Javascript";
});

document.getElementById("boton").addEventListener("click", function(){
    document.getElementById("resultado").textContent = "Botón Seleccionado";
});

/*
const hoverTexto = document.getElementById("hoverTexto");

hoverTexto.addEventListener("mouseover", function(){
    hoverTexto.style.color = "red";
});

hoverTexto.addEventListener("mouseout", function(){
    hoverTexto.style.color = "black";
});*/

const hoverDiv = document.getElementById("hoverDiv");

hoverDiv.addEventListener("mouseover", function(){
    hoverDiv.style.backgroundColor = "red";
});


hoverDiv.addEventListener("mouseout", function(){
    hoverDiv.style.backgroundColor = "white";
});