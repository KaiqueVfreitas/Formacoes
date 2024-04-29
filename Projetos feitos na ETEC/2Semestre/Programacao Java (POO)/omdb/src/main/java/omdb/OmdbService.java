package omdb;

import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.Query;



public interface OmdbService {
	
	
	@GET("?apikey=8e8bd0de")
	Call<movie> buscaPorTitulo(@Query("t") String nome);
	@GET("?apikey=8e8bd0de")
	Call<movie> buscaPorTituloAno(@Query("t") String nome, 
									@Query ("y")String ano);
	
	
	
}
