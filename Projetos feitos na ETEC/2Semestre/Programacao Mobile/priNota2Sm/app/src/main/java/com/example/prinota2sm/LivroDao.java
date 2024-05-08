package com.example.prinota2sm;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import java.util.ArrayList;

public class LivroDao extends SQLiteOpenHelper {

    public LivroDao(Context context) {
        super(context, "db_filme", null, 1);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        String comando = "create table tb_filme (" +
                "id integer primary key autoincrement," +
                "nome varchar(200) not null," +
                "genero varchar(30) not null, " +
                "nota decimal(3,1) not null," +
                "tipo char(5) not null)";
        db.execSQL(comando);

        adicionarLivrosIniciais(db);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        String comando = "alter table tb_filme add column nova_coluna integer";
        db.execSQL(comando);
    }

    private void adicionarLivro(SQLiteDatabase db, String nome, String genero, double nota, String tipo) {
        ContentValues values = new ContentValues();
        values.put("nome", nome);
        values.put("genero", genero);
        values.put("nota", nota);
        values.put("tipo", tipo);
        db.insertOrThrow("tb_filme", null, values);
    }

    private void adicionarLivrosIniciais(SQLiteDatabase db) {
        adicionarLivro(db, "Dom Casmurro", "Ficção", 4.5, "Livro");
        adicionarLivro(db, "Memórias Póstumas de Brás Cubas", "Ficção", 4.7, "Livro");

        adicionarLivro(db, "Gabriela, Cravo e Canela", "Romance", 4.3, "Livro");
        adicionarLivro(db, "O Guarani", "Romance", 4.2, "Livro");

        adicionarLivro(db, "O Auto da Compadecida", "Aventura", 4.6, "Livro");
        adicionarLivro(db, "Vidas Secas", "Aventura", 4.4, "Livro");

        adicionarLivro(db, "O Caso Morel", "Mistério", 4.0, "Livro");
        adicionarLivro(db, "Sherlock Holmes: As Aventuras", "Mistério", 4.8, "Livro");

        adicionarLivro(db, "A Hora da Estrela", "Fantasia", 4.5, "Livro");
        adicionarLivro(db, "O Senhor dos Anéis", "Fantasia", 4.9, "Livro");

        adicionarLivro(db, "A Arte da Guerra", "Não Ficção", 4.7, "Livro");
        adicionarLivro(db, "Sapiens: Uma Breve História da Humanidade", "Não Ficção", 4.8, "Livro");

        adicionarLivro(db, "Minha Vida", "Biografia", 4.5, "Livro");
        adicionarLivro(db, "Steve Jobs", "Biografia", 4.6, "Livro");

        adicionarLivro(db, "O Poder do Hábito", "Autoajuda", 4.3, "Livro");
        adicionarLivro(db, "O Segredo", "Autoajuda", 4.1, "Livro");
    }

    public ArrayList<LivroModel> consultarTodos(){
        String comando = "select * from tb_filme";
        SQLiteDatabase db = getReadableDatabase();
        Cursor cursor = db.rawQuery(comando, null);
        ArrayList<LivroModel> listLivros = new ArrayList<>();
        while (cursor.moveToNext()){
            LivroModel livro = new LivroModel();
            livro.id = cursor.getInt(0);
            livro.nome = cursor.getString(1);
            livro.genero = cursor.getString(2);
            livro.nota = cursor.getDouble(3);
            livro.tipo = cursor.getString(4);
            listLivros.add(livro);
        }
        cursor.close();
        return listLivros;
    }

    public ArrayList<LivroModel> consultarPorNome(String nome){
        String comando = "select * from tb_filme where nome like '%" + nome + "%'";
        SQLiteDatabase db = getReadableDatabase();
        Cursor cursor = db.rawQuery(comando, null);
        ArrayList<LivroModel> listLivros = new ArrayList<>();
        while (cursor.moveToNext()){
            LivroModel livro = new LivroModel();
            livro.id = cursor.getInt(0);
            livro.nome = cursor.getString(1);
            livro.genero = cursor.getString(2);
            livro.nota = cursor.getDouble(3);
            livro.tipo = cursor.getString(4);
            listLivros.add(livro);
        }
        cursor.close();
        return listLivros;
    }

    public ArrayList<LivroModel> consultarPorAvaliacao(double nota){
        String comando = "select * from tb_filme where nota >= " + nota;
        SQLiteDatabase db = getReadableDatabase();
        Cursor cursor = db.rawQuery(comando, null);
        ArrayList<LivroModel> listLivros = new ArrayList<>();
        while (cursor.moveToNext()){
            LivroModel livro = new LivroModel();
            livro.id = cursor.getInt(0);
            livro.nome = cursor.getString(1);
            livro.genero = cursor.getString(2);
            livro.nota = cursor.getDouble(3);
            livro.tipo = cursor.getString(4);
            listLivros.add(livro);
        }
        cursor.close();
        return listLivros;
    }

    public ArrayList<LivroModel> consultarPorGenero(String genero){
        String comando = "select * from tb_filme where genero like '%" + genero + "%'";
        SQLiteDatabase db = getReadableDatabase();
        Cursor cursor = db.rawQuery(comando, null);
        ArrayList<LivroModel> listLivros = new ArrayList<>();
        while (cursor.moveToNext()){
            LivroModel livro = new LivroModel();
            livro.id = cursor.getInt(0);
            livro.nome = cursor.getString(1);
            livro.genero = cursor.getString(2);
            livro.nota = cursor.getDouble(3);
            livro.tipo = cursor.getString(4);
            listLivros.add(livro);
        }
        cursor.close();
        return listLivros;
    }
}
