// remove all spaces in string

export function noSpace(x: string): string {
  return x.replace(/\s/g, '');
}

console.log(noSpace('8 j 8   mBliB8g  imjB8B8  jl  B')); // 8j8mBliB8gimjB8B8jlB
