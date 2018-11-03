﻿/************************************************************************************
 *
 * Kyle Nally
 * CIS237 T/Th 3:30pm Assignment 4 - Algorithms: Modified Bucket Sort and Merge Sort
 * 11/3/2018
 *
 ************************************************************************************/

namespace cis237_assignment4
{
    interface IDroidCollection
    {
        // Various overloaded Add methods to add a new droid to the collection
        void Add(string material, string color, int numberOfLanguages);
        void Add(string material, string color, bool hasToolBox, bool hasComputerConnection, bool hasArm);
        void Add(string material, string color, bool hasToolBox, bool hasComputerConnection, bool hasArm, bool hasTrashCompactor, bool hasVaccum);
        void Add(string material, string color, bool hasToolBox, bool hasComputerConnection, bool hasArm, bool hasFireExtinguisher, int numberOfShips);

        void CategorizeByModel();
        // Method to get the data for a droid into a nicely formated string that can be output.
        string[] PrintTheDroidsInventory();
    }
}
