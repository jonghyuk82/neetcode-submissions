public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        int[] state = new int[numCourses];
        var graph = new Dictionary<int, List<int>>();

        for(int i = 0; i < prerequisites.Length; i++)
        {
            var course = prerequisites[i];

            if(!graph.ContainsKey(course[0]))
            {
                graph[course[0]] = new List<int>();
            }

            graph[course[0]].Add(course[1]);
        }        

        for (int i = 0; i < numCourses; i++)
        {
            if (HasCycle(i))
            {
                return false;
            }
        }

        return true;


        bool HasCycle(int node)
        {
            if(state[node] == 1)
            {
                return true;
            }
            if(state[node] == 2)
            {
                return false;
            }

            state[node] = 1;

            if(graph.ContainsKey(node))
            {
                foreach(var neighbor in graph[node])
                {
                    var result = HasCycle(neighbor);

                    if(result)
                    {
                        return true;
                    }                                                                    
                }
            }            

            state[node] = 2;

            return false;
            
        }
    }
}
