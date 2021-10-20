using NetTopologySuite.Geometries;

namespace MemeGen.Domain.Entities
{
    public class MemeTemplate
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Point TextRectangleOrigin { get; set; }

        public int TextRectangleMaxWidth { get; set; }

        public int TextRectangleMaxHeight { get; set; }
    }
}
