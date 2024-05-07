namespace ChessLibrary;

public abstract class ChessPiece
{
    public abstract int GetStartCoordinateX();
    
    public abstract int GetStartCoordinateY();
    
    public abstract int GetFinishCoordinateX();
    
    public abstract int GetFinishCoordinateY();

    public abstract bool CanMove();
}
