package pooPersona;
//extends indica que assassino é classe filha/subclasse
//da classe mae ou super classe personagem 
public class  Assassino extends Personagem{
	//atributos e metodos proprios desta classe
	int furtividade;
	
	void naTrairagem(Personagem inimigo){
		int dano = this.forca + this.furtividade - inimigo.defesa;
		if(dano<0) dano = 0;
			inimigo.vida -= dano;
			if(inimigo.vida<0) {
				ganhaExp(inimigo.nivel);
			}
	}
}
