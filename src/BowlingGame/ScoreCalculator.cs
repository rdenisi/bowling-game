namespace BowlingGame
{
    public static class ScoreCalculator
    {
        public static int CalculatePartialScore(Frame frame, Frame nextFrame)
        {
            if (frame.IsStrike)
            {
                return 10 + nextFrame.FirstShot + nextFrame.SecondShot;
            }
            else if (frame.IsSpare)
            {
                return 10 + nextFrame.FirstShot;
            }
            else
            {
                return frame.FirstShot + frame.SecondShot;
            }
        }
    }
}