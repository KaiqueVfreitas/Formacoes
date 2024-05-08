package com.example.prinota2sm;

import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Spinner;

import androidx.appcompat.app.AppCompatActivity;

import java.util.ArrayList;

public class tlConsActivity extends AppCompatActivity {

    EditText editTextPesquisa;
    Spinner spinnerGenero;
    ListView listViewLivros;
    Button buttonConsultar;

    LivroDao livroDao;
    ArrayList<LivroModel> listaLivros;
    ArrayAdapter<LivroModel> adapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tl_cons);

        editTextPesquisa = findViewById(R.id.edit_text_pesquisa);
        spinnerGenero = findViewById(R.id.spinner_genero_consulta);
        listViewLivros = findViewById(R.id.list_view_livros);
        buttonConsultar = findViewById(R.id.button_consultar);

        livroDao = new LivroDao(this);

        listaLivros = new ArrayList<>();
        adapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, listaLivros);
        listViewLivros.setAdapter(adapter);

        SpinnerGenero();

        editTextPesquisa.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {}

            @Override
            public void onTextChanged(CharSequence s, int start, int before, int count) {
                consultarLivros();
            }

            @Override
            public void afterTextChanged(Editable s) {}
        });

        spinnerGenero.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {
                consultarLivros();
            }

            @Override
            public void onNothingSelected(AdapterView<?> parent) {}
        });

        buttonConsultar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                consultarLivros();
            }
        });

        mostrarLivrosCadastrados();
    }

    public void SpinnerGenero() {
        ArrayList<String> generos = new ArrayList<>();
        generos.add("");
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

    public void consultarLivros() {
        String genero = spinnerGenero.getSelectedItem().toString();
        String nomePesquisa = editTextPesquisa.getText().toString();

        if (!genero.isEmpty() && !nomePesquisa.isEmpty()) {
            listaLivros = livroDao.consultarPorGeneroENome(genero, nomePesquisa);
        } else if (!genero.isEmpty()) {
            listaLivros = livroDao.consultarPorGenero(genero);
        } else if (!nomePesquisa.isEmpty()) {
            listaLivros = livroDao.consultarPorNome(nomePesquisa);
        } else {
            listaLivros = livroDao.consultarTodos();
        }

        adapter.clear();
        adapter.addAll(listaLivros);
        adapter.notifyDataSetChanged();
    }

    public void mostrarLivrosCadastrados() {
        listaLivros = livroDao.consultarTodos();
        adapter.clear();
        adapter.addAll(listaLivros);
        adapter.notifyDataSetChanged();
    }
}
