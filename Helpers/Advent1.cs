namespace aoc2023.Helpers;

public static class Advent1
{
    private static readonly (string, char)[] Digits =
    {
        ("1", '1'),
        ("2", '2'),
        ("3", '3'),
        ("4", '4'),
        ("5", '5'),
        ("6", '6'),
        ("7", '7'),
        ("8", '8'),
        ("9", '9'),
    };
    
    private static readonly (string,char)[] LiteralDigits = {
        ("one", '1'),
        ("two", '2'),
        ("three", '3'),
        ("four", '4'),
        ("five", '5'),
        ("six", '6'),
        ("seven", '7'),
        ("eight", '8'),
        ("nine", '9')
    };
    
    public static int Advent1GetIntFromNoisyString(this string s, bool includeLiterals = false) =>
        int.Parse(
            new string(
                Enumerable
                    .Range(0, s.Length)
                    .SelectMany(i => 
                        (includeLiterals ? LiteralDigits.Concat(Digits) : Digits)
                            .Where(d => s[i..].StartsWith(d.Item1))
                            .Select(d => d.Item2)
                    )
                    .ToArray() switch {
                        { Length: 0 } => throw new NotImplementedException(),
                        { Length: 1 } cs => string.Join("", cs[0], cs[0]),
                        { } cs => string.Join("", cs[0], cs[^1])
                    }
            )
        );
}
