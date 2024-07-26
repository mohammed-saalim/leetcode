/*
leetcode 100. Same Tree
Attempted
Easy
Topics
Companies
Given the roots of two binary trees p and q, write a function to check if they are the same or not.

Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.

 

Example 1:


Input: p = [1,2,3], q = [1,2,3]
Output: true
Example 2:


Input: p = [1,2], q = [1,null,2]
Output: false
Example 3:


Input: p = [1,2,1], q = [1,1,2]
Output: false
 

Constraints:

The number of nodes in both trees is in the range [0, 100].
-104 <= Node.val <= 104


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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        // If both nodes are null, they are the same
        if (p == null && q == null) return true;

        // If one of the nodes is null, they are not the same
        if (p == null || q == null) return false;

        // If the values of the nodes are different, they are not the same
        if (p.val != q.val) return false;

        // Recursively check left and right subtrees
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}

// Test cases
void TestSolution() {
    Solution solution = new Solution();

    // Test case 1
    TreeNode p1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
    TreeNode q1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
    Console.WriteLine($"Test 1: {solution.IsSameTree(p1, q1)}");  // Expected: true

    // Test case 2
    TreeNode p2 = new TreeNode(1, new TreeNode(2), null);
    TreeNode q2 = new TreeNode(1, null, new TreeNode(2));
    Console.WriteLine($"Test 2: {solution.IsSameTree(p2, q2)}");  // Expected: false

    // Test case 3
    TreeNode p3 = new TreeNode(1, new TreeNode(2), new TreeNode(1));
    TreeNode q3 = new TreeNode(1, new TreeNode(1), new TreeNode(2));
    Console.WriteLine($"Test 3: {solution.IsSameTree(p3, q3)}");  // Expected: false
}

// Execute the test cases
TestSolution();
