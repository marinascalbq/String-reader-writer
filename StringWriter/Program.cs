

   string textReaderTexto = "TextReader é a classe base abstrata " +
              "de StreamReader e StringReader, que lê caracteres " +
              "de streams e strings, respectivamente.\n" +
              "Crie uma instância de TextReader para abrir um arquivo de texto " +
              "para ler um intervalo especificado de caracteres " +
              "ou para criar um leitor baseado em um fluxo existente.\n" +
              "Você também pode usar uma instância de TextReader para ler " +
              "texto de um armazenamento de suporte personalizado usando as mesmas " +
              "APIs que você usaria para uma string ou um fluxo.\n\n";

    Console.WriteLine($"TEXTO ORIGINAL: {textReaderTexto}");

    string linha, paragrafo = null;
    var sr = new StringReader(textReaderTexto);
        while (true)
          {
           linha = sr.ReadLine();
           if(linha != null)
          {
                paragrafo += linha + " ";
          }
        else
          {
           paragrafo += '\n';
            break;
          }

    }
    Console.WriteLine($"TEXTO MODIFICADO: {paragrafo}");
    int caractereLido;
    char caracterConvertido;

    var sw = new StringWriter();
    sr = new StringReader(paragrafo);

    while (true)
    {
        caractereLido = sr.Read();
        if(caractereLido == -1) break;

        caracterConvertido = Convert.ToChar(caractereLido);

        if(caracterConvertido == '.')
        {
            sw.Write("\n");

            sr.Read();
            sr.Read();
        }
        else{

            sw.Write(caracterConvertido);
            
        }
    }
    Console.WriteLine($"TEXTO ARMAZENADO NO STRINGWRITER: {sw.ToString()}");
    Console.WriteLine("\n\nDigite [enter] para finalizar...");
    Console.ReadLine();

