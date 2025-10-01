#pragma once
#include "Lampe.h"

class CInterrupteur {
private:
    CLampe* lampe;
public:
    CInterrupteur(CLampe* l);
    ~CInterrupteur();
    void fermer();
    void ouvrir();
};