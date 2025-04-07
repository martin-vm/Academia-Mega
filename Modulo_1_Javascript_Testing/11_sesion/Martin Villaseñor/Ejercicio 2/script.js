document.getElementById("testForm").addEventListener("submit", function(e){
    e.preventDefault();

    const nombre = document.getElementById("nombre").value.trim();
    const edad = document.getElementById("edad").value.trim();
    const resultado = document.getElementById("resultado");

    try {
        validarDatos(nombre, edad);
        resultado.text
    } catch (error) {
        console.log("Error:", error);
        resultado.textContent = error.message;
        resultado.style.color = "red";
    }

    console.log(nombre, edad);
});

function validarDatos(nombre, edad){
    console.log("Validando datos...");

    if(!nombre || edad <= 0){
        throw new Error("Por favor completa todos los campos");
    }

    if(edad <= 0){
        throw new Error("La edad debe ser un número válido");
    }

    if(nombre.length > 30){
        throw new Error("El nombre es demasiado largo");
    }

}