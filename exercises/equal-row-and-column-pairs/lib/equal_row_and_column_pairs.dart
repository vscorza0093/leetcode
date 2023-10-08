import 'dart:collection';

class Solution {
  int equalPairs(List<List<int>> grid) {
    Map<String, int> mapRow = HashMap();
    Map<String, int> mapColumn = HashMap();
    String strrow = '';
    String strcolumn = '';
    int count = 0;
    for (var row in grid) {
      strrow = '';
      for (var point in row) {
        strrow += point.toString();
      }
      if (mapRow.containsKey(strrow)) {
        mapRow[strrow] = mapRow[strrow]! + 1;
      } else {
        mapRow.addAll({strrow: 1});
      }
    }

    for (var i = 0; i < grid.length; i++) {
      strcolumn = '';
      for (var j = 0; j < grid.length; j++) {
        strcolumn += grid[j][i].toString();
      }
      if (mapColumn.containsKey(strcolumn)) {
        mapColumn[strcolumn] = mapColumn[strcolumn]! + 1;
      } else {
        mapColumn.addAll({strcolumn: 1});
      }
    }
    for (var key in mapRow.keys) {
      if (mapColumn.containsKey(key)) {
        //print("$key ${mapRow[key]}");
        //print("$key ${mapColumn[key]}");
        count = count + (mapColumn[key]! - 1) + (mapRow[key]!);
      }
    }

    print(mapRow);
    print(mapColumn);
    return count;
  }
}
