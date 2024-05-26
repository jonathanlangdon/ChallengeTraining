// give ways to convert strings to number

// export const stringToNumber = (str: string): number => parseInt(str);
// export const stringToNumber = (str: string): number => parseFloat(str);
// export const stringToNumber = (str: string): number => Number(str);
export const stringToNumber = (str: string): number => +str;

console.log(typeof stringToNumber('38'));
