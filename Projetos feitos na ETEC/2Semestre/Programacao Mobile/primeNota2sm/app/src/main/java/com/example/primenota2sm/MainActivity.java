package com.example.primenota2sm;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Spinner;

import androidx.appcompat.app.AppCompatActivity;

import androidx.activity.EdgeToEdge;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    EditText editTextProcurar;
    Spinner spinnerGenero;
    ListView listViewLivros;
    Button btnAdicionar;
    Button btnDeletar;

    // Array que utilizo para ter opções de generos
    ArrayList<String> genero = new ArrayList<>();
    ArrayAdapter<String> adapter;


    //Classe LivroDao que acessa os dados
    private LivroDao livroDao;
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        // Recebendo ID do xml
        editTextProcurar = findViewById(R.id.edit_text_procurar);
        spinnerGenero = findViewById(R.id.spinner_genero); // Correção aqui
        listViewLivros = findViewById(R.id.listView_livros);
        btnAdicionar = findViewById(R.id.button_adicionar);
        btnDeletar = findViewById(R.id.button_deletar);

        // Ação que abre a tela de cadastrado
        btnAdicionar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, CadActivity.class);
                startActivity(intent);
            }
        });

        // Ação que abre a tela de exclusão
        btnDeletar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, DelActivity.class);
                startActivity(intent);
            }
        });

        Generos();
        ListaLivros();


    }

    //Método de consulta no banco de dados
    public void ListaLivros(){
        LivroDao daoLivro 

        ArrayAdapter adapter = new ArrayAdapter(
                MainActivity.this, android.R.layout.simple_list_item_1, genero
        );

        listViewLivros.setAdapter(adapter);
    }


    //Generos que podem ser adicionados no aplicativo
    public void Generos() {
        genero.add("Procura por gênero:");
        genero.add("Ação");
        genero.add("Comédia");
        genero.add("Drama");
        genero.add("Ficção");
        genero.add("Mistério");
        genero.add("Não ficção");
        genero.add("Romance");
        genero.add("Terror");

        adapter = new ArrayAdapter<>(this,
                android.R.layout.simple_spinner_item, genero);
        spinnerGenero.setAdapter(adapter);
    }
}
