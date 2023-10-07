// ignore_for_file: non_constant_identifier_names
import 'dart:collection';
import 'dart:ffi';

class Solution {
  List<List<int>> findDifference(List<int> a, List<int> b) {
    var resp = getAnswer(a, b);

    return resp;
  }

  List<List<int>> getAnswer(List<int> a, List<int> b) {
    Map<int, int> mapA = HashMap();
    Map<int, int> mapB = HashMap();

    List<List<int>> answer = <List<int>>[[], []];
    for (var elementA in a) {
      mapA[elementA] = elementA;
    }
    for (var elementB in b) {
      mapB[elementB] = elementB;
    }

    for (var elementA in mapA.keys) {
      (mapB[elementA] ?? answer[0].add(elementA));
    }

    for (var elementB in mapB.keys) {
      (mapA[elementB] ?? answer[1].add(elementB));
    }
    return answer;
  }
}
