#include <stdio.h>

int main() {
    int a = 1, b = 2, sum = 0;

    while (b <= 4000000) {
        if (b % 2 == 0) {
            sum += b;
        }

        int temp = a + b;
        a = b;
        b = temp;
    }

    printf("%d\n", sum);

    return 0;

}
