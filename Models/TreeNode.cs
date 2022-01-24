using System.Collections.Generic;

namespace Koala.Models {
    public class TreeNode {
        public TreeNode(int id, int parent_id, string name,int count=0) {
            Id = id;
            Parent_id = parent_id;
            Name = name;
            Count = count;
        }
        public int Id { get; set; }
        public int Parent_id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Count { get; set; }
        public List<TreeNode> SubNodes { get; set; } = new List<TreeNode>();
    }
}
