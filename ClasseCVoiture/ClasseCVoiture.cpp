/*******************************************************
Nom           : ClasseCVoiture.cpp
Role          : Dev de la classe CVoiture et tests
Auteur        : Olivier Dumange
Date          : 17/09/2025
Version       : V1.0
Licence       : GPL
IDE           : VS2022
OS            : Windows 10 Education
Compilation   : 
********************************************************/

#include <iostream>
#include "voiture.h"

void testPointeurs()
{
    CVoiture *pVoiture = new CVoiture("PEUGEOT", "205", 4, "SP98");

    if (pVoiture != NULL)
    {
        pVoiture->demarrer();
        pVoiture->affiche();
        pVoiture->accelerer(20);
        pVoiture->affiche();
        pVoiture->ralentir(10);
        pVoiture->affiche();
        pVoiture->arreter();

        delete pVoiture;
    }
}

int main() {
    // Création d'un objet CVoiture
   
    /* impossible d'instancier voiture1 ainsi ici car pour "construire" l'objet, il
      faut passer la valeur des paramètres pour initialiser les attribut */
    //CVoiture voiture1;

    /* instanciation avec le constructeur appelé automatiquement avec la valeur omise pour la vitesse
    qui est un paramètre avec une valeur par défaut sinon ce sera ce genre d'instanciation :
    CVoiture voiture1("PORSCHE", "911", 37, "SP95-E10",10);  pour une vitesse initiale à 10 km/h  */
    CVoiture voiture1("PORSCHE", "911", 37, "SP95-E10");
    // Affichage initial
    voiture1.affiche();

    // Simulation d'une conduite et vérification par affichage
    voiture1.demarrer();
    voiture1.affiche();
    voiture1.accelerer(30);
    voiture1.affiche();
    voiture1.ralentir(15);
    voiture1.affiche();
    voiture1.arreter();

    // Affichage final
    voiture1.affiche();

    return 0;
}