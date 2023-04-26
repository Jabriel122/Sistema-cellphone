// Faça em sua máquina utilizando os mesmos conceitos dado em aula.
// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

namespace Sistema_De_Celular
{
    public class Celular1
    {
        // Atributos

        public string cor;

        public string modelo;

        public string tamanho;

        public Boolean ligado;

        public string nomeContato;
        public string NumeroContaro; 

        // Metodos 
        
        public Boolean ligar()
        {
            return ligado;
        }

         public Boolean desligar()
        {
            return ligado;
        }

        public string ligacao()
        {
            return nomeContato + NumeroContaro;
        
        }

        public string mnsg()
        {
            return nomeContato + NumeroContaro;
        }
    }
}