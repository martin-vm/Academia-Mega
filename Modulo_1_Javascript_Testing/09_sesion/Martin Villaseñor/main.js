import { sumar , restar , dividir , multiplicar } from "./operaciones.js";
import { obtenerFechaActual  , obtenerHoraActual } from "./fecha.js"


console.log(sumar(2,3));
console.log(restar(2,3));
console.log(multiplicar(2,3));
console.log(dividir(2,0));


console.log("Fecha Actual: " , obtenerFechaActual() );
console.log("Hora Actual: " , obtenerHoraActual() );