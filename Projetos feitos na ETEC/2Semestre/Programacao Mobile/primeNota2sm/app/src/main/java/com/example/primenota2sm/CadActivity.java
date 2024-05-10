package com.example.primenota2sm;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.RatingBar;
import android.widget.Spinner;
import android.widget.Toast;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import java.util.ArrayList;

public class CadActivity extends AppCompatActivity {

    EditText editTextPesquisa;
    Spinner selecaoGenero;
    RatingBar estrelaNota;
    RadioButton tipoLivro;
    RadioButton tipoEbook;
    Button btnCadastrar;
    // Array que utilizo para ter opções de generos
    ArrayList<String> genero = new ArrayList<>();
    ArrayAdapter<String> adapter;

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_cad);
        //Associando XML com JAVA
        editTextPesquisa = findViewById(R.id.edit_text_nome_inclusao);
        selecaoGenero = findViewById(R.id.spinner_genero_inclusao);
        estrelaNota = findViewById(R.id.rating_bar_nota_inclusao);
        tipoLivro = findViewById(R.id.radio_tipo_livro);
        tipoEbook = findViewById(R.id.radio_tipo_ebook);
        btnCadastrar = findViewById(R.id.button_inclusao);

        Generos();

        btnCadastrar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Pegando os valores dos campos dentro do onClick
                String nome = editTextPesquisa.getText().toString();
                int indiceGenero = selecaoGenero.getSelectedItemPosition();
                float nota = estrelaNota.getRating();

                if (nome.isEmpty()) {
                    editTextPesquisa.setError("Digite o nome do filme");
                } else if (indiceGenero == 0) {
                    Toast.makeText(CadActivity.this, "Escolha um gênero!", Toast.LENGTH_SHORT).show();
                } else if (nota == 0) {
                    Toast.makeText(CadActivity.this, "Nota deve ser maior que 0", Toast.LENGTH_SHORT).show();
                } else if (!tipoLivro.isChecked() && !tipoEbook.isChecked()) {
                    Toast.makeText(CadActivity.this, "Escolha ao menos um tipo", Toast.LENGTH_SHORT).show();
                } else {
                    Toast.makeText(CadActivity.this, "LIVRO CADASTRADO COM SUCESSO!!!", Toast.LENGTH_LONG).show();
                    Intent intent = new Intent(CadActivity.this, MainActivity.class);
                    startActivity(intent);
                }
            }
        });
    }

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
        selecaoGenero.setAdapter(adapter);
    }
}
