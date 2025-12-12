// remove all numbers from a string

using System;
using System.Text.RegularExpressions;
					
public class Program
{
	public class Kata
	{
	  public static string StringClean(string s)
	  {
 		return Regex.Replace(s, @"[\d]", "");
	  }
	}
	
	
	
	public static void Main()
	{
		Console.WriteLine("--- StringClean Output ---");
        // Input string and the result from Kata.StringClean()
        
        // Assert.That(Kata.StringClean(""), Is.EqualTo(""));
        Console.WriteLine($"\"\" -> \"{Kata.StringClean("")}\""); 
        
        // Assert.That(Kata.StringClean("! !"), Is.EqualTo("! !"));
        Console.WriteLine($"\"! !\" -> \"{Kata.StringClean("! !")}\""); 
        
        // Assert.That(Kata.StringClean("1234567890"), Is.EqualTo(""));
        Console.WriteLine($"\"1234567890\" -> \"{Kata.StringClean("1234567890")}\""); 
        
        // Assert.That(Kata.StringClean("Dsa32 cdsc34232 csa!!! 1I 4Am cool!"), Is.EqualTo("Dsa cdsc csa!!! I Am cool!"));
        Console.WriteLine($"\"Dsa32 cdsc34232 csa!!! 1I 4Am cool!\" -> \"{Kata.StringClean("Dsa32 cdsc34232 csa!!! 1I 4Am cool!")}\""); 
        
        // Assert.That(Kata.StringClean("A1 A1! AAA   3J4K5L@!!!"), Is.EqualTo("A A! AAA   JKL@!!!"));
        // Note: The original test likely has non-breaking spaces (U+00A0) which are preserved.
        Console.WriteLine($"\"A1 A1! AAA   3J4K5L@!!!\" -> \"{Kata.StringClean("A1 A1! AAA   3J4K5L@!!!")}\""); 
        
        // Assert.That(Kata.StringClean("Adgre2321 A1sad! A2A3A4 fv3fdv3J544K5L@"), Is.EqualTo("Adgre Asad! AAA fvfdvJKL@"));
        Console.WriteLine($"\"Adgre2321 A1sad! A2A3A4 fv3fdv3J544K5L@\" -> \"{Kata.StringClean("Adgre2321 A1sad! A2A3A4 fv3fdv3J544K5L@")}\""); 
        
        // Assert.That(Kata.StringClean("Ad2dsad3ds21 A 1$$s122ad! A2A3Ae24 f44K5L@222222 "), Is.EqualTo("Addsadds A $$sad! AAAe fKL@ "));
        Console.WriteLine($"\"Ad2dsad3ds21 A 1$$s122ad! A2A3Ae24 f44K5L@222222 \" -> \"{Kata.StringClean("Ad2dsad3ds21 A  1$$s122ad! A2A3Ae24 f44K5L@222222 ")}\""); 
        
        // Assert.That(Kata.StringClean("33333Ad2dsad3ds21 A3333 1$$s122a!d! A2!A!3Ae$24 f2##222 "), Is.EqualTo("Addsadds A $$sa!d! A!A!Ae$ f## "));
        Console.WriteLine($"\"33333Ad2dsad3ds21 A3333 1$$s122a!d! A2!A!3Ae$24 f2##222 \" -> \"{Kata.StringClean("33333Ad2dsad3ds21 A3333  1$$s122a!d! A2!A!3Ae$24 f2##222 ")}\""); 
        
        // Assert.That(Kata.StringClean("My \"me3ssy\" d8ata issues2! Will1 th4ey ever, e3ver be3 so0lved?"), Is.EqualTo("My \"messy\" data issues! Will they ever, ever be solved?"));
        Console.WriteLine($"\"My \"me3ssy\" d8ata issues2! Will1 th4ey ever, e3ver be3 so0lved?\" -> \"{Kata.StringClean("My \"me3ssy\" d8ata issues2! Will1 th4ey ever, e3ver be3 so0lved?")}\""); 
        
        // Assert.That(Kata.StringClean("Wh7y can't we3 bu1y the goo0d software3? #cheapskates3"), Is.EqualTo("Why can't we buy the good software? #cheapskates"));
        Console.WriteLine($"\"Wh7y can't we3 bu1y the goo0d software3? #cheapskates3\" -> \"{Kata.StringClean("Wh7y can't we3 bu1y the goo0d software3? #cheapskates3")}\"");
	}
}
