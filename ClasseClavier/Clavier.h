#pragma once
#include <string>
#include <iostream>
 // entete

using namespace std;

class CClavier 
{
	// attributs
private :
	char touche;
	string marque;
	int nbTouches;
	string type; // (AZERTU ou QWERTY etc)

public :
	void taper();
	void verrouiller();
	void allumer();
	void eteindre();
};

