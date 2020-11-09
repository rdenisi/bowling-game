namespace BowlingGame
{
    public class Frame
    {
        public int FirstShot { get; set; }
        public int SecondShot { get; set; }
        public bool IsStrike => FirstShot == 10;
        public bool IsSpare => FirstShot != 10 && FirstShot + SecondShot == 10;
    }
}