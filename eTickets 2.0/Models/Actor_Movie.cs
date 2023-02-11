namespace eTickets_2._0.Models
{
    public class Actor_Movie
    {
        //Storing Movies and Actors Id
        //Multiple actors are in a movie, a movie has multiple actors.
        //MovieId is the foreign key for the movie model.
        //Many to many relationships (must create a seperate table)



        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public Actor Actor { get; set; }

        public int ActorId { get; set; }


    }
}
