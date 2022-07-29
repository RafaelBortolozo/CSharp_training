# Curso C# e .NET

## SDK Version
```
.NET Core 3.1.421
```

## Comandos
Cria uma pasta como novo projeto
```
dotnet new console -o <NomeProjeto>
```

Cria uma pasta e especifica qual sdk usar (use "dotnet new console -h" para mais informações)
```
dotnet new console -o <NomeProjeto> -f <SDK>
```


Lista e instala todas as dependencias
```
dotnet restore
```


Inicia compilação
```
dotnet build
```


Limpa arquivos de cache
```
dotnet clean
```


Roda aplicação localmente
```
dotnet run   
```


Roda aplicação emum determinado ambiente de execução
```
dotnet run --environment=<Ambiente>
```


Cria arquivo .gitignore para postagem no github
```
dotnet new gitignore
```

Listar sdks instaladas
```
dotnet --list-sdks
```


## Curiosidades do C#
- Constantes: const int NOME_CONSTANTE = 0

- Variaveis com tipagem nao precisam iniciar com valor

- Tipo var é apenas um atalho pra não definir o tipo do valor atribuido

- Valores com null devem acompanhar um "?" no tipo da variavel, ex: int? idade = null

- Object aceita qualquer valor, mesmo comportamento do var em javascript

- Alias é um apelido do tipo, o int é um alias do Int32

- Variaveis built-in contem valor padrão

- É possível fazer conversão implicita somente quando o dado é compativel com o tipo, float aceita um inteiro.

- Conversão explicita precisa definir tipo do dado para conversão, int para uint

- Parse permite converter uma string para um valor tipado, int.Parse("100")

- Objeto Convert permite converter diversos tipos de dados, Convert.ToInt32("100")

- Operadores aritméticos: + | - | * | / 

- Operadores de atribuição: = | += | -= | *= | /= 

- Operadores de comparação: == | != | > | < | >= | <= 

- Operadores lógicos: && | || | !

- Ao passar parâmetros para métodos, deve-se definir a tipagem apenas no recebimento

- Atribuições com "=" criam uma cópia do valor e nao do endereço de memória, x = y, mas isso não acontece com alguns tipos de dados como Array

- Structs é um construtor para criar objeto customizável que nem em Java, composto por propriedades e metodos, podendo ser instanciado com "new"

- Enum é uma forma inteligente de numerar itens ao invés de usar um simples int comentando o seu significado.