let intentos = 0;
let intentosMaximos = 3;
let claveCorrecta = "1234";
let claveIngresada;

while (intentos < intentosMaximos) {
    let intentosRestantes = intentosMaximos - intentos - 1;
    claveIngresada = prompt("Ingresa la contrase\u00F1a");
    
    if (claveIngresada === claveCorrecta) {
        console.log("Acceso concedido");
        break;
    } else {
        intentos++;
        if (intentos < intentosMaximos) {
            console.log(`Contrase\u00F1a incorrecta, te queda(n) ${intentosRestantes} intento(s)`);
        }
    }
}

if (intentos === intentosMaximos) {
    console.log("Has agotado tus intentos");
}