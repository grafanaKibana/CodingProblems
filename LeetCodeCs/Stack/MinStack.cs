namespace LeetCodeCs.Stack;

public static partial class Problem
{
    public class MinStack {
        private List<int> elems;
        private List<int> mins;

        public MinStack() {
            this.elems = new List<int>();
            this.mins = new List<int>();
        }

        public void Push(int val) {
            elems.Add(val);

            if(mins.Count == 0){
                mins.Add(val);
            }
            else if(mins[^1] >= val){
                mins.Add(val);
            }
        }

        public void Pop() {
            if(mins.Count > 0 && this.mins[^1] == this.elems[^1]){
                mins.RemoveAt(mins.Count - 1);
            }
            if(elems.Count > 0){
                elems.RemoveAt(elems.Count - 1);
            }

        }

        public int Top() {
            return elems.Count > 0 ? elems[^1] : default(int);
        }

        public int GetMin() {
            return mins.Count > 0 ? this.mins[^1] : default(int);
        }
    }
}



/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */