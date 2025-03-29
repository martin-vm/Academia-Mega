//Closure
const contador = () => {
    let cuenta = 0;
    return () => {
        cuenta++;
        return cuenta;
    };
};

const incrementar = contador();

console.log(incrementar());
console.log(incrementar());
console.log(incrementar());
console.log(incrementar());
console.log(incrementar());
console.log(incrementar());


//Multiplicador
const multiplicador = (factor) => (numero) => numero * factor;

const duplicar = multiplicador(2);
console.log(duplicar(5));

const triplicador = multiplicador(3);
console.log(triplicador(5));

const cuadruplicador = multiplicador(4);
console.log(cuadruplicador(5));