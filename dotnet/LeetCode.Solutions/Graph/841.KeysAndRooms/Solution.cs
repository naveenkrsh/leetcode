using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.Graph.KeysAndRooms
{
    public class Solution
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            var totalRooms = rooms.Count;
            var visted = new bool[totalRooms];


            CanVisitAllRoomsUtil(0, totalRooms, rooms, visted);


            for (int i = 0; i < totalRooms; i++)
            {
                if (visted[i] == false)
                    return false;
            }
            return true;
        }

        public void CanVisitAllRoomsUtil(int currentRoom, int totalRooms, IList<IList<int>> rooms, bool[] visted)
        {
            if (visted[currentRoom])
                return;
            visted[currentRoom] = true;
            for (int i = 0; i < rooms[currentRoom].Count; i++)
            {
                CanVisitAllRoomsUtil(rooms[currentRoom][i], totalRooms, rooms, visted);
            }
        }
    }
}
