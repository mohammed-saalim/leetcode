
// https://leetcode.com/problems/cheapest-flights-within-k-stops/description/



/*
787. Cheapest Flights Within K Stops
Solved
Medium
Topics
Companies
There are n cities connected by some number of flights. You are given an array flights where flights[i] = [fromi, toi, pricei] indicates that there is a flight from city fromi to city toi with cost pricei.

You are also given three integers src, dst, and k, return the cheapest price from src to dst with at most k stops. If there is no such route, return -1.

 

Example 1:


Input: n = 4, flights = [[0,1,100],[1,2,100],[2,0,100],[1,3,600],[2,3,200]], src = 0, dst = 3, k = 1
Output: 700
Explanation:
The graph is shown above.
The optimal path with at most 1 stop from city 0 to 3 is marked in red and has cost 100 + 600 = 700.
Note that the path through cities [0,1,2,3] is cheaper but is invalid because it uses 2 stops.
Example 2:


Input: n = 3, flights = [[0,1,100],[1,2,100],[0,2,500]], src = 0, dst = 2, k = 1
Output: 200
Explanation:
The graph is shown above.
The optimal path with at most 1 stop from city 0 to 2 is marked in red and has cost 100 + 100 = 200.
Example 3:


Input: n = 3, flights = [[0,1,100],[1,2,100],[0,2,500]], src = 0, dst = 2, k = 0
Output: 500
Explanation:
The graph is shown above.
The optimal path with no stops from city 0 to 2 is marked in red and has cost 500.
 

Constraints:

1 <= n <= 100
0 <= flights.length <= (n * (n - 1) / 2)
flights[i].length == 3
0 <= fromi, toi < n
fromi != toi
1 <= pricei <= 104
There will not be any multiple flights between two cities.
0 <= src, dst, k < n
src != dst


*/




public class Solution {
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) {
        // Initialize the cost array with infinity
        int[] cost = new int[n];
        for (int i = 0; i < n; i++) {
            cost[i] = int.MaxValue;
        }
        cost[src] = 0;

        // Iterate k+1 times to allow for up to k stops
        for (int i = 0; i <= k; i++) {
            int[] tempCost = (int[])cost.Clone();
            foreach (var flight in flights) {
                int from = flight[0];
                int to = flight[1];
                int price = flight[2];
                if (cost[from] != int.MaxValue) {
                    tempCost[to] = Math.Min(tempCost[to], cost[from] + price);
                }
            }
            cost = tempCost;
        }

        return cost[dst] == int.MaxValue ? -1 : cost[dst];
    }
}



/*



Understanding the Problem
The problem is about finding the cheapest flight path from a source city (src) to a destination city (dst) with at most k stops. The flight information is provided in a list where each flight is represented by [from, to, price].

Key Points:
Cities and Flights: You have n cities and several flights connecting them.
Source and Destination: You need to find the cheapest path from src to dst.
Stops Constraint: You can have at most k stops in your journey.
Example Explanation:
Example 1:

Input: n = 4, flights = [[0, 1, 100], [1, 2, 100], [2, 0, 100], [1, 3, 600], [2, 3, 200]], src = 0, dst = 3, k = 1
Output: 700
Explanation:
The optimal path with at most 1 stop is from city 0 to 1 (cost 100) and then from city 1 to 3 (cost 600), making the total cost 700.
Example 2:

Input: n = 3, flights = [[0, 1, 100], [1, 2, 100], [0, 2, 500]], src = 0, dst = 2, k = 1
Output: 200
Explanation:
The optimal path with at most 1 stop is from city 0 to 1 (cost 100) and then from city 1 to 2 (cost 100), making the total cost 200.
Example 3:

Input: n = 3, flights = [[0, 1, 100], [1, 2, 100], [0, 2, 500]], src = 0, dst = 2, k = 0
Output: 500
Explanation:
The optimal path with no stops is from city 0 to 2 directly (cost 500).
Steps to Solve
Initialization:

Initialize a cost array to keep track of the minimum cost to reach each city.
Set the cost to reach the source city to 0.
Relax Edges:

Iterate k+1 times to allow for up to k stops.
Use a temporary cost array to store updated costs during each iteration to avoid overwriting.
Update Costs:

For each flight, update the cost if a cheaper path is found.
Return Result:

If the destination city's cost is still infinity after the iterations, return -1 (no valid path found).
Otherwise, return the cost to reach the destination city.

code expln
Explanation
Initialization:

Create an array cost where each element is initially set to int.MaxValue (representing infinity).
Set cost[src] to 0 since the cost to reach the source city from itself is 0.
Relax Edges:

Iterate k+1 times to allow for up to k stops.
Use a temporary array tempCost to store updated costs during each iteration to avoid overwriting values within the same iteration.
Update Costs:

For each flight [from, to, price], update the cost to reach to if a cheaper path is found via from.
Specifically, if cost[from] is not infinity, update tempCost[to] to the minimum of its current value and cost[from] + price.
Return Result:

After all iterations, if cost[dst] is still int.MaxValue, return -1 (no valid path found).
Otherwise, return cost[dst], the minimum cost to reach the destination city.
This solution leverages the Bellman-Ford algorithm to handle the constraint of k stops efficiently and ensures that the minimum cost is found within the specified constraints.