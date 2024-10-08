// fully solved!

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
  // grab and process by PMDAS everthing between 1st ")" and "(" before
  let parenthesisCount = 0;
  let insideExp = '';
  let evaluatedInside = '';
  for (let i = 0; i < exp.length; i++) {
    if (exp[i] === '(') {
      parenthesisCount += 1;
      insideExp = '';
    } else if (exp[i] === ')') {
      evaluatedInside = evaluatePMDAS(insideExp);
      break;
    } else if (parenthesisCount > 0) {
      insideExp += exp[i];
    }
  }
  let newExp = exp.replace('(' + insideExp + ')', evaluatedInside);
  // newExp.replace('--', '')
  //will return result of evaluations recursively, eventually giving an expression with no ()
  return evaluateParenthesis(newExp);
}

function evaluateMultiplyDivide(exp: string): string {
  if (!/[*/]/.test(exp)) return exp;
  let newExp = exp.replace(/-*\d+(\.\d+)?[*/]-*\d+(\.\d+)?/, multExp => {
    const negCountArr: string[] = multExp.match(/-/g) || [];
    const negCount: number = negCountArr ? negCountArr.length : 0;
    let isPositive = negCount === 1 ? false : true;
    const absExp = multExp.replace(/-/g, '');
    const terms: string[] = absExp.split(/[*/]/);
    let result: number = 0;
    if (absExp.includes('*')) {
      result = Number(terms[0]) * Number(terms[1]);
    } else {
      result = Number(terms[0]) / Number(terms[1]);
    }
    return String(result * (isPositive ? 1 : -1));
  });
  return evaluateMultiplyDivide(newExp);
}

function evaluateAddSub(exp: string): string {
  if (!/\d+(\.\d+)?[+-]/.test(exp)) return exp;
  let newExp = exp.replace(/-*\d+(\.\d+)?[+-]-*\d+(\.\d+)?/, addSubExp => {
    addSubExp = addSubExp.replace('+-', '-');
    const terms: string[] = [...(addSubExp.match(/[-+]*\d+(\.\d+)?/g) || [])];
    terms.forEach((term, index) => {
      const termNegArr: string[] = term.match(/-/g) || [];
      const negCount: number = termNegArr ? termNegArr.length : 0;
      let isPositive = negCount % 2 === 0;
      const absExp = term.replace(/-/g, '');
      if (!isPositive) {
        terms[index] = '-' + absExp;
      } else terms[index] = absExp;
    });
    const result: number = Number(terms[0]) + Number(terms[1]);
    return String(result);
  });
  return evaluateAddSub(newExp);
}

