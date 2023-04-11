using ClaseCuatroHerramientas.Models;
namespace ClaseCuatroHerramientas.Services;


    public static class MovieService{
        static List<Movie> Movies {get; set;}

        static MovieService(){
            Movies = new List<Movie>{
            new Movie { Name = "Back to the future", Code = "BTF", Category = "Sci fi", Minutes = 100, Review = "Pelicula donde viajan en el tiempo"},                        
            new Movie { Name = "Avatar", Code = "AVT", Category = "Sci fi", Minutes = 500, Review = "Esta pelicula no la vi nunca"} ,
            new Movie { Name = "Hannibal", Code = "HNL", Category = "Terror", Minutes = 110, Review = "Una pelicula de los 90's"},
            new Movie { Name = "Superman", Code = "SPM", Category = "Sci fi", Minutes = 100, Review = "Pelicula de super heroes"},                        
            new Movie { Name = "Esperando la carroza", Code = "ELC", Category = "Sci fi", Minutes = 500, Review = "Pelicula argentina de la decada de los 80's"} ,
            new Movie { Name = "Argentina 1993", Code = "ARG", Category = "Terror", Minutes = 110, Review = "Esta pelicula se filmo en Argentina"},
            new Movie { Name = "Hulk", Code = "HLK", Category = "Sci fi", Minutes = 100, Review = "Pelicula de super heroes"},                        
            new Movie { Name = "El padrino", Code = "ELP", Category = "Accion", Minutes = 500, Review = "Esta es una pelicula de mafiosos"} ,
            new Movie { Name = "Rocky", Code = "RCK", Category = "Accion", Minutes = 110, Review = "Pelicula de boxeo"},
            new Movie { Name = "Ladron de bicicletas", Code = "LDB", Category = "Drama", Minutes = 110, Review = "En esta pelicula se roban bicicletas"}

            };
    }

    public static List<Movie> GetAll() => Movies;

    public static void Add(Movie obj){
        if(obj == null){
            return;
        }
        Movies.Add(obj);
    }
    public static void Delete(string code){
        var movieToDelete = Get(code);

        if (movieToDelete != null){
            Movies.Remove(movieToDelete);
        }
    }
    public static Movie? Get(string code) => Movies.FirstOrDefault(x => x.Code.ToLower() == code.ToLower());
}