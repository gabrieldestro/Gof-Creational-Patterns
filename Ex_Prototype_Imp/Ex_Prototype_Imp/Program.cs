// See https://aka.ms/new-console-template for more information

using Ex_Prototype_Imp;

Funcionario prog = new Programador("João", "Desenvolvedor", "C#");
Funcionario prog1 = prog.Clone();
prog1.Nome = "Maria";
prog1.Cargo = "Desenvolvedora Senior";

Funcionario eng = new Engenheiro("Ednaldo", "Engenheiro Junior", "Engenheiro de produção");
Funcionario eng1 = eng.Clone();
eng.Nome = "Cristiano";
eng.Cargo = "Engenheiro Senior";

prog.ExibirInfo();
prog1.ExibirInfo();

eng.ExibirInfo();
eng1.ExibirInfo();