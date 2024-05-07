namespace ChessLibrary;

public class Bishop : ChessPiece
{
    private int X { get; set; }
    private int Y { get; set; }
    private int NewX { get; set; }
    private int NewY { get; set; }
    
    public Bishop(int x, int y, int newX, int newY)
    {
        if (!IsValidCoordinate(x) || !IsValidCoordinate(y) || !IsValidCoordinate(newX) || !IsValidCoordinate(newY))
        {
            throw new ArgumentException("Указаны неверные координаты");
        }

        X = x;
        Y = y;
        NewX = newX;
        NewY = newY;
    }

    private bool IsValidCoordinate(int coordinate)
    {
        return coordinate >= 1 && coordinate <= 8;
    }

    public override int GetStartCoordinateX()
    {
        return X;
    }

    public override int GetStartCoordinateY()
    {
        return Y;
    }
    
    public override int GetFinishCoordinateX()
    {
        return NewX;
    }
    
    public override int GetFinishCoordinateY()
    {
        return NewY;
    }

    public override bool CanMove()
    {
        return Math.Abs(NewX - X) == Math.Abs(NewY - Y);
    }

    public override string ToString()
    {
        return $"Слон с начальными координатами [x: {X}, y: {Y}]";
    }
}
