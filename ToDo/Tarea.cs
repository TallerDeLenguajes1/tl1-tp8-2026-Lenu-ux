namespace TareaApp;
public class Tarea
{
  public int TareaID { get; set; }
 public string Descripcion { get; set; }
 public int Duracion { get; set; }
//debo validar que duracion este entre 10 y 100 fuera del constructor
          
//armo un constructor
public Tarea(int id,string descripcion,int duracion)
    {
        this.TareaID=id;
        this.Descripcion=descripcion;
    
    }

}
