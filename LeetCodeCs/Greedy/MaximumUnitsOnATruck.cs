namespace LeetCodeCs.Greedy;

public static partial class Problem
{
    public static int MaximumUnits(int[][] boxTypes, int truckSize) {
        var totalUnits = 0;
        var orderedBoxes = boxTypes.OrderByDescending(x => x[1]).ToArray();

        for(var i = 0; i < orderedBoxes.Length; i++){
            while(truckSize > 0 && orderedBoxes[i][0] > 0){
                truckSize--;
                orderedBoxes[i][0]--;
                totalUnits += orderedBoxes[i][1];
            }

        }

        return totalUnits;
    }
}