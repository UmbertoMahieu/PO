
struct Voiture {
    public int roues;
    public int puissance;
    public couleur couleur;
    public double compteur;
    public carburant carburant;
    public Modele modele;


    public Voiture (int roues, int puissance, couleur couleur, double compteur, carburant carburant, marque marque, int annee)
    {
        this.roues = roues;
        this.puissance = puissance;
        this.couleur = couleur;
        this.compteur = compteur;
        this.carburant = carburant; 
        this.modele = new Modele(marque, annee);
       
    }

    public void rouler(int km){
        compteur = compteur + km;
    }

    public override string ToString(){
        return "La voiture a" + " " + roues + " " + "roues," + " " + puissance + " " + "chevaux," + " " + "est de couleur" + " " + couleur + ", " + compteur + "km" + " " + "et utilise comme carburant ceci :" + " " + carburant + ". " + "et le modèle est " + modele;
    }
}


struct Modele {
    public marque nom;
    public int annee;

    public Modele (marque nom, int annee){
        this.nom = nom;
        this.annee = annee;
    }
}


    enum marque 
    {
        Volkswagen,
        Audi
    }


    enum carburant 
    {
        Electrique,
        Diesel,
        Essence
    }

    enum couleur 
    {
        Vert,
        Rouge,
        Noir

    }

