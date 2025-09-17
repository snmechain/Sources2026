/*******************************************************
Nom           : voiture.h
Role          : Déclaration de la classe CVoiture
Auteur        : Olivier Dumange
Date          : 17/09/2025
Version       : V1.0
Licence       : GPL
IDE           : VS2022
OS            : Windows 10 Education
Compilation   :
********************************************************/

#include <iostream>
using namespace std;

/**
 * @class CVoiture
 * @brief Classe représentant une voiture avec ses caractéristiques et son comportement.
 */
class CVoiture {
public:
    /// Marque de la voiture
    string marque;

    /// Modèle de la voiture
    string modele;

    /// Puissance en chevaux
    int puissance;

    /// Type de carburant
    string carburant;

    /// Vitesse actuelle de la voiture en km/h
    int vitesse;

    /**
     * @brief Initialise les attributs de la voiture.
     * @param m Marque
     * @param mod Modèle
     * @param p Puissance
     * @param c Carburant
     */
    void init(string m, string mod, int p, string c);

    /**
     * @brief Affiche les informations de la voiture.
     */
    void affiche();

    /**
     * @brief Démarre la voiture et initialise la vitesse à 10 km/h.
     */
    void demarrer();

    /**
     * @brief Arrête la voiture et met la vitesse à 0.
     */
    void arreter();

    /**
     * @brief Accélère la voiture.
     * @param valeur Valeur en km/h à ajouter à la vitesse actuelle
     */
    void accelerer(int valeur);

    /**
     * @brief Ralentit la voiture.
     * @param valeur Valeur en km/h à soustraire à la vitesse actuelle
     */
    void ralentir(int valeur);
};