#include "hello.h"
void HelloFunc()
{
    printf("Message from native library\n");
}

int add(int a, int b)
{
    return a + b;
}