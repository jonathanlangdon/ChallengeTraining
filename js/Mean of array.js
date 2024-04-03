const getAverage = arr => Math.floor(arr.reduce((acc, cur) => acc + cur, 0) / arr.length);

/*It's the academic year's end, fateful moment of your school report. The averages must be calculated. All the students come to you and entreat you to calculate their average for them. Easy ! You just need to write a script.

Return the average of the given array rounded down to its nearest integer.

The array will never be empty. */
