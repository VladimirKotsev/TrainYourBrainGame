namespace TrainYourBrainGame;

public class Randomizer
{
    private const int ButtonMinIndex = 0;
    private const int ButtonMaxIndex = 15;

    private List<CircularButton> buttonList;
    public Randomizer(List<CircularButton> list)
    {
        this.buttonList = list;
    }

    public CircularButton RandomButton()
    {
        return buttonList[InitializeRandom()];
    }

    private int InitializeRandom()
    {
        Random rdm = new Random();
        return rdm.Next(ButtonMinIndex, ButtonMaxIndex);
}
}
