package com.example.prinota2sm;

import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioGroup;
import android.widget.RatingBar;
import android.widget.Spinner;
import android.widget.Toast;
import androidx.appcompat.app.AppCompatActivity;

import com.example.prinota2sm.R;

import java.util.ArrayList;
import java.util.List;

public class tlCadActivity extends AppCompatActivity {

    EditText editTextNomeLivro;
    Spinner spinnerGenero;
    RatingBar ratingBarNota;
    RadioGroup radioGroupTipo;
    Button buttonInclusao;

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tl_cad);

        editTextNomeLivro = findViewById(R.id.edit_text_nome_livro);
        spinnerGenero = findViewById(R.id.spinner_genero_inclusao);
        ratingBarNota = findViewById(R.id.rating_bar_nota_inclusao);
        radioGroupTipo = findViewById(R.id.radio_group_tipo);
        buttonInclusao = findViewById(R.id.button_inclusao);

        SpinnerGenero();

        buttonInclusao.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                incluirLivro();
            }
        });
    }

    public void SpinnerGenero() {
        List<String> generos = new ArrayList<>();
        generos.add("Ficção");
        generos.add("Romance");
        generos.add("Aventura");
        generos.add("Mistério");
        generos.add("Fantasia");
        generos.add("Não Ficção");
        generos.add("Biografia");
        generos.add("Autoajuda");

        ArrayAdapter<String> adapter = new ArrayAdapter<>(this, android.R.layout.simple_spinner_item, generos);
        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        spinnerGenero.setAdapter(adapter);
    }

    public void incluirLivro() {
        String nomeLivro = editTextNomeLivro.getText().toString();
        String genero = spinnerGenero.getSelectedItem().toString();
        float nota = ratingBarNota.getRating();
        String tipo = (radioGroupTipo.getCheckedRadioButtonId() == R.id.radio_tipo_livro) ? "Livro" : "Ebook";

        String mensagem = "Nome: " + nomeLivro + "\nGênero: " + genero + "\nNota: " + nota + "\nTipo: " + tipo;
        Toast.makeText(this, mensagem, Toast.LENGTH_LONG).show();
    }
}
