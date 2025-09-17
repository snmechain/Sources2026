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

int main() {
    // Création d'un objet CVoiture
    CVoiture voiture1;

    // Initialisation des attributs
    voiture1.init("Toyota", "Corolla", 132, "Essence");

    // Affichage initial
    voiture1.affiche();

    // Simulation d'une conduite
    voiture1.demarrer();
    voiture1.accelerer(30);
    voiture1.ralentir(15);
    voiture1.arreter();

    // Affichage final
    voiture1.affiche();

    return 0;
}