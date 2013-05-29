using System;

public class Program {
    // Two strings can be made equal by deleting characters from them.
    // For example, by deleting 'a' from the string "abc" and 'd' from
    // the string "bcd", strings "abc" and "bcd" became equal
    // by deleting two characters.
    // Your task is to find the minimal number of characters which have
    // to be deleted, to make two string equal.
    public static int Puzzle(string s, string t) {

        int[] dp = new int[69];
        dp[0] = 0;

        int memI, memJ;
        int step;
        for (step = 0; s.Length > 0 && t.Length > 0; step++) {
            if (s[0] == t[0]) {
                dp[step + 1] = dp[step];
                s =s.Substring(1);
                t = t.Substring(1);
                continue;
            } else {
                int minim = 2000000069;
                memI = -1; memJ = -1;
                for (int i = 0; i < s.Length; i++) {
                    for (int j = 0; j < t.Length; j++) {
                        if (s[i] == t[j]) {
                            if (( i + j ) < minim) {
                                minim = i + j;
                                memI = i;
                                memJ = j;
                            }
                        }
                    }
                }

                if (memI == -1) {
                    return (s.Length + t.Length);
                }
                s = s.Substring(memI + 1);
                t = t.Substring(memJ + 1);

                dp[step + 1] = dp[step] + minim;
            }
        }

        return (dp[step] + s.Length + t.Length);
    }

    public static void Main() {
        Console.WriteLine(Puzzle("bbbc", "bcbc")); 
    }

}
