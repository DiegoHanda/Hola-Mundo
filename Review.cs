namespace Reviews;
public class Review
{
    public string comentario{get;set;}
    public int calificacion{get;set;}
    public Review (int calificacion, string comentario)
    {
        this.calificacion=calificacion; 
        this.comentario=comentario;
    }
        public string getInfoReview()
    {
       return $"{this.calificacion}, {this.comentario}";
    }
}
