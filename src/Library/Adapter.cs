namespace Full_GRASP_And_SOLID;

public class Adapter : TimerClient
{
    private CountdownTimer T1 = new CountdownTimer();

    private Recipe recipe;

    public Adapter(Recipe p)
    {
        this.recipe = p;
    }

    public void SetTimer(int TimeOut)
    {
        T1.Register(TimeOut, this);
    }

    public void TimeOut()
    {
        this.recipe.SetCooked();
    }
}