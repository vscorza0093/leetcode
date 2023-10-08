class Solution {
  int numToFind = 6;
  int response = 0;

  int guessNumber(int n) {
    return findNumber(0, n);
  }

  int findNumber(int min, int max) {
    //n tem que ser calculado a partir do min e max
    int n = (max - min) ~/ 2 + min;
    if (guess(n) == '0') {
      return n;
    }
    if (guess(n) == '-1') {
      return findNumber(min, n);
    }
    return findNumber(n, max);
  }

  String guess(int guess) {
    if (guess > numToFind) {
      return '-1';
    } else if (guess < numToFind) {
      return '1';
    } else {
      return '0';
    }
  }
}
