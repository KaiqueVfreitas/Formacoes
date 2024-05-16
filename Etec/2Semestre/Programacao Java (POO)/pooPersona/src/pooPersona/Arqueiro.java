package pooPersona;

public class Arqueiro extends Personagem {
	int sorte;
	
	void tiroCerteiro(Personagem inimigo) {
		int tentativas = this.sorte;
		Random random = new Random();
		
		for(int i = tentativas; i <= tentativas; i++ ) {
			int valor = random;
			if(valor == 1) {
				inimigo.vida = 0;
				ganhaExp(inimigo.nivel);
				break; // sai do for
			}
		}
	}
}
