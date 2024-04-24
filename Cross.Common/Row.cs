namespace Cross.Common;

public class Row
{
    private readonly ICollection<Cell> cells;

    public Row(ICollection<Cell> cells)
    {
        this.cells = cells;
    }
    public byte OwnedPlayer()
    {
        var groups = cells.GroupBy(x => x.Status);
        var winner = groups.Where(x => x.Count() == cells.Count);
        foreach (var group in winner)
        {
            return group.Key;
        }
        return 0;
    }
}
