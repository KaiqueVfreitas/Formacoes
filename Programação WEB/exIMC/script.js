function calcularIMC() {
    var peso = parseFloat(document.getElementById('txtPeso').value);
    var altura = parseFloat(document.getElementById('txtAltura').value);
    var sexoFeminino = document.getElementById('sexoF').checked;
    var sexoMasculino = document.getElementById('sexoM').checked;
    var resultadoIMC = peso / (altura * altura);

    var resultado = document.getElementById('txtIMC');

    if (isNaN(peso) || isNaN(altura)) {
        alert('Por favor, insira um valor válido para peso e altura.');
        resultado.value = '';
        return;
    }

    if (sexoFeminino) {
        switch (true) {
            case resultadoIMC < 19:
                resultado.value = 'Abaixo do peso';
                break;
            
            
                resultado.value = 'Peso normal';
        }
    } else if (sexoMasculino) {
       
    }
}
