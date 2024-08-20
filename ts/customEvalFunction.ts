//

export function calc(expression: string): number {
  const noSpaceExp: string = expression.replace(/\s/g, '');
  return Number(evaluatePMDAS(noSpaceExp));
}

function evaluatePMDAS(exp: string): string {
  let nextExp: string = evaluateParenthesis(exp);
  nextExp = evaluateMultiplyDivide(nextExp);
  nextExp = evaluateAddSub(nextExp);
  return nextExp;
}

function evaluateParenthesis(exp: string): string {
  if (!exp.includes('(')) return exp;
  let resultExp: string = '';
  let isParsingParenthesis: boolean = false;
  let insideParenthesis: string = '';
  for (let i = 0; i < exp.length; i++) {
    if (exp[i] === '(') {
      isParsingParenthesis = true;
    } else if (exp[i] === ')') {
      isParsingParenthesis = false;
      resultExp += evaluatePMDAS(insideParenthesis);
      insideParenthesis = '';
    } else if (isParsingParenthesis) {
      insideParenthesis += exp[i];
    } else {
      resultExp += exp[i];
    }
  }
  return resultExp;
}

function evaluateMultiplyDivide(exp: string): string {
  if (!/[*/]/.test(exp)) return exp;
  let newExp = exp.replace(/\d+[*/]\d+/, match => {
    const terms: string[] = match.split(/[*/]/);
    let result: number = 0;
    if (match.includes('*')) {
      result = Number(terms[0]) * Number(terms[1]);
    } else {
      result = Number(terms[0]) / Number(terms[1]);
    }
    return String(result);
  });
  return evaluateMultiplyDivide(newExp);
}

function evaluateAddSub(exp: string): string {
  if (!/[+-]/.test(exp)) return exp;
  let newExp = exp.replace(/\d+[+-]\d+/, match => {
    const terms: string[] = match.split(/[+-]/);
    let result: number = 0;
    if (match.includes('+')) {
      result = Number(terms[0]) + Number(terms[1]);
    } else {
      result = Number(terms[0]) - Number(terms[1]);
    }
    return String(result);
  });
  return evaluateAddSub(newExp);
}

// console.log(evaluateAddSub("3+8-4")); // 7
// console.log(evaluateParenthesis("5+(3)")); // 5+3
// console.log(evaluateMultiplyDivide("5+2")); // 5+2
// console.log(evaluateMultiplyDivide("5*6/2")); // 15
// console.log(evaluateMultiplyDivide("3+5*6/2+2")); // 3+15+2
// console.log(calc('10 + 20 * 3 / 2 - 5')); // 35
// console.log(calc('2 / (2 + 3) * 4.33 - -6')); // 7.732
console.log(calc('1+1')); // 2
console.log(calc('1 - 1')); // 0
console.log(calc('1* 1')); // 1
console.log(calc('4 + 3 * 10 - 4 / 2')); // 32
// console.log(calc('1* -3')); // -3
// console.log(calc('-2* -3')); // 6
// console.log(calc('1 /1')); // 1
// console.log(calc('-123')); // -123
// console.log(calc('123')); // 123
// console.log(calc('2 /2+3 * 4.75- -6')); //21.25 ####
// console.log(calc('12* 123')); // 1476
