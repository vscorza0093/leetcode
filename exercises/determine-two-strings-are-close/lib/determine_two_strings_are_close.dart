import 'dart:collection';

class Solution {
  static bool closeStrings(String word1, String word2) {
    Map<int, int> mapA = HashMap();
    Map<int, int> mapB = HashMap();
    Map<int, int> mapC = HashMap();
    Map<int, int> mapD = HashMap();

    if (word1.length != word2.length) {
      return false;
    }
    word1.runes.forEach((element) {
      if (mapA.containsKey(element)) {
        mapA[element] = mapA[element]! + 1;
      } else {
        mapA.addAll({element: 1});
      }
    });
    word2.runes.forEach((element) {
      if (mapB.containsKey(element)) {
        mapB[element] = mapB[element]! + 1;
      } else {
        mapB.addAll({element: 1});
      }
    });
    print(mapA);
    print(mapB);

    for (var key in mapA.keys) {
      if (mapB.containsKey(key)) {
        continue;
      } else {
        return false;
      }
    }
    for (var value in mapA.values) {
      if (mapC.containsKey(value)) {
        mapC[value] = mapC[value]! + 1;
      } else {
        mapC.addAll({value: 1});
      }
    }
    for (var value in mapB.values) {
      if (mapD.containsKey(value)) {
        mapD[value] = mapD[value]! + 1;
      } else {
        mapD.addAll({value: 1});
      }
    }
    if (mapC.length != mapD.length) {
      return false;
    } else {
      for (var key in mapC.keys) {
        if (mapD.containsKey(key)) {
          if (mapD[key] == mapC[key]) {
            continue;
          } else {
            return false;
          }
        } else {
          return false;
        }
      }
    }
    return true;
  }
}
