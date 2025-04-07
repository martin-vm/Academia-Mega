export function sumar(a = 0,b = 0){       
    let resultado = a+b;
    return `La suma de ${a} + ${b} es ${resultado}`
 }
export function restar(a = 0,b = 0){        
    let resultado = a-b;
    return `La resta de ${a} - ${b} es ${resultado}`

}
export function dividir(a = 0,b = 0){        
    if (b===0){
        return `La división de ${a} / ${b} no es posible, ya que b vale 0`;
    }

    let resultado = a/b;
    return `La división de ${a} / ${b} es ${resultado}`

}
export function multiplicar(a = 0,b = 0){        
    let resultado = a*b;
    return `La multiplicación de ${a} * ${b} es ${resultado}`
}