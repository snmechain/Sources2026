#include "Interrupteur.h"

CInterrupteur::CInterrupteur(CLampe* l)
{
    lampe = l; 
}

CInterrupteur :: ~CInterrupteur()
{
    this->lampe = nullptr;
}

void CInterrupteur :: ouvrir() 
{
    if (!lampe->estAllumee()) 
    {
        lampe->allumer();
    }
    else {
        std::cout << "La lampe est deja allumee." << std::endl;
    }
}

void CInterrupteur :: fermer() {
    if (lampe->estAllumee()) {
        lampe->eteindre();
    }
    else {
        std::cout << "La lampe est deja eteinte." << std::endl;
    }
}
