package aulaPOO;

public class prmAulaContaCorrente {
    // Atributos
    double saldo;
    String nomeTitular;
    int agConta;

    // Construtor
    public prmAulaContaCorrente() {
        // TODO Auto-generated constructor stub
    }

    // Método para depositar
    void depositar(double valor) {
        saldo = saldo + valor;
        System.out.println("Valor de " + valor + " depositado");
    } 
    
    // Método para sacar
    void sacar(double valor) {
        if (valor <= saldo) {
            saldo = saldo - valor;
            System.out.println("Saque efetuado");
        } else {
            System.out.println("Saldo insuficiente para saque");
        }
    }
    
    // Método para transferência bancária
    boolean transferir(double valor, prmAulaContaCorrente destino) {
        if (valor <= saldo) {
            saldo = saldo - valor;
            destino.depositar(valor);
            return true;
        } else {
            return false;
        }
    }

    public static void main(String[] args) {
        // Instanciando objetos da classe prmAulaContaCorrente
        prmAulaContaCorrente cc1 = new prmAulaContaCorrente();
        prmAulaContaCorrente cc2 = new prmAulaContaCorrente();

        // Definindo valores iniciais
        cc1.nomeTitular = "Cidade";
        cc2.saldo = 5000;

        // Fazendo operações de depósito e saque
        cc1.depositar(20000);
        System.out.println("Saldo após depósito: " + cc1.saldo);

        cc1.sacar(1500);
        System.out.println("Saldo após saque: " + cc1.saldo);
         
        // Transferindo 1000 para cc2
        if(transferir){
        	cc1.transferir(1000, cc2);
        	System.out.println("Saldo após transferência: " + cc1.saldo);
        	System.out.println("Saldo de cc2 após transferência: " + cc2.saldo);
        }
        else {
        	System.out.println("Não foi possivel fazer a transferência");
        }
        
    }
}
