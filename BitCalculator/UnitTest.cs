﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DevTools
{
    internal class UnitTest
    {
        List<UnitTest> unitTests = new List<UnitTest>()
        {
            new UnitTest("nw np 4==4?5:3", "5"),
            new UnitTest("#del bob; #define bob = 2; nw np bob + 7", "9"),
            new UnitTest("alg(7,-11,-6)", "(1x-2)(7x+3)"),
            new UnitTest("nw np tan(70)", "Closest conversion: 2.7474774194546216"),
            new UnitTest("loop 10: nw np i", "0\n1\n2\n3\n4\n5\n6\n7\n8\n9"),
            new UnitTest("hrgb ffffff", "rgb(255,255,255);"),
            new UnitTest("nw np tan(70)+sin(90)-arccos(60)-40+6.75532-3", "Closest conversion: -49.75532"),
            new UnitTest("nw np b_01010101010000101001010101 + 345", "22350766"),
            new UnitTest("nw np doum b_01010101010000101001010101 + 345", "Closest conversion: 22350766"),
        };

        public string Input;
        public string ExpectedOutput;

        public UnitTest(string input, string expectedOutput)
        {
            Input = input;
            ExpectedOutput = expectedOutput;
        }

        public bool Test()
        {
            return false;
        }
    }
}