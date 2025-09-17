/*******************************************************
Nom           : voiture.h
Role          : Implémentation des méthodes déportées
Auteur        : Olivier Dumange
Date          : 17/09/2025
Version       : V1.0
Licence       : GPL
IDE           : VS2022
OS            : Windows 10 Education
Compilation   :
********************************************************/


#include "voiture.h"

void CVoiture::init(string m, string mod, int p, string c) {
    marque = m;
    modele = mod;
    puissance = p;
    carburant = c;
    vitesse = 0; // voiture à l'arrêt
}

void CVoiture::affiche() {
    cout << "Voiture :" << endl;
    cout << "  Marque    : " << marque << endl;
    cout << "  Modèle    : " << modele << endl;
    cout << "  Puissance : " << puissance << " CV" << endl;
    cout << "  Carburant : " << carburant << endl;
    cout << "  Vitesse   : " << vitesse << " km/h" << endl;
}

void CVoiture::demarrer() {
    cout << "La voiture démarre." << endl;
    vitesse = 10; // vitesse initiale au démarrage
}

void CVoiture::arreter() {
    cout << "La voiture s'arrête." << endl;
    vitesse = 0;
}

void CVoiture::accelerer(int valeur) {
    vitesse += valeur;
    cout << "La voiture accélère de " << valeur << " km/h. Vitesse actuelle : " << vitesse << " km/h" << endl;
}

void CVoiture::ralentir(int valeur) {
    vitesse -= valeur;
    if (vitesse < 0) vitesse = 0;
    cout << "La voiture ralentit de " << valeur << " km/h. Vitesse actuelle : " << vitesse << " km/h" << endl;
}
