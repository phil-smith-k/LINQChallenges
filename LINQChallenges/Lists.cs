﻿using LINQChallenges.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQChallenges
{
    public static class Lists
    {
        public static IEnumerable<string> StringList => new List<string>
        {
            "hose", 
            "bore", 
            "multiply",
            "alluring",
            "agreeable",
            "charge",
            "milky",
            "obnoxious",
            "overjoyed",
            "damaged",
            "disappear",
            "ruthless",
            "care",
            "narrow",
            "metal",
            "own",
            "striped",
            "certain",
            "wealthy",
            "brainy",
            "zoo",
            "clever",
            "kill",
            "rake",
            "flavor",
            "crate",
            "knit",
            "ad hoc",
            "feigned",
            "disarm",
            "greet",
            "glow",
            "assorted",
            "ice",
            "brake",
            "ring",
            "friendly",
            "muddle",
            "whole",
            "group",
            "well-made",
            "supreme",
            "chivalrous",
            "bubble",
            "girls",
            "pushy",
            "courageous",
            "cycle",
            "squeamish",
            "page",
            "invincible",
            "crazy",
            "mice",
            "direful",
            "scribble",
            "uninterested",
            "cagey",
            "obedient",
            "tearful",
            "cows",
            "reason",
            "library",
            "toad",
            "cheese",
            "literate",
            "reminiscent",
            "expand",
            "rings",
            "try",
            "hanging",
            "mitten",
            "nest",
            "cumbersome",
            "crabby",
            "zesty",
            "superb",
            "thick",
            "lopsided",
            "root",
            "care",
            "sky",
            "zipper",
            "gaze",
            "lumber",
            "extra-small",
            "sleep",
            "puzzled",
            "monkey",
            "pour",
            "fruit",
            "suffer",
            "multiply",
            "psychedelic",
            "burly",
            "transport",
            "deeply",
            "stomach",
            "carry",
            "beneficial",
            "embarrass",
            "rude",
            "sticky",
            "magnificent",
            "detailed"
        };
        public static IEnumerable<int> IntList => new List<int>
        {
            119768,
            12989,
            118707,
            79189,
            44379,
            20169,
            134163,
            30997,
            142681,
            180014,
            51105,
            56307,
            68156,
            36302,
            155364,
            67021,
            42909,
            7915,
            182458,
            166335,
            21548,
            118488,
            71562,
            108233,
            183579,
            173534,
            91467,
            -19160,
            105078,
            158209,
            186948,
            90143,
            -101943,
            109484,
            154391,
            63405,
            168239,
            194712,
            12254,
            18833,
            23804,
            57517,
            146904,
            53596,
            161612,
            142611,
            52115,
            28747,
            162875,
            66784,
            173087,
            105804,
            129675,
            188484,
            168190,
            1280,
            141427,
            10473,
            95609,
            70845,
            128701,
            -115002,
            125918,
            184471,
            193065,
            160962,
            154364,
            158672,
            81910,
            91959,
            98781,
            48197,
            195661,
            163624,
            142531,
            164031,
            171583,
            17965,
            146621,
            40968,
            121419,
            62720,
            56284,
            38293,
            185121,
            81144,
            160467,
            113458,
            141293,
            153111,
            121977,
            157766,
            99102,
            141408,
            90132,
            108801,
            131598,
            162432,
            60530,
            -649,
            188247,
            93442,
            146836,
            70916,
            168003,
            124890,
            110142,
            166050,
            45953,
            4159,
            29696,
            123462,
            63851,
            54641,
            149425,
            65981,
            58717,
            87624,
            199349,
            111921,
            495,
            40905,
            17379,
            128799,
            169981,
            141015,
            149094,
            -54252,
            73492,
            33729,
            32432,
            9151,
            157434,
            145972,
            52721,
            27976,
            115883,
            185368,
            70290,
            60231,
            171001,
            194416,
            67505,
            137133,
            123414,
            198515,
            93914,
            44461,
            191983,
            24150,
            50083,
            43973,
            163082,
            148609,
            154,
            147341,
            76063,
            18037,
            100935,
            26987,
            175795,
            55889,
            92558,
            12223,
            171726,
            20545,
            166027,
            117879,
            1919,
            121449,
            -150098,
            73349,
            17333,
            139118,
            140920,
            6078,
            173400,
            80246,
            5384,
            171465,
            47100,
            104632,
            62269,
            49341,
            183645,
            188458,
            46068,
            -8825,
            145817,
            105379,
            151913,
            97846,
            84433,
            43303,
            84436,
            115111,
            101858,
            55282,
            165406,
            102869,
        };
        public static IEnumerable<Applicant> ApplicantList => new List<Applicant> 
        {  
            new Applicant("Mia", "Smith", new DateTime(2021, 8, 6), 10, "Senior Graphic Designer", new Range<decimal>(90000, 95000)),
            new Applicant("Vanessa", "Gross", new DateTime(2021, 8, 1), 2, "Junior UX Designer", new Range<decimal>(45000, 55000)),
            new Applicant("Tabitha", "Read", new DateTime(2021, 8, 14), 5, "Web Developer", new Range<decimal>(75000, 80000)),
            new Applicant("Chantelle", "Lowe", new DateTime(2021, 8, 4), 3, "Web Developer", new Range<decimal>(70000, 80000)),
            new Applicant("Mollie", "Terry", new DateTime(2021, 8, 4), 15, "Senior Graphic Designer", new Range<decimal>(90000, 100000)),
            new Applicant("Mary", "Erickson", new DateTime(2021, 8, 2), 4, "Software Engineer", new Range<decimal>(70000, 80000)),
            new Applicant("Reah", "Graves", new DateTime(2021, 8, 13), 3, "Software Engineer", new Range<decimal>(70000, 80000)),
            new Applicant("Patricia", "Heath", new DateTime(2021, 8, 1), 5, "Software Engineer", new Range<decimal>(72000, 85000)),
            new Applicant("Kiera", "Rios", new DateTime(2021, 7, 29), 8, "Senior Graphic Designer", new Range<decimal>(82000, 98000)),
            new Applicant("Natalie", "Rogers", new DateTime(2021, 7, 31), 12, "Senior Graphic Designer", new Range<decimal>(100000, 105000)),
            new Applicant("Frank", "Rowe", new DateTime(2021, 8, 12), 2, "Web Developer", new Range<decimal>(50000, 75000)),
            new Applicant("Carlos", "Navarro", new DateTime(2021, 8, 16), 6, "Web Developer", new Range<decimal>(75000, 80000)),
            new Applicant("Lukas", "Martin", new DateTime(2021, 8, 17), 0, "Junior UX Designer", new Range<decimal>(35000, 50000)),
            new Applicant("Jackson", "Matthews", new DateTime(2021, 7, 30), 0, "Junior UX Designer", new Range<decimal>(40000, 50000)),
            new Applicant("Solomon", "Griffin", new DateTime(2021, 8, 5), 1, "Junior UX Designer", new Range<decimal>(40000, 55000)),
            new Applicant("Clayton", "Humphreys", new DateTime(2021, 6, 30), 4, "Web Developer", new Range<decimal>(50000, 70000)),
            new Applicant("Mason", "Bishop", new DateTime(2021, 7, 4), 2, "Software Engineer", new Range<decimal>(55000, 60000)),
            new Applicant("Robbie", "Lewis", new DateTime(2021, 8, 4), 3, "Software Engineer", new Range<decimal>(60000, 70000)),
            new Applicant("Xander", "Robinson", new DateTime(2021, 8, 2), 18, "Senior Graphic Designer", new Range<decimal>(120000, 130000)),
            new Applicant("Chris", "Bowers", new DateTime(2021, 7, 15), 6, "Software Engineer", new Range<decimal>(75000, 85000)),
            new Applicant("Marven", "Haynes", new DateTime(2021, 7, 12), 0, "Junior UX Designer", new Range<decimal>(30000, 45000)),
        };
    }
}