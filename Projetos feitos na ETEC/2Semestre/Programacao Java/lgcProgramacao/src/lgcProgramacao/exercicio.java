package lgcProgramacao;

import java.util.Scanner;

public class exercicio {

    public exercicio() {
        // TODO Auto-generated constructor stub
    }

    public static void main(String[] args) {
        // Chama o construtor da classe exLogica para iniciar a calculadora
        new exLogica();
    }
}

class exLogica {
    Scanner scanner = new Scanner(System.in);

    public exLogica() {
        // TODO Auto-generated constructor stub
        exTemperatura();
    }

    private void exTemperatura() {
        // TODO Auto-generated method stub
        double cel, fah, kel;
        int escolha;
        System.out.println("---------------------------------------");
        System.out.println("------CONVERSÃO DE TEMPERATURA------");
        System.out.println("---------------------------------------");
        System.out.println("--Escolha UMA OPÇÃO--");
        System.out.println("Digite 1 para converter celsius para fahrenheit");
        System.out.println("Digite 2 para converter fahrenheit para celsius");
        System.out.println("Digite 3 para converter kelvin para celsius");
        System.out.println("Digite 4 para converter celsius para kelvin");
        System.out.println("Digite 5 para converter fahreinheit para kelvin");
        System.out.println("Digite 6 para converter kelvin para fahrenheit");
        escolha = scanner.nextInt();
        switch (escolha) {
            case 1:
                System.out.println("Temperatura em celsius:");
                cel = scanner.nextDouble();
                fah = (cel * 9 / 5) + 32;
                System.out.println("O resultado da conversão celsius para fahrenheit foi: " + fah);
                break;
            case 2:
            	System.out.println("Temperatura em fahrenheit:");
                fah = scanner.nextDouble();
                cel = (fah - 32) * 5/9;
                System.out.println("O resultado da conversão celsius para fahrenheit foi: " + cel);
                break;
            case 3:
            	System.out.println("Temperatura em celsius:");
                cel = scanner.nextDouble();
                kel = cel + 273.15;
                System.out.println("O resultado da conversão celsius para fahrenheit foi: " + kel);
                break;
            case 4:
            	System.out.println("Temperatura em kelvin:");
                kel = scanner.nextDouble();
                cel = ;
                System.out.println("O resultado da conversão celsius para fahrenheit foi: " + fah);
                break;
            default:
                System.out.println("Inválido");
        }
    }
}

	private void exCalculadora() {
		// TODO Auto-generated method stub

		double nm1, nm2, resultado;
		int escolha, ciclo = 1;
		while (ciclo == 1) {
			System.out.println("---------------------------------------");
			System.out.println("------CALCULADORA DAS 4 OPERAÇÕES------");
			System.out.println("---------------------------------------");
			System.out.println("--Escolha qual operação deseja fazer--");
			System.out.println("Digite 1 para ADIÇÃO");
			System.out.println("Digite 2 para SUBTRAÇÃO");
			System.out.println("Digite 3 para MULTIPLICAÇÃO");
			System.out.println("Digite 4 para DIVISÃO");

			escolha = scanner.nextInt();

			System.out.println("Digite o primeiro número:");
			nm1 = scanner.nextDouble();

			System.out.println("Digite o segundo número:");
			nm2 = scanner.nextDouble();

			// Adição de um loop while para permitir que o usuário faça várias operações

			switch (escolha) {
			case 1:
				resultado = nm1 + nm2;
				System.out.println("Resultado: " + resultado);
				break;

			case 2:
				resultado = nm1 - nm2;
				System.out.println("Resultado: " + resultado);
				break;

			case 3:
				resultado = nm2 * nm1;
				System.out.println("Resultado: " + resultado);
				break;

			case 4:
				if (nm2 != 0) {
					resultado = nm1 / nm2;
					System.out.println("Resultado: " + resultado);
				} else {
					System.out.println("Segundo número inválido");
				}
				break;

			default:
				System.out.println("Opção inválida");
				break;
			}

			// Solicitação para outra operação
			System.out.println("Digite 1 para outra conta ou qualquer outro número para sair:");
			ciclo = scanner.nextInt();
		}

	}
}
