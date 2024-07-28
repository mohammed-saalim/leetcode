/*
101. Symmetric Tree
Solved
Easy
Topics
Companies
Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).

 

Example 1:


Input: root = [1,2,2,3,4,4,3]
Output: true
Example 2:


Input: root = [1,2,2,null,3,null,3]
Output: false
 

Constraints:

The number of nodes in the tree is in the range [1, 1000].
-100 <= Node.val <= 100
 

Follow up: Could you solve it both recursively and iteratively?


*/


/**
 * Definition for a binary tree node.
 */
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution {
    public bool IsSymmetric(TreeNode root) {
        return root == null || IsMirror(root.left, root.right);
    }

    private bool IsMirror(TreeNode left, TreeNode right) {
        if (left == null && right == null) return true;
        if (left == null || right == null) return false;
        return (left.val == right.val) && IsMirror(left.left, right.right) && IsMirror(left.right, right.left);
    }
}


void TestSolution() {
    Solution solution = new Solution();

    
    TreeNode root1 = new TreeNode(1,
        new TreeNode(2, new TreeNode(3), new TreeNode(4)),
        new TreeNode(2, new TreeNode(4), new TreeNode(3))
    );
    Console.WriteLine($"Test 1: {solution.IsSymmetric(root1)}"); 

    
    TreeNode root2 = new TreeNode(1,
        new TreeNode(2, null, new TreeNode(3)),
        new TreeNode(2, null, new TreeNode(3))
    );
    Console.WriteLine($"Test 2: {solution.IsSymmetric(root2)}");  
}

TestSolution();
