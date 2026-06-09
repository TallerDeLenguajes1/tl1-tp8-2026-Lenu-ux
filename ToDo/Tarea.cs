namespace TareaApp;
public class Tarea
{
public int TareaID { get; set; }
 public string Descripcion { get; set; }
//debo validar que duracion este entre 10 y 100 fuera del constructor
  private int duracionReal;
 public int Duracion { get {return duracionReal;}
        set
        {
            if (value >=10 && value<=100)
            {
                duracionReal=value;
            }else
            {
                duracionReal=10;
            }
        }
         }

//armo un constructor
public Tarea(int id,string descripcion,int duracion)
    {
        this.TareaID=id;
        this.Descripcion=descripcion;
        this.Duracion=duracion;
    }

}
