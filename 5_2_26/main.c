#include <stdio.h>
#include <stdlib.h>
#include <wchar.h>
#include <ctype.h>

void duze(char* nap) {
    for(int i = 0; *(nap+i) != 0; i++) {
        *(nap+i) = toupper(*(nap+i));
    }
}

void duze_w(wchar_t* nap) {
    int i = 0;
    while(*(nap+i)) {
        if(*(nap+i) > 90) {
            *(nap+i) = toupper(*(nap+i));
        }
        i++;
    }
}

int main()
{
    char nap[] = "CounTerStrike";
    wchar_t nap2[] = L"GothIC";
    printf("%s\n", nap);
    duze(nap);
    printf("%s\n", nap);
    wprintf(L"%s\n", nap2);
    duze_w(nap2);
    wprintf(L"%s\n", nap2);

    return 0;
}
