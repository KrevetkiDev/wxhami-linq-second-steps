using System.ComponentModel.Design;

void TaskOne()
{
    List<int> listForSortt = new List<int>() { 1, 3, 5, 10 };
    List<int> sortedListt = new List<int>();

    var num = listForSortt.Where(number => number > 3);
    
    List<int> Sort(List<int> listForSort, List<int> sortedList)
    {
        listForSort = listForSortt;
        sortedList = sortedListt;
        foreach (var number in listForSort)
        {
            if (number > 3)
            {
                sortedList.Add(number);
            }
        }
        return sortedList;
    }
}

void TaskTwo()
{
    List<int> listForSort = new List<int>() { 1, 3, 5, 10 };

    var firtNumber = listForSort.FirstOrDefault(number => number == 4);

    int GetElement(List<int> list, int number)
    {
        foreach (var numb in list)
                {
                    if (numb == number)
                    {
                        return numb;
                    }
                }

        return default;
    }
}