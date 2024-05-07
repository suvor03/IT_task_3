namespace ChessLibrary;

public class Queen : ChessPiece
{
    private int X { get; set; }
    private int Y { get; set; }
    private int NewX { get; set; }
    private int NewY { get; set; }
    
    public Queen(int x, int y, int newX, int newY)
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
        int deltaX = Math.Abs(NewX - X);
        int deltaY = Math.Abs(NewY - Y);
            
        bool isRookMove = NewX == X || NewY == Y;
            
        bool isBishopMove = deltaX == deltaY;
            
        return isRookMove || isBishopMove;
    }

    public override string ToString()
    {
        return $"Ферзь с начальными координатами [x: {X}, y: {Y}]";
    }
}