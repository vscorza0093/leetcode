Console.WriteLine(GuessNumber(2126753390));

int GuessNumber(int n) {
    return findNumber(1, n);
}

int findNumber(int min, int max) {
    int n = max;
    if (guess(n) == 0) {
        return n;
    }
    n = ((max - min) / 2) + min; 
    Console.WriteLine(n);
    if (guess(n) == -1) {
        return findNumber(min, n);
    } else if (guess(n) == 1) {
        return findNumber(n, max);
    }
    return n;
}

int guess(int n) { 
    int numToFind = 1702766719;
    if (n == numToFind){
        return 0;
    } else if (n > numToFind) {
        return -1;
    } else {
        return 1;
    }
}