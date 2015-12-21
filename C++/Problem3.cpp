#include <stdio.h>

int main() {
    __int64 num = 600851475143;
    int factor = 2;
    while (num > factor) {
        while (num % factor == 0) {
            num /= factor;
        }
        factor++;
    }

    printf("%d\n", num);
    return 0;
}
