// See https://aka.ms/new-console-template for more information
using SuperClean;


// criacao de um Piso
Piso p0 = new Piso();

p0.setName("Piso 0 ");

// Criacao de  Compartimento de um determinado Piso
/*
Divisao d12 = new Divisao(1,"Garagem",20,25);
Divisao d13 = new Divisao(2, "Dispensa",11,23);
*/

/* Criacao de  Compartimento de um determinado Piso e
 adicao de compartimento no Piso 0 */

p0.addDivisao(new Divisao(1, "Garagem", 20, 25));
p0.addDivisao(new Divisao(2, "Dispensa", 11, 23));

// Listar todos compartimento de um Piso

//p0.MostrarPiso();





// criacao de um Piso
Piso p1 = new Piso();
p1.setName("Piso 1");

/* Criacao de  Compartimento de um determinado Piso */
/*
Divisao d1 = new Divisao(1, "quarto 1",12,10);
Divisao d2 = new Divisao(2,"quarto 2",13,16);
Divisao d3 = new Divisao(3,"sala",9,5);
Divisao d4 = new Divisao(4,"wc",15,19);
*/
/* Criacao de  Compartimento de um determinado Piso e
 adicao de compartimento no Piso 1 */
p1.addDivisao(new Divisao(1, "quarto 1", 12, 10));
p1.addDivisao(new Divisao(2, "quarto 2", 13, 16));
p1.addDivisao(new Divisao(3, "sala", 9, 5));
p1.addDivisao(new Divisao(4, "wc", 15, 19));


// Listar todos compartimento de um Piso

//p1.MostrarPiso();



// criacao de residencia  e adicao de pisos

Residencia r1= new Residencia();
r1.setUsername("Elson123");
r1.addPiso(p0);
r1.addPiso(p1);

r1.mostrarResidencia(); ;














