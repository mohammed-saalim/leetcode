// https://leetcode.com/problems/binary-tree-inorder-traversal/description/


/*

94. Binary Tree Inorder Traversal
Solved
Easy
Topics
Companies
Given the root of a binary tree, return the inorder traversal of its nodes' values.

 

Example 1:


Input: root = [1,null,2,3]
Output: [1,3,2]
Example 2:

Input: root = []
Output: []
Example 3:

Input: root = [1]
Output: [1]
 

Constraints:

The number of nodes in the tree is in the range [0, 100].
-100 <= Node.val <= 100
 

Follow up: Recursive solution is trivial, could you do it iteratively?

*/

public class Solution {
    List<int> ans = new List<int>();

    public IList<int> InorderTraversal(TreeNode root) {
        if (root == null) return ans;
        InorderTraversal(root.left);
        ans.Add(root.val);
        InorderTraversal(root.right);
        return ans;
    }
}