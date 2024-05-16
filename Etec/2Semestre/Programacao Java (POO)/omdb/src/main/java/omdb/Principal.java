package omdb;

import java.util.Scanner;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class Principal {
	

	public static void main(String[] args) {
		Retrofit retrofit = new Retrofit.Builder()
				.baseUrl("https://www.omdbapi.com//")
				.addConverterFactory(GsonConverterFactory.create())
				.build();
		
		System.out.println("Digite o nome do filme");
		try (Scanner leitor = new Scanner(System.in)) {
			String nome = leitor.nextLine();
		System.out.println("Digite o ano do filme");
		    String ano = leitor.nextLine();
			
			OmdbService service = retrofit.create(OmdbService.class);
			Call<movie> call = service.buscaPorTituloAno(nome, ano);
			call.enqueue(new Callback<movie>() {
				
				@Override
				public void onResponse(Call<movie> call, Response<movie> response) {
					movie movie = response.body();
					System.out.println(movie.Title);
					System.out.println(movie.Year);
					System.out.println(movie.Type);
					System.out.println(movie.Genre);
					System.out.println(movie.Country);
				}
				
				@Override
				public void onFailure(Call<movie> call, Throwable t) {
					// TODO Auto-generated method stub
					System.out.println();
				}
			});
			 //Call é um acesso a internet pela linguagem de programação 
			
			
		}
	}

}