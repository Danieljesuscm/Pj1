using System;


class MainClass {
  public static void Main (string[] args) {
     
           
    usuario daniel = new usuario();
    daniel.Setnome ("Daniel de Jesus");
    daniel.nomefilme = "Harry Potter e o Principe Misterioso";
    daniel.avaliaçao = "filme topzera";   
  
  
    
    filme fil = new filme();
    fil.nome = daniel.nomefilme;
    fil.genero = "ação e aventura";
    fil.duração = 153;


    Console.WriteLine("nome do filme >>{0} ",daniel.nomefilme);
    Console.WriteLine("Genero do filme>>{0} ",fil.genero);
    Console.WriteLine("Duração do Filme >> {0} minutos",fil.duração);
    Console.WriteLine("Avaliação do usuario >> {0} ",daniel.avaliaçao);


    


    


   
  }
}