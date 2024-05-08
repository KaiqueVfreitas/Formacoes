package com.example.prinota2sm;

public class LivroModel {
    String nome;
    int id;
    String tipo;
    double nota;
    String genero;


    @Override
    public  String toString(){
        return nome+"-" + genero + "-" + nota;
    }
}
