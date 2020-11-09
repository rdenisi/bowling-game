using System;

namespace BowlingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            int score = 0;

            var frames = new Frame[]
            {
                new Frame() { FirstShot = 1, SecondShot = 4 },
                new Frame() { FirstShot = 4, SecondShot = 5 },
                new Frame() { FirstShot = 6, SecondShot = 4 },
                new Frame() { FirstShot = 5, SecondShot = 5 },
                new Frame() { FirstShot = 10, SecondShot = 0 },
                new Frame() { FirstShot = 0, SecondShot = 1 },
                new Frame() { FirstShot = 7, SecondShot = 3 },
                new Frame() { FirstShot = 6, SecondShot = 4 },
                new Frame() { FirstShot = 10, SecondShot = 0 },
                new Frame() { FirstShot = 2, SecondShot = 8 },
                new Frame() { FirstShot = 6, SecondShot = 0 }
            };

            for (int i = 0; i < frames.Length; i++)
            {
                int nextFrameIndex = i + 1;
                if (nextFrameIndex > frames.Length - 1) break;
                score += ScoreCalculator.CalculatePartialScore(frames[i], frames[nextFrameIndex]);
            }

            Console.WriteLine($"The score is {score}.");

            Console.WriteLine("End");
        }
    }
}