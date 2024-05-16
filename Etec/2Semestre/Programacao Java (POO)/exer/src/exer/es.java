package exer;
import java.util.Scanner;

public class es {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int v1, v2;
        int resultado = 0;
        
        System.out.println("Digite os dois números para multiplicação:");
        v1 = scanner.nextInt();
        v2 = scanner.nextInt();
      
        while(v2 > 0) {
        	resultado = resultado + v1;
            v2--;
        }
        
        System.out.println("O resultado da multiplicação é: " + resultado);
       
    }

}
