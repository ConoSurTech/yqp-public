function calcularMillas() {

    // tomamos el número ingresado por el usuario
    var kilometers = document.getElementById("km").value;

    // guardamos una variable con el factor de conversión
    const factor = 0.621371;

    // calculamos las millas
    var miles = kilometers * factor;

    document.getElementById("Resultado").innerHTML = kilometers + " KM equivalen a <strong>" + miles + "</strong> millas.";

}