// console.log(calc("1 - -(-(-(-4)))")) // -3
// console.log(calc("(1 - 2) + -(-(-(-4)))")); // 3
// console.log(evaluateParenthesis('((3+1)+(1+3))+2')); // 8+2
// console.log(evaluateParenthesis('(4+(1+3))+2')); // 8+2
// console.log(evaluateParenthesis('((3+1)+4)+2')); // 8+2
// console.log(evaluateParenthesis('(4+4)+2')); // 8+2
// console.log(evaluateParenthesis('(4+4)+(1+1)')); // 8+2
// console.log(evaluateMultiplyDivide("5*6/2")); // 15
// console.log(evaluateMultiplyDivide("5*-6/-2")); // 15
// console.log(evaluateMultiplyDivide("-5*6/2")); // -15
// console.log(evaluateMultiplyDivide("5*-6/2")); // -15
// console.log(evaluateMultiplyDivide("5*6/-2")); // -15
// console.log(evaluateMultiplyDivide("-5*-6/-2")); // -15
// console.log(evaluateAddSub('-3')); // -3
// console.log(evaluateAddSub('3')); // 3
// console.log(evaluateAddSub('-5-2')); // -7
// console.log(evaluateAddSub('5+6-2')); // 9
// console.log(evaluateAddSub('5+-6--2')); // 1
// console.log(evaluateAddSub('-5+6-2')); // -1
// console.log(evaluateAddSub('5+-6-2')); // -3
// console.log(evaluateAddSub('5+6--2')); // 13
// console.log(evaluateAddSub('-5+-6--2')); // -9
// console.log(evaluateAddSub('-5--6--2')); // 3
// console.log(evaluateAddSub('-5--6-1')); // 0
// console.log(evaluateAddSub("3+8-4")); // 7
// console.log(evaluateParenthesis("5+(3)")); // 5+3
// console.log(evaluateMultiplyDivide("5+2")); // 5+2
// console.log(evaluateMultiplyDivide("5*6/2")); // 15
// console.log(evaluateMultiplyDivide("3+5*6/2+2")); // 3+15+2
// console.log(calc('10 + 20 * 3 / 2 - 5')); // 35
// console.log(calc('1+1')); // 2
// console.log(calc('1 - 1')); // 0
// console.log(calc('1* 1')); // 1
// console.log(calc('4 + 3 * 10 - 4 / 2')); // 32
// console.log(calc('1* -3')); // -3
// console.log(calc('-2* -3')); // 6
// console.log(calc('1 /1')); // 1
// console.log(calc('-123')); // -123
// console.log(calc('123')); // 123
// console.log(calc('12* 123')); // 1476
// console.log(calc('2 /2+3 * 4.75- -6')); //21.25
// console.log(calc('2 / (2 + 3) * 4.33 - -6')); // 7.732
// console.log(calc('((2 + 3) * (4 - 2)) * (1 + 2)')); // 30
// console.log(calc('(-2 + 3) * (-4 - -6)')); // 2
// console.log(calc('((2 - 3) * (4 + 5)) + -1')); // -10
// console.log(calc('2 * (3 + (4 * 5)) - (6 / 2)')); // 43
// console.log(calc('(((1 + 2) * 3) + 4) * 5')); // 65
// console.log(calc('5+-3*2')); // -1
// console.log(calc('10/2*-3+4')); // -11
// console.log(calc('0*3 + 5')); // 5
// console.log(calc('0/1')); // 0
// console.log(calc('0.1 + 0.2')); // 0.3
// console.log(calc('0.1 * 0.2')); // 0.02
// console.log(calc('1.2345 * 6.789')); // 8.3801905
// console.log(calc('1 + 2 - 3 * 4 / 5 + 6 * (7 + 8) - (9 * 10) / (11 + 12)')); // 86.687
// console.log(calc(' 3 +  5   * 2 ')); // 13
// console.log(calc('  3+5 *  2 ')); // 13
// console.log(calc('(((((10)))))')); // 10
// console.log(calc('((10) + ((5)))')); // 15
// console.log(calc('(((1 + 2) * 3) + (1 + 2)) * 5')); // 60
// console.log(calc("2*-3/-4*5")); // 7.5
// console.log(calc("2*3/4*5/6*7")); // 8.75
// console.log(calc("-2*-3/-4*-5")); // 7.5
// console.log(calc("3*-2*4/-2*2")); // 24
// console.log(calc("3*-2/-4*-2")); // 3
// console.log(calc("-2*-3*4/-5*6/-7*8")); // 32.3076923077...
// console.log(calc("2*2*2*2*2*2")); // 64
// console.log(calc("10/2/5/1")); // 1
// console.log(calc("0*3/1*2")); // 0
// console.log(calc("1*0/3*2")); // 0
// console.log(calc("0.2*0.5/0.1")); // 1
// console.log(calc("2.5*-1.5/3*4.2")); // -5.25
// console.log(calc("(2*-3)/(-4*5)")); // 0.3
// console.log(calc("((3*2)/4)*5")); // 7.5
// console.log(calc("((2*3)/4)*5/6")); // 1.25
// console.log(calc("(((2*-3)/4)*5)/(-6*7)")); // 0.178571...
// console.log(calc("1.23*4.56/7.89*0.12")); // 0.0853
// console.log(calc("2*3/4*5/6*7*8/9*10/11")); // 7.07070707070707
// console.log(evaluateMultiplyDivide('1476/--3')); // 492
// console.log(calc("12* 123/-(-5 + 2)")); // 492
