// Usando o continue e o Break 

var i = 1;
while (i <=10) {

	var y = 1;
	while(y <= 10) {
		
		if(y != 7 && y != 8 && y != 9) {// Neste caso estou pedindo para o meu console não exibir os numeros 7, 8, 9
		
		Console.WriteLine($"{i} * {y} = {i * y}");

		} 
		y++;
	}
	i++;
}

// outra maneira de fazer a quebra na na programação 

var i = 1;
while (i <=10) {

	var y = 1;
	while(y <= 10) {
		
		if(y == 7 || y == 8 || y == 9) {// Neste caso estou pedindo para o meu console não exibir os numeros 7, 8, 9
		
			y++;
			
			continue;
			
		} 

		Console.WriteLine($"{i} * {y} = {i * y}");
		y++;
	}
	i++;
}


//EXERCICIO

// CRIA UMA ARRAY COM 2 POSIÇÕES DE INTEIROS E ARMAZENAR EM UMA VARIAVEL E SOMA TOTAL DA LISTA.
// A VARIAVEL DEVE SER IMPRIMIDO NO CONSOLE.

var lista = new int[7];
lista[0] = 4;
lista[1] = 4;
lista[2] = 4;
lista[3] = 4;
lista[4] = 4;
lista[5] = 4;
lista[6] = 4;
var resultado = 0;

for(var i = 0; i < lista.Count(); i++) {
	resultado = resultado = resultado = resultado = resultado = resultado = resultado + lista[i]; 
	 // neste caso a soma seria 1x4 até 7x4 
}

Console.WriteLine($"Resultado é {resultado}");



//Dado uma lista com os itens "2, 8, 3, 10, 5, 4, 7, 9, 1" que vão de 1 a 10, efetuar a soma em duas 
// variaveis, o  primeiro numero de 1 a 5 e o segundo de 6 a 10. imprimir os dois resultados. 

var lista = new List<int>() {2, 8, 3, 10, 5, 4, 7, 9, 1};
	
var subListaMenorIgual5 = lista.Where(l => l <= 5);
var resultado1 = 0;
foreach(var item in subListaMenorIgual5){
	resultado1 += item;
} 
Console.WriteLine($"Resultado 1 é {resultado1}");

// parte dois do exercicio

var subListaMaiorIgual6 = lista.Where(l => l >= 6);
var resultado2 = 0;
foreach(var item in subListaMaiorIgual6){
	resultado2 += item;
} 
Console.WriteLine($"Resultado 1 é {resultado2}");
