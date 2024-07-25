
/*

3168. Minimum Number of Chairs in a Waiting Room
Solved
Easy
Topics
Companies
Hint
You are given a string s. Simulate events at each second i:

If s[i] == 'E', a person enters the waiting room and takes one of the chairs in it.
If s[i] == 'L', a person leaves the waiting room, freeing up a chair.
Return the minimum number of chairs needed so that a chair is available for every person who enters the waiting room given that it is initially empty.

 

Example 1:

Input: s = "EEEEEEE"

Output: 7

Explanation:

After each second, a person enters the waiting room and no person leaves it. Therefore, a minimum of 7 chairs is needed.

Example 2:

Input: s = "ELELEEL"

Output: 2

Explanation:

Let's consider that there are 2 chairs in the waiting room. The table below shows the state of the waiting room at each second.

Second	Event	People in the Waiting Room	Available Chairs
0	Enter	1	1
1	Leave	0	2
2	Enter	1	1
3	Leave	0	2
4	Enter	1	1
5	Enter	2	0
6	Leave	1	1
Example 3:

Input: s = "ELEELEELLL"

Output: 3

Explanation:

Let's consider that there are 3 chairs in the waiting room. The table below shows the state of the waiting room at each second.

Second	Event	People in the Waiting Room	Available Chairs
0	Enter	1	2
1	Leave	0	3
2	Enter	1	2
3	Enter	2	1
4	Leave	1	2
5	Enter	2	1
6	Enter	3	0
7	Leave	2	1
8	Leave	1	2
9	Leave	0	3
 

Constraints:

1 <= s.length <= 50
s consists only of the letters 'E' and 'L'.
s represents a valid sequence of entries and exits.
*/
public class Solution {
    public int MinimumChairs(string s) {
        int currentPeople = 0;
        int maxPeople = 0;

        foreach (char c in s) {
            if (c == 'E') {
                currentPeople++;
            } else if (c == 'L') {
                currentPeople--;
            }
            if (currentPeople > maxPeople) {
                maxPeople = currentPeople;
            }
        }

        return maxPeople;
    }
}

// Test cases
void TestSolution() {
    Solution solution = new Solution();

    // Test case 1
    string s1 = "EEEEEEE";
    Console.WriteLine($"Test 1: {solution.MinChairs(s1)}");  // Expected: 7

    // Test case 2
    string s2 = "ELELEEL";
    Console.WriteLine($"Test 2: {solution.MinChairs(s2)}");  // Expected: 2

    // Test case 3
    string s3 = "ELEELEELLL";
    Console.WriteLine($"Test 3: {solution.MinChairs(s3)}");  // Expected: 3
}

// Execute the test cases
TestSolution();


/*  expln


Steps to Solve
Initialize Counters:

currentPeople: To keep track of the current number of people in the waiting room.
maxPeople: To keep track of the maximum number of people at any point in time.
Simulate Events:

Iterate through each character in the string.
If the character is 'E', increment the currentPeople.
If the character is 'L', decrement the currentPeople.
Update maxPeople with the maximum value between maxPeople and currentPeople.
Return Result:

The value of maxPeople will be the minimum number of chairs required.


Initialize Counters:

currentPeople is initialized to 0 to represent the initial state of the waiting room being empty.
maxPeople is also initialized to 0 to keep track of the maximum number of people in the waiting room at any time.
Simulate Events:

We iterate through each character in the string s.
If the character is 'E', it means a person enters the waiting room, so we increment currentPeople.
If the character is 'L', it means a person leaves the waiting room, so we decrement currentPeople.
We then update maxPeople to be the maximum of its current value and currentPeople.
Return Result:

After processing all the events, maxPeople will contain the minimum number of chairs required to accommodate the waiting room at its busiest point.







*/