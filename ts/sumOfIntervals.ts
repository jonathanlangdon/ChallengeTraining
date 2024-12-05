// find sum of the interval lengths of an array of intervals while removing overlaps

function sumOfIntervals(intervals: [number, number][]) {
  
  intervals.sort((a, b) => a[0] - b[0]);
  // console.log("sorted intervals: " + JSON.stringify(intervals));

  let currentIntervalStart: number = intervals[0][0];
  let currentIntervalEnd: number = intervals[0][1];
  let merged: [number, number][] = [];

  for (let i = 0; i < intervals.length; i++) {
    const thisIntervalStart: number = intervals[i][0];
    const thisIntervalEnd: number = intervals[i][1];
    
    if (thisIntervalEnd > currentIntervalEnd) {
      currentIntervalEnd = thisIntervalEnd;
    }

    if (i === intervals.length - 1) {
      merged.push([currentIntervalStart, currentIntervalEnd])
      break;
    }

    const nextIntervalStart: number = intervals[i + 1][0];
    const nextIntervalEnd: number = intervals[i + 1][1];

    if (currentIntervalEnd >= nextIntervalStart) {
      continue;
    }
    else {
      merged.push([currentIntervalStart, currentIntervalEnd]);
      currentIntervalStart = intervals[i + 1][0];
    }
    
  }

  // console.log("merged intervals: " + JSON.stringify(merged));
  return merged.reduce((a: number, [start, end]) => a + Math.abs(end - start), 0);
}


console.log(sumOfIntervals([[1, 5]]))                           // 4;
console.log(sumOfIntervals([[1, 5], [1, 5]]))                   // 4;
console.log(sumOfIntervals([[3, 4], [1, 5]]))                   // 4;
console.log(sumOfIntervals([[1, 4], [7, 10], [3, 5]]))          // 7);
console.log(sumOfIntervals([[1, 5], [6, 10]]))                  // 8;
console.log(sumOfIntervals([[1, 1], [6, 10], [11, 15]]))        // 8;
console.log(sumOfIntervals([[1, 5], [10, 20], [1, 6], [16, 19], [5, 11]])) // 19);
console.log(sumOfIntervals([[-131,-5],[152,450]]))        // 424;
console.log(sumOfIntervals([[-441,-123],[-361,409],[84,343],[223,441],[302,395],[342,350],[395,480],[415,472]]))  // 921;
console.log(sumOfIntervals([[-1e9, 1e9]]))                     // 2e9);
console.log(sumOfIntervals([[0, 20], [-1e8, 10], [30, 40]]))   // 1e8 + 30);

