using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Koala.Models;
using Newtonsoft.Json;

namespace Koala.Pages.Administration.Hospitals {
    public class IndexModel : PageModel {
        private readonly koalaContext _context;

        public List<TreeNode> TreeView { get; set; }
        public IndexModel(koalaContext context) {
            _context = context;
        }

        public IList<Hospital> Hospital { get; set; }
        public IList<Section> Sections { get; set; }
        public string Section_Html { get; set; }

        public IActionResult OnGet() {
            Hospital = _context.Hospitals.ToList();
            Sections = _context.Sections.ToList();

            TreeView = new List<TreeNode>();
            foreach (var item in Hospital) {
                TreeNode node = new TreeNode(item.Id,-1,item.Name);
                node.SubNodes = BuildSubNodes(item.Id,-1);
                TreeView.Add(node);
            }

            //if (Hospital.Count > 0) {
            //    return RedirectToPage("Create");
            //} else {
            //}
            //
            return Page();
        }
        List<TreeNode> BuildSubNodes(int hospital_id, int root_id) {
            List<TreeNode> nodes = new List<TreeNode>();
            var subSecitons = Sections.Where(t=>t.HospitalId == hospital_id && t.ParentId == root_id).ToList();
            foreach (var item in subSecitons) {
                TreeNode node = new TreeNode(item.Id,item.ParentId.Value,item.Name);
                if (root_id == -1) {
                    node.Parent_id = hospital_id;
                }
                node.SubNodes = BuildSubNodes(hospital_id, item.Id);
                nodes.Add(node);
            }

            return nodes;
        }
    }
}