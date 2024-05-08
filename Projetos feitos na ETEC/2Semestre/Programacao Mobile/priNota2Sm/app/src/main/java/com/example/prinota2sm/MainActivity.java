package com.example.prinota2sm;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ListView;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {
    TextView ttlPrin;
    ListView listView;
    Button btnCad;
    Button btnCons;
    Button btnAp;

    private void XmlJava() {
        ttlPrin = findViewById(R.id.ttlPrin);
        listView = findViewById(R.id.listView);
        btnCad = findViewById(R.id.btnCad);
        btnCons = findViewById(R.id.btnCons);
        btnAp = findViewById(R.id.btnAp);
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        XmlJava();
        btnAcoes();
    }


    //Metodos do codigo abaixo
    private void btnAcoes() {
        //Click do botao de cadastro
        btnCad.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, tlCadActivity.class);
                startActivity(intent);
            }
        });

        //Click do botao de consultar
        btnCons.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, tlConsActivity.class);
                startActivity(intent);
            }
        });

        //Click do botao apagar
        btnAp.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, tlApActivity.class);
                startActivity(intent);
            }
        });

    }
}
