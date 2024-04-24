namespace Cross.Common;

public class Field
{
    private readonly Cell[] cells;
    private readonly Row[] rows;

    public Field()
    {
        cells = new Cell[9];
        for (int i = 0; i < cells.Length; i++)
        { 
            cells[i] = new Cell(); 
        }
        rows = new Row[]
        {
            new Row(new Cell[] {cells[0], cells[1], cells[2]}),
            new Row(new Cell[] {cells[3], cells[4], cells[5]}),
            new Row(new Cell[] {cells[6], cells[7], cells[8]}),

            new Row(new Cell[] {cells[0], cells[3], cells[6]}),
            new Row(new Cell[] {cells[1], cells[4], cells[7]}),
            new Row(new Cell[] {cells[2], cells[5], cells[8]}),

            new Row(new Cell[] {cells[0], cells[4], cells[8]}),
            new Row(new Cell[] {cells[6], cells[4], cells[2]}),
        };

    }
}