function solve(params) {
  var array = params.map(Number);
  var result;

  array.shift();

  result = getMaxSum(array);

  return result;

  function getMaxSum(array) {
    var maxSum;

    for (var i = 0; i < array.length; i += 1) {
      var currentSum = array[i];

      if (!maxSum || currentSum > maxSum) {
        maxSum = currentSum;
      }

      for (var j = i + 1; j < array.length; j += 1) {
        currentSum += array[j];

        if (currentSum > maxSum) {
          maxSum = currentSum;
        }
      }
    }

    return maxSum;
  }
}