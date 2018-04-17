namespace InfiniteBinaryTree
{
    using System.Collections.Generic;
    
    class Generator {
        private Dictionary<ulong, Node> repository = new Dictionary<ulong, Node>();
        
        public double Alpha
        {
            get;
            private set;
        }
        
        public double Length 
        {
            get;
            private set;
        }
        
        public double ReductionFactor
        {
            get;
            private set;
        }
        
        public Generator(double length, double reductionFactor, double alpha)
        {
            this.Alpha = alpha;
            this.Length = length;
            this.ReductionFactor = reductionFactor;
        }
        
    }
}