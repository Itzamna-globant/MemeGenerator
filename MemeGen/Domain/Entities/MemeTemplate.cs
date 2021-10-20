using NetTopologySuite.Geometries;

namespace MemeGen.Domain.Entities
{
    public class MemeTemplate
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Polygon TextRectangleLocation { get; set; }
    }
}
