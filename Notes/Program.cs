// See https://aka.ms/new-console-template for more information


int a = 3;
bool A = true;
int b, c, d;
b = 2;
c = 3;
d = 4;

Console.WriteLine("Hello, World!");
Console.WriteLine(a);
Console.WriteLine(A);

class Exemple {
    int a, b, c;
    void AssignVarA(){
        a = 2;
        int d = 3;
        Console.WriteLine(a);
    }

    void AssignVarB(){
        int d = 4; 
        b = 3;
    }

// concaténer 

    static int RunExemples(){
    var c = "A";
    var c1;

    Console.WriteLine(c + c1);
    Console.WriteLine("{0}{1}", c, c1);
    return a;
}
}

// to string, transformer une valeur en string

int v = 2;
string n = v.ToString();
Console.WriteLine(v);

// Convert.To(Type), transformer une valeur dans un autre type

 int a = Convert.ToInt32("2");

 Console.WriteLine(a);

 // Tenter de lire une rentrée utilisateur et la transformer dans un autre type. 
 // TryParse dit si oui ou non la variable peut etre mise en int, si oui Response devient Oui, puis met la variable dans C

 int c;
 var response = int.TryParse(Console.ReadLine(), out c);



