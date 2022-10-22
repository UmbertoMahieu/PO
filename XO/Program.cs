// //1. Demander 2 valeurs via console et la multiplier

// int a = int.Parse(Console.ReadLine());

// int b = int.Parse(Console.ReadLine());

// Console.WriteLine(a + b); 

// //2. Demander une valeur via console et dire si pair ou pas

// int a = int.Parse(Console.ReadLine());

// if (a%2 == 0){
//     Console.WriteLine("Ce nombre est pair");
// }
// else {
//     Console.WriteLine("Ce nombre est impair");
// }

// //3. Diviser 5/2, faire le modulo ou divise 5/2 avec résultat virgule 

// Console.WriteLine(5 / 2);
// Console.WriteLine(5%2);
// Console.WriteLine(5F / 2);

// //4. Vérifier la validité du compte bban (le modulo des 10 premiers chiffres par 97 doit valoir les deux derniers)

// var bban = "68539007547034";
// if (Int64.Parse(bban.Substring(0,10)) % 97 == int.Parse(bban.Substring(11,2))){
//     Console.WriteLine("OK");
// }
// else {
//     Console.WriteLine("KO");
// }

// // 5. Calculer les 25 premiers nombres de la suite de Fibonacci

// int mem = 1;
// int fib = 1;
// int result = 0;
// int i = 0;

// while (i < 25){
//     i++;
//     result = mem + fib;
//     mem = fib;
//     fib = result;
//     Console.WriteLine(result);
// }

// // 6. Calculer le factoriel d'un nombre entré au clavier

// int nmbre = int.Parse(Console.ReadLine());
// int fac = 1;
// for (int j = 1 ; j < nmbre + 1 ; j++){
//     fac = fac * j;
// };

// Console.WriteLine(fac);

// // 7. Grâce à une boucle for, calculez les x premiers nombres premiers

// bool prime(int n){
//     if (n < 2) return false;
//     for (int i = 2 ; i < n ; i++){
//         if (n % i == 0){
//             return false;
//         }
//     }
//     return true; 
// };

// int x = int.Parse(args[0]);

// Console.WriteLine(prime(x));

Voiture v1 = new Voiture(4, 200, couleur.Noir, 0, carburant.Electrique, marque.Audi, 1999);
Voiture v2 = new Voiture(2, 100, couleur.Vert, 150, carburant.Diesel, marque.Volkswagen, 2001);
Voiture v3 = new Voiture(3, 70, couleur.Rouge, 12.5, carburant.Essence, marque.Audi, 2010);

Console.WriteLine(v1);

v1.rouler(20);

Console.WriteLine(v1);



