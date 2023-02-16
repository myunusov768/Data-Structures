
namespace Graph
{

    public sealed class Vertex
    {
        public int Value { get; set; }
        public Vertex(int value) { Value = value; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    public class Edge
    {
        public Vertex From { get; set; }
        public Vertex To { get; set; }
        public int Weight { get; set; } = 0;
        public Edge(Vertex from, Vertex to)
        {
            From = from;
            To = to;
            Weight = 1;
        }

        public override string ToString()
        {
            return $"{From}, {To}";
        }
    }

    public sealed class MyGraph
    {
        public readonly List<Vertex> Vertices;
        public readonly List<Edge> Edges;
        public MyGraph()
        {
            Vertices = new List<Vertex>();
            Edges = new List<Edge>();
        }

        public int[,] GetMatrix()
        {
            var _matrix = new int[Vertices.Count, Vertices.Count];
            
            foreach (var e in Edges) 
            {
                var row = e.From.Value - 1;
                var column = e.To.Value - 1;

                _matrix[row, column] = e.Weight;
            }
            return _matrix;
        }

        public bool AddVertex(int value)
        {
            var _vertex = GetVertex(value);
            if(_vertex != null)
                return false;
            var _newVertex = new Vertex(value);
            Vertices.Add(_newVertex);
            return true;
        }
        public bool AddEdge(Vertex from, Vertex to) 
        {
            var _verTo = GetVertex(to.Value);
            if(_verTo == null)
                return false;
            var _verFrom = GetVertex(from.Value);
            if(_verFrom == null)
                return false;
            var _newEdge = new Edge(_verFrom, _verTo);
            Edges.Add(_newEdge);
            return true;
        }


        public Vertex GetVertex(int value)
        {
            var _vertex = Vertices.FirstOrDefault(x => x.Value == value);
            if (_vertex == null)
                return null;
            return _vertex;
        }
    }
}
