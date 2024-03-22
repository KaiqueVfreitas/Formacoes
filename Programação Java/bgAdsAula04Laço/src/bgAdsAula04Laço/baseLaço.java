package bgAdsAula04Laço;

public class baseLaço {

	public baseLaço() {
	}

	public static void main(String[] args) {
		exTesteMesaFor();
	}

	private static void exTesteMesaFor() {
		// TODO Auto-generated method stub
		int valor = 3;
		for (int i = 1; i <= 10; i++) {
		    System.out.println(i + "*" + valor + "=" + i * valor);
		}

		
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
