using System.Collections.Generic;

namespace Koala.Models {
    public class TreeNode {
        public TreeNode(int id, int parent_id, string name,bool is_section=false) {
            Id = id;
            Parent_id = parent_id;
            Name = name;
            IsSection = is_section;
        }
        public int Id { get; set; }
        public int Parent_id { get; set; }
        public string Name { get; set; }
        public bool IsSection { get; set; }
        public int Count { get; set; }
        public List<TreeNode> SubNodes { get; set; } = new List<TreeNode>();
    }
}
