import java.util.Scanner;
public class exImcAndroidStudio {

	public exImcAndroidStudio() {
		// TODO Auto-generated constructor stub
		imc();
	}

	private void imc() {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
        double altura, peso, imc;
        int sexo;
        System.out.println("Digite o peso:");
        peso = scanner.nextDouble();
        System.out.println("Digite a altura:");
        altura = scanner.nextDouble();
        System.out.println("Aperte 1, caso seja mulher");
        System.out.println("Aperte 2, caso seja homem");
        sexo = scanner.nextInt();
        
        imc = peso / (altura * altura);
        
        if (sexo == 1 && imc <= 17) {
            System.out.println("Você pode estar com anorexia");
        } else if (sexo == 1 && imc >= 18) {
            System.out.println("Você está no peso ideal");
        } else if (sexo == 1 && imc >= 24) {
            System.out.println("Você pode estar obeso");
        } else if (sexo == 2 && imc <= 18) {
            System.out.println("Você pode estar com anorexia");
        } else if (sexo == 2 && imc >= 19) {
            System.out.println("Você pode estar no peso ideal");
        } else if(sexo == 2 && imc >= 23) {
            System.out.println("Você pode estar obeso");
        }
	}

	public static void main(String[] args) {
		// TODO Auto-generated method stub

	}

}
