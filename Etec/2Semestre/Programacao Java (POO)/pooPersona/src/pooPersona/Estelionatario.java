package pooPersona;

import java.util.Random;

public class Estelionatario extends Personagem {
    int malandragem;

    void Engano(Personagem inimigo) {
        Random random = new Random();
        int tentativas = 3;
        boolean acertou = false;

        for (int i = 0; i < tentativas; i++) {
            int chanceDeAcerto = random.nextInt(10);

            if (chanceDeAcerto == 0) {
                inimigo.forca = 0;
                ganhaExp(inimigo.nivel);
                acertou = true;
                break;
            }
        }
        if (acertou) {
            int chanceAdicional = random.nextInt(10);
            if (chanceAdicional == 0) {
                inimigo.forca = 0;
                ganhaExp(inimigo.nivel);
            }
        }
    }
}
