// Quantidade de termos solicitada
int qtdeTermo = 1_000_000;

/*
 * Foi necessário utilizar tipo integral 'long' pois usando 
 * 'int' em algum momento o programa congela, aparentemente isso ocorre 
 * quando o valor númerio solicitado passa do conjunto de 32 bits e assim
 * foi necessário utilizar um conjunto de 64 bits 
 */

// Dados para o comprimento da amostra
long comprimentoSequencia = 0;
long inicioAmostra = 0;

// Referencia para sequencias
long sequencia;

for (int i = 2; i <= qtdeTermo; i++) {
    int comprimento = 1;
    sequencia = i;
    while (sequencia != 1) {
        if ((sequencia % 2) == 0) {
            sequencia = sequencia / 2;
            }
        else {
            sequencia = sequencia * 3 + 1;
            }
        comprimento++;
        }

    // Verificando solução
    if (comprimento > comprimentoSequencia) {
        comprimentoSequencia = comprimento;
        inicioAmostra = i;
        }
    //Console.WriteLine ( comprimentoSequencia );
    //Console.WriteLine ( inicioAmostra );
    Console.WriteLine ("Processando, aguarde...");
    Console.Clear ();
    }
Console.WriteLine ($"O número inicial entre 1 e 1 milhão é {inicioAmostra} com {comprimentoSequencia} termos.");
