function solve(params) {
  var arrayRows = parseInt(params[0].split(' ')[0]);
  var arrayCols = parseInt(params[0].split(' ')[1]);
  var startPositionRow = parseInt(params[1].split(' ')[0]);
  var startPositionCol = parseInt(params[1].split(' ')[1]);
  var result;

  params.shift();
  params.shift();

  var directionArray = generateDirectionArray(params);
  var pointsArray = generatePointArray(arrayRows, arrayCols);
  var me = {
    position: {
      row: startPositionRow,
      col: startPositionCol
    },
    sum: 0,
    cellsCount: 0,
    changePosition: function (direction) {
      switch (direction) {
        case 'l': this.position.col -= 1; break;
        case 'r': this.position.col += 1; break;
        case 'u': this.position.row -= 1; break;
        case 'd': this.position.row += 1; break;
      }
    }
  };
  var success = false;

  while (true) {
    if (me.position.row < 0 || me.position.col < 0 || me.position.row >= arrayRows || me.position.col >= arrayCols) {
      success = true;
      break;
    }

    if (pointsArray[me.position.row][me.position.col] === 0) {
      break;
    }

    me.sum += pointsArray[me.position.row][me.position.col];
    me.cellsCount += 1;
    pointsArray[me.position.row][me.position.col] = 0;
    me.changePosition(directionArray[me.position.row][me.position.col]);
  }

  if (success) {
    result = 'out ' + me.sum;
  } else {
    result = 'lost ' + me.cellsCount;
  }
  
  return result;

  function generateDirectionArray(input) {
    return params.map(function (item) {
      return item.split('');
    });
  }

  function generatePointArray(rows, cols) {
    var result = [];
    var cellValue = 1;

    for (var row = 0; row < rows; row += 1) {
      var currentRow = [];

      for (var col = 0; col < cols; col += 1) {
        currentRow.push(cellValue++);
      }

      result.push(currentRow);
    }

    return result;
  }
}