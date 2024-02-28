public class WhatCentury {
  public static int century(int number) {
    return (int) Math.ceil(number / 100.0);
  }

  public static void main(String[] args) {
    System.out.println(century(1901));
  }
}