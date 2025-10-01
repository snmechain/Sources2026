#pragma once
#include <iostream>
using namespace std;

class CLampe {
private:
    bool allumee;
public:
    CLampe();
    ~CLampe();
    void allumer();
    void eteindre();
    bool estAllumee() const;
};
