// LivroDao.java
package com.example.primenota2sm;

import android.content.ContentValues;
import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

public class LivroDao extends SQLiteOpenHelper {

    private static final String DATABASE_NAME = "livros.db";
    private static final int DATABASE_VERSION = 1;

    public LivroDao(Context context) {
        super(context, DATABASE_NAME, null, DATABASE_VERSION);
    }

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
}
