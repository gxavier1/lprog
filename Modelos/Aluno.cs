namespace Modelos {

  class Aluno {
    private int periodo;

    public int Periodo{
      get => this.periodo;
      set {
        if (value > 0) {
        this.periodo = value;
      } else {
        this.periodo = 1;
      }
    }
  }

    public string Nome {
      get; set;
    }

    public string Matricula {
      get; set;
    }
    
    public Aluno() : this(0) {
    }
    public Aluno(int periodo){
      this.Periodo = periodo;
    }

    public Aluno(string matricula, string nome) : this() {
      this.Matricula = matricula;
      this.Nome = nome;
    }
   
    public Aluno(string matricula, string nome, int periodo) 
                  : this(periodo) {
      this.Matricula = matricula;
      this.Nome = nome;
    }
    
    public bool Matricular(Disciplina disciplina){
      return this.Periodo == disciplina.Semestre;
    }
  }

}