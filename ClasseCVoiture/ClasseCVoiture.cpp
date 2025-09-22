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

/* autres code à écrire dans la fonction main() pour manipuler les objets : 
Scénarios de test pour la fonction main()

Scénario 1 : Création et affichage initial

Créez 3 voitures différentes.

Initialisez leurs attributs avec init().

Affichez toutes les voitures avec affiche() pour vérifier que l’initialisation est correcte.

But : Vérifier que l’objet est correctement créé et initialisé.



Scénario 2 : Simulation de conduite

Pour chaque voiture :

Démarrez la voiture avec demarrer().

Accélérez de plusieurs valeurs avec accelerer(valeur).

Ralentissez avec ralentir(valeur).

Arrêtez la voiture avec arreter().

But : Tester le comportement dynamique et les changements de vitesse.



Scénario 3 : Comparaison des vitesses

Après la simulation, comparez les vitesses des voitures.

Affichez laquelle a la vitesse la plus élevée.

But : Utiliser les attributs pour prendre des décisions.



Scénario 4 : Test de limites

Accélérez au-delà d’une vitesse maximale hypothétique (ex: 200 km/h).

Ralentissez plus que la vitesse actuelle pour vérifier que la vitesse ne devient jamais négative.

But : Tester la robustesse des méthodes accelerer() et ralentir().



Scénario 5 : Filtrage conditionnel

Affichez uniquement les voitures qui sont en mouvement (vitesse > 0).

But : Tester les conditions et boucles avec des objets.

Scénario 6 : Tableau ou vecteur d’objets

Stockez plusieurs voitures dans un tableau ou un vecteur.

Parcourez le tableau pour appliquer des actions (démarrage, accélération, affichage)

But : Apprendre à manipuler plusieurs objets et boucles.

*/