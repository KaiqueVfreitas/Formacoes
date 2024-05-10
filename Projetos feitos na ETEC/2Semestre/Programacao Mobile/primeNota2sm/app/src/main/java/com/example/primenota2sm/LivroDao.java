// LivroDao.java
package com.example.primenota2sm;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.view.View;

import java.util.ArrayList;
import java.util.List;

public class LivroDao extends SQLiteOpenHelper {

    private static final String DATABASE_NAME = "livros.db";
    private static final int DATABASE_VERSION = 1;


    public LivroDao(Context context) {
        super(context, DATABASE_NAME, null, DATABASE_VERSION);
    }

    //Criando a tabela que registra os dados
    @Override
    public void onCreate(SQLiteDatabase db) {
        String comando = "CREATE TABLE tb_livro (" +
                "id INTEGER PRIMARY KEY," +
                "nome TEXT NOT NULL," +
                "genero TEXT NOT NULL," +
                "nota REAL NOT NULL," +
                "tipo TEXT NOT NULL)";
        db.execSQL(comando);

    }


    //Adicionando nova coluna
    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        String comando = "ALTER TABLE tb_livro ADD COLUMN nova_coluna INTEGER";
        db.execSQL(comando);
    }

    public void inserir(LivroModel livro) {
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues valores = new ContentValues();
        valores.put("nome", livro.getNome());
        valores.put("genero", livro.getGenero());
        valores.put("nota", livro.getNota());
        valores.put("tipo", livro.getTipo());
        db.insert("tb_livro", null, valores);
        db.close();
    }

    public ArrayList<LivroModel> ListaLivros(){
        String comando = "select * from " + DATABASE_NAME;
        Cursor cursor = getReadableDatabase().rawQuery(comando, null);

        ArrayList<LivroDao> arrayListGenero = new ArrayList<>();

        while (cursor.moveToNext()){
            LivroModel livroModel = new LivroModel();
            livroModel.setId(cursor.getInt(0));
            livroModel.setNome(cursor.getString(1));
            livroModel.setGenero(cursor.getString(2));
            livroModel.setTipo(cursor.getInt(3));
            livroModel.setNota(cursor.getInt(4));

            arrayListGenero.add(LivroModel);

        }
        return ArrayListGenero;
}
