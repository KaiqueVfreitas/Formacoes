package bgAdsAula04Laço;

public class baseLaço {

	public baseLaço() {
	}

	public static void main(String[] args) {
		exTabuadasResult();
	}

	private static void exTabuadasResult() {
		// TODO Auto-generated method stub
		for (int j = 1; j <= 10; j++) {
			for (int i = 1; i <= 10; i++) {
				System.out.println(i * j + "\t");

			}
			System.out.println();
		}
	}

	private static void exTrianPascal() {
		// TODO Auto-generated method stub
		for(int i=1; i<=5; i++){
			for(int j=1; j<=i; j++){
				System.out.print(i);
			}
			System.out.println();
		}
	}

	private static void exTesteMesaFor() {
		// Os exercicios de mesa está comentado


		//PRIMEIRO EXERCICIO
		//int valor = 3;
		//for (int i = 1; i <= 10; i++) {
		// System.out.println(i + "*" + valor + "=" + i * valor);
		//}

		//SEGUNDO EXERCICIO
		//for (int i=1; i <= 5; i++) {
		//for (int j=1; j<=i; j++) {
		//System.out.print(i);
		//}
		//System.out.println();
		//}




	}

	private static void exFatorialWhile() {
		// TODO Auto-generated method stub
		int fat = 1, valor = 5;
		while(valor >= 1){
			fat = fat*valor;
			valor--;
			System.out.println(fat);
		}

	}

	private static void exFatorialFor() {
		// TODO Auto-generated method stub
		for(int fat = 1, valor = 5; valor >=1; valor--){
			fat = fat*valor;
			System.out.println(fat);
		}

	}

}
