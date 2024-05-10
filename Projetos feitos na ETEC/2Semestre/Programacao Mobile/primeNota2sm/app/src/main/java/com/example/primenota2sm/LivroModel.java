// LivroModel.java
package com.example.primenota2sm;

public class LivroModel {
    private int id;
    private String nome;
    private String genero;
    private float nota;
    private String tipo;


    public LivroModel(String nome, String genero, float nota, String tipo) {
        this.nome = nome;
        this.genero = genero;
        this.nota = nota;
        this.tipo = tipo;
    }

    // Métodos de acesso
    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
        return id;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getGenero() {
        return genero;
    }

    public void setGenero(String genero) {
        this.genero = genero;
    }

    public float getNota() {
        return nota;
    }

    public void setNota(float nota) {
        this.nota = nota;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public void add(LivroModel livro) {
    }

}
