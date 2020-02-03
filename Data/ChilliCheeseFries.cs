using System;

/// <summary>
/// Class representing the
/// </summary>
public class ChilliCheeseFries : Size
{
    /// <summary>
    /// The calorie content of this side
    /// </summary>
    public override uint Calories
    {
        get
        {
            switch(Size)
            {
                case Size.Small:
                    return 433;
                case Size.Medium:
                    return 524;
                case Size.Large:
                    return 610;
                default:
                    throw new NotImplementedException();
            }
        }
    }

    /// <summary>
    /// The price of this side
    /// </summary>
    public override double Price
    {
        get
        {
            switch (Size)
            {
                case Size.Small:
                    return 1.99;
                case Size.Medium:
                    return 2.99;
                case Size.Large:
                    return 3.99;
            }
        }
    }
}
