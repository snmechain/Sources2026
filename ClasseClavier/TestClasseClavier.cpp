// Test de la classe

// entete

#include "Clavier.h"

void main()
{
	// création d'un objet 
	// instanciation de la classe

	CClavier ClavierAzerty; // objet ou instance de la classe
	//							CClavier

	// appel des méthodes
	ClavierAzerty.allumer();
	ClavierAzerty.taper();
	ClavierAzerty.verrouiller();
	ClavierAzerty.eteindre();
}