// Lampe_Interrupteur.cpp : Ce fichier contient la fonction 'main'. L'exécution du programme commence et se termine à cet endroit.
//
#include "Lampe.h"
#include "Interrupteur.h"

#include <iostream>

int main()
{
    CLampe maLampe;
    CInterrupteur monInterrupteur(&maLampe); // association de la lampe avec son interrupteur 

    monInterrupteur.ouvrir();  // Allume la lampe
    monInterrupteur.ouvrir();  // Message : "La lampe est déjà allumée."
    monInterrupteur.fermer();  // Éteint la lampe
    monInterrupteur.fermer();  // Message : "La lampe est déjà éteinte."

    return 0;
}

