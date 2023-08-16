// See https://aka.ms/new-console-template for more information
using _08_conexaoBD;

//ConexaoSimples conexaoSimples = new ConexaoSimples();

ConexaoFlexivel conexaoFlexivel = new ConexaoFlexivel();
conexaoFlexivel.executaQuery("SELECT * FROM tarefas");
conexaoFlexivel.executaQuery("SELECT * FROM tarefas WHERE id = 4;");
conexaoFlexivel.executaQuery("SELECT * FROM tarefas WHERE descricao LIKE '%tud%';");
conexaoFlexivel.executaQuery("SELECT * FROM tarefas WHERE id;");

Console.ReadKey();