import 'dart:collection';

class Solution {
  bool uniqueOcurences(List<int> arr) {
    Map<int, int> map = HashMap();
    Map<int, int> finalMap = HashMap();
    for (var element in arr) {
      if (map.containsKey(element)) {
        map[element] = map[element]! + 1;
      } else {
        map.addAll({element: 1});
      }
    }
    for (var value in map.values) {
      if (finalMap.containsKey(value)) {
        return false;
      } else {
        finalMap.addAll({value: 1});
      }
    }
    return true;
  }
}
