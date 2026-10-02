#include "Lampe.h"

CLampe :: CLampe()
{
    allumee = false;
}

CLampe :: ~CLampe()
{
}

void CLampe :: allumer() 
{
    if (!allumee) {
        allumee = true;
        std::cout << "Lampe allumee !" << std::endl;
    }
    else {
        std::cout << "La lampe est deja allumee." << std::endl;
    }
}

void CLampe :: eteindre() 
{
    if (allumee) {
        allumee = false;
        std::cout << "Lampe eteinte." << std::endl;
    }
    else {
        std::cout << "La lampe est deja eteinte." << std::endl;
    }
}

bool CLampe :: estAllumee() const 
{ 
    return allumee;
}