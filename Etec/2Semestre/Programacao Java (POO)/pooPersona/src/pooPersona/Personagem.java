package pooPersona;

public class Personagem {
	String nome; 
	int forca;
	int defesa;
	int vida;
	int exp;
	int nivel;
	
	
	void atacar(Personagem inimigo) {
		int dano = this.forca - inimigo.defesa;
		if(dano < 0) dano = 0;
		inimigo.vida -= dano;
		if(inimigo.vida <= 0) {
			ganhaExp(inimigo.nivel);
		}
	}
	void ganhaExp(int nivelInimigo) {
		int expGanha = 10 * nivelInimigo;
		this.exp += expGanha;
		if(this.exp > 100 * this.nivel) {
			nivel++;
			this.forca++;
			this.defesa++;
			this.vida += 10;
		}
		
	}

}